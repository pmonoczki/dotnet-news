using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DrawingApplication
{
  public class Position
  {
    public int X { get; set; }
    public int Y { get; set; }
  }
  public class Line
  {
    public Line()
    {
      this.A = new Position();
      this.B = new Position();
    }
    public Position A { get; private set; }
    public Position B { get; private set; }
  }
}
