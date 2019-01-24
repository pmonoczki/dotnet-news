//-----------------------------------------------------------------------

// <copyright file="Program.cs" component="CORE">

//     Represents the new CORE functionalities.

// </copyright>

//----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using System.IO;


namespace Core
{
    /// <summary>
    /// Starter app to introduce the core news
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point
        /// </summary>
        static void Main()
        {

            #region .Net 3.0 COM

            object missing;
            Microsoft.Office.Interop.Excel.Application excel;
            Workbook wb;
            Worksheet ws;
            Microsoft.Office.Interop.Excel.Range range;
            double sumValues;
            Microsoft.Office.Interop.Word.Application word;
            object visible;
            object filename;
            Document doc;
            Microsoft.Office.Interop.Word.Paragraph p1;
            object headingStyle;
            Microsoft.Office.Interop.Word.Paragraph p2;
            object saveChanges;

            //DoCOMIntroduction_3(out missing, out excel, out wb, out ws, out range, out sumValues, out word, out visible, out filename, out doc, out p1, out headingStyle, out p2, out saveChanges);

            #endregion

            #region .Net 4.0 COM
            P p = new P();
            p.GetP(b: "l", a:"u");
           // DoCOMIntroduction_4();

            #endregion

            //DynamicDemo.DoDynamucIntro();
            //DynamicDemo.DoDuckTypingIntro();
            //DynamicDemo.DoReflectionCompare();

            //CovarianceAndContravariance.DoCovarianceAndContravariance();

            Console.ReadKey();

        }

        /// <summary>
        /// COM from 4.0
        /// </summary>
        /// <param name="missing"></param>
        /// <param name="excel"></param>
        /// <param name="wb"></param>
        /// <param name="ws"></param>
        /// <param name="range"></param>
        /// <param name="sumValues"></param>
        /// <param name="word"></param>
        /// <param name="visible"></param>
        /// <param name="filename"></param>
        /// <param name="doc"></param>
        /// <param name="p1"></param>
        /// <param name="headingStyle"></param>
        /// <param name="p2"></param>
        /// <param name="saveChanges"></param>
        private static void DoCOMIntroduction_4()
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Workbook wb;
            Worksheet ws;
            Microsoft.Office.Interop.Excel.Range range;
            double sumValues;
            Microsoft.Office.Interop.Word.Application word;
            object visible;
            object filename;
            Document doc;
            Microsoft.Office.Interop.Word.Paragraph p1;
            object headingStyle;
            Microsoft.Office.Interop.Word.Paragraph p2;
            object saveChanges;


            excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;

            wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            ws = wb.Worksheets[1];

            range = ws.get_Range("A1", "A10");
            range.Formula = "=RANDBETWEEN(1, 10)";

            excel.Cells[11, 1].Value = "=SUM(A1:A10)";

            // Com indexing
            sumValues = (double)ws.Cells[11, 1].Value;

            

            visible = true;

            filename = System.IO.Path.Combine(Environment.GetFolderPath(
Environment.SpecialFolder.Desktop), @"interop_.docx");

            if (!File.Exists(filename.ToString())) File.Create(filename.ToString());

            word = new Microsoft.Office.Interop.Word.Application();
            word.Visible = true;
            // optional parameters and not reference required
            doc = word.Documents.Open(filename, Visible: true);


            p1 = doc.Paragraphs.Add();
            headingStyle = "Cím";
            //p1.Range.set_Style(re
            p1.Range.Text = "Az excel által számított érték:";
            p1.Range.InsertParagraphAfter();


            p2 = doc.Paragraphs.Add(Type.Missing);
            p2.Range.Text = sumValues.ToString();
            p2.Range.InsertParagraphAfter();

            doc.SaveAs(ref filename);

            saveChanges = true;
            word.Quit(ref saveChanges);
            excel.Quit();
        }

        /// <summary>
        /// COM from 3.0
        /// </summary>
        /// <param name="missing"></param>
        /// <param name="excel"></param>
        /// <param name="wb"></param>
        /// <param name="ws"></param>
        /// <param name="range"></param>
        /// <param name="sumValues"></param>
        /// <param name="word"></param>
        /// <param name="visible"></param>
        /// <param name="filename"></param>
        /// <param name="doc"></param>
        /// <param name="p1"></param>
        /// <param name="headingStyle"></param>
        /// <param name="p2"></param>
        /// <param name="saveChanges"></param>
        private static void DoCOMIntroduction_3(out object missing, out Microsoft.Office.Interop.Excel.Application excel, out Workbook wb, out Worksheet ws, out Microsoft.Office.Interop.Excel.Range range, out double sumValues, out Microsoft.Office.Interop.Word.Application word, out object visible, out object filename, out Document doc, out Microsoft.Office.Interop.Word.Paragraph p1, out object headingStyle, out Microsoft.Office.Interop.Word.Paragraph p2, out object saveChanges)
        {
            // nincs lehetéség kikerülni
            missing = Type.Missing;

            excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;

            wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            ws = (Worksheet)wb.Worksheets[1];

            range = ws.get_Range("A1", "A10");
            range.Formula = "=RANDBETWEEN(1, 10)";

            ((Microsoft.Office.Interop.Excel.Range)excel.Cells[11, 1]).Value = "=SUM(A1:A10)";

            sumValues = (double)((Microsoft.Office.Interop.Excel.Range)ws.Cells[11, 1]).Value;

            word = new Microsoft.Office.Interop.Word.Application();
            word.Visible = true;

            visible = true;

            filename = System.IO.Path.Combine(Environment.GetFolderPath(
Environment.SpecialFolder.Desktop), @"interop.docx");

            if (!File.Exists(filename.ToString())) File.Create(filename.ToString());

            doc = word.Documents.Open(ref filename, ref missing, ref missing,
            ref missing, ref missing, ref missing, ref missing, ref missing,
            ref missing, ref missing, ref missing, ref visible, ref missing,
            ref missing, ref missing, ref missing);


            p1 = doc.Paragraphs.Add(ref missing);
            headingStyle = "Cím";
            //p1.Range.set_Style(ref headingStyle);
            p1.Range.Text = "Az excel által számított érték:";
            p1.Range.InsertParagraphAfter();


            p2 = doc.Paragraphs.Add(ref missing);
            p2.Range.Text = sumValues.ToString();
            p2.Range.InsertParagraphAfter();

            doc.SaveAs(ref filename, ref missing, ref missing, ref missing,
ref missing, ref missing, ref missing, ref missing,
ref missing, ref missing, ref missing, ref missing,
ref missing, ref missing, ref missing, ref missing);

            saveChanges = true;
            word.Quit(ref saveChanges, ref missing, ref missing);
            excel.Quit();
        }
    }

    class P
    {
        public string GetP(string a="g", string b = "g" ){ return "";}
    }
}
