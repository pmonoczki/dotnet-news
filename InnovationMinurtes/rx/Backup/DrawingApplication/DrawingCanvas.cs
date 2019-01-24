using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DrawingApplication
{
  public partial class DrawingCanvas : UserControl
  {
    private List<Line> lines = new List<Line>();
    private Position selectedObject;
    private Position hotObject;

    private Position SelectedObject
    {
      get
      {
        return this.selectedObject;
      }
      set
      {
        this.selectedObject = value;
        this.Invalidate();
      }
    }

    private Position HotObject
    {
      get
      {
        return this.hotObject;
      }
      set
      {
        this.hotObject = value;
        this.Invalidate();
      }
    }

    public DrawingCanvas()
    {
      InitializeComponent();

      // Represent the mouse events as observables.
      var movingEvents = Observable.FromEvent<MouseEventHandler, MouseEventArgs>(handler => ConvertHandler(handler), h => this.MouseMove += h, h => this.MouseMove -= h);
      var upEvents = Observable.FromEvent<MouseEventHandler, MouseEventArgs>(handler => ConvertHandler(handler), h => this.MouseUp += h, h => this.MouseUp -= h);
      var downEvents = Observable.FromEvent<MouseEventHandler, MouseEventArgs>(handler => ConvertHandler(handler), h => this.MouseDown += h, h => this.MouseDown -= h);

      // Construct all moving as differences between mouse coordinates.
      // This is used for moving things around.
      var deltas = from pair in movingEvents.Buffer(2)
                   let array = pair.ToArray()
                   let a = array[0].EventArgs.Location
                   let b = array[1].EventArgs.Location
                   select new Size(b.X - a.X, b.Y - a.Y);

      // construct an observable that represents mouse down events on an existing object
      var selectEvents = from e in downEvents
                         let obj = FindPoint(e.EventArgs.Location)
                         where obj != null
                         select obj;

      // construct an observable representing mouse down events on empty space.
      var drawingEvents = from e in downEvents
                          let obj = FindPoint(e.EventArgs.Location)
                          where obj == null
                          select e;

      // Observe the selectEvents observable to set the selected object 
      selectEvents.Subscribe(obj => this.SelectedObject = obj);

      // Observe the drawingEvents so we can draw new lines.
      drawingEvents.Subscribe(e =>
      {
        var line = new Line();
        line.A.X = e.EventArgs.Location.X;
        line.A.Y = e.EventArgs.Location.Y;
        line.B.X = e.EventArgs.Location.X;
        line.B.Y = e.EventArgs.Location.Y;
        this.lines.Add(line);
        this.SelectedObject = line.B;
      });

      // Observe on the mouse up events to set the currently dragging object to null.
      upEvents.Subscribe(e => this.SelectedObject = null);

      // Construct an observable that only looks at pairs of movements 
      // that occur between a mouse down and a mouse press.
      var dragDeltas = deltas.SkipUntil(downEvents).TakeUntil(upEvents).Repeat();

      // Observe the dragging deltas so we can move objects around.
      dragDeltas.Where(e => this.SelectedObject != null).Subscribe(e =>
      {
        this.SelectedObject.X += e.Width;
        this.SelectedObject.Y += e.Height;
        this.Invalidate();
      });

      // Add in some object highlighting
      var overObject = from e in movingEvents
                       let point = FindPoint(e.EventArgs.Location)
                       select point;
      overObject.Subscribe(point => this.HotObject = point);
    }

    /// <summary>
    /// Finds the point instance that is near the given graphics location.
    /// </summary>
    /// <param name="pos">The screen position to test</param>
    /// <returns>The Position instance that is near the point or null if we couldn't find one.</returns>
    private Position FindPoint(Point pos)
    {
      foreach (var l in lines)
      {
        if (Near(l.A, pos))
        {
          return l.A;
        }
        if (Near(l.B, pos))
        {
          return l.B;
        }
      }
      return null;
    }

    /// <summary>
    /// Tests to see if the given position is close to the given x and y coordinates
    /// </summary>
    /// <param name="position">The line point to test</param>
    /// <param name="pos">The screen point to test</param>
    /// <returns>True if the line point and the screen position are near each other.</returns>
    private bool Near(Position position, Point pos)
    {
      return (Math.Abs(pos.X - position.X) < 5 && Math.Abs(pos.Y - position.Y) < 5);
    }

    /// <summary>
    /// Converts a generic EventHandler into a specific MouseEventHandler. 
    /// This was needed to make the c# code verifiable as this is not allowed to occur in a lambda.
    /// </summary>
    /// <param name="handler">The generic EventHandler to convert</param>
    /// <returns>The non-generic MouseEventHandler instance.</returns>
    private MouseEventHandler ConvertHandler(EventHandler<MouseEventArgs> handler)
    {
      return new MouseEventHandler(handler);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      var g = e.Graphics;

      g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;

      g.FillRectangle(Brushes.White, this.ClientRectangle);

      g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

      // Here we draw all our lines.
      foreach (var l in this.lines)
      {
        g.DrawLine(Pens.Black, l.A.X, l.A.Y, l.B.X, l.B.Y);
      }

      if (this.SelectedObject != null)
      {
        g.FillEllipse(Brushes.Red, Rectangle.FromLTRB(this.selectedObject.X - 4, this.selectedObject.Y - 4, this.selectedObject.X + 4, this.selectedObject.Y + 4));
      }
      else if (this.HotObject != null)
      {
        g.FillEllipse(Brushes.DarkGreen, Rectangle.FromLTRB(this.HotObject.X - 4, this.HotObject.Y - 4, this.HotObject.X + 4, this.HotObject.Y + 4));
      }
    }
  }
}
