using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using System.IO;


namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {

            #region .Net 3.0

            // nincs lehetéség kikerülni
            object missing = Type.Missing;
            
            var excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            
            Workbook wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet ws = (Worksheet)wb.Worksheets[1];

            Microsoft.Office.Interop.Excel.Range range = ws.get_Range("A1", "A10");
            range.Formula = "=RANDBETWEEN(1, 10)";

            ((Microsoft.Office.Interop.Excel.Range)excel.Cells[11, 1]).Value = "=SUM(A1:A10)";

            double sumValues = (double)((Microsoft.Office.Interop.Excel.Range)ws.Cells[11, 1]).Value;

            var word = new Microsoft.Office.Interop.Word.Application();
            word.Visible = true;

            object visible = true;

            object filename = System.IO.Path.Combine(Environment.GetFolderPath(
Environment.SpecialFolder.Desktop), @"interop.docx");

            if (!File.Exists(filename.ToString())) File.Create(filename.ToString());

            Document doc = word.Documents.Open(ref filename, ref missing, ref missing,
            ref missing, ref missing, ref missing, ref missing, ref missing,
            ref missing, ref missing, ref missing, ref visible, ref missing,
            ref missing, ref missing, ref missing);


            Microsoft.Office.Interop.Word.Paragraph p1 = doc.Paragraphs.Add(ref missing);
            object headingStyle = "Cím";
            p1.Range.set_Style(ref headingStyle);
            p1.Range.Text = "Az excel által számított érték:";
            p1.Range.InsertParagraphAfter();


            Microsoft.Office.Interop.Word.Paragraph p2 = doc.Paragraphs.Add(ref missing);
            p2.Range.Text = sumValues.ToString();
            p2.Range.InsertParagraphAfter();

            doc.SaveAs(ref filename, ref missing, ref missing, ref missing,
ref missing, ref missing, ref missing, ref missing,
ref missing, ref missing, ref missing, ref missing,
ref missing, ref missing, ref missing, ref missing);

            object saveChanges = true;
            word.Quit(ref saveChanges, ref missing, ref missing);
            excel.Quit();

            #endregion

            #region .Net 4.0

            excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;

            wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            ws = wb.Worksheets[1];

            range = ws.get_Range("A1", "A10");
            range.Formula = "=RANDBETWEEN(1, 10)";

            excel.Cells[11, 1].Value = "=SUM(A1:A10)";

            sumValues = (double)ws.Cells[11, 1].Value;

            word = new Microsoft.Office.Interop.Word.Application();
            word.Visible = true;

            visible = true;

            filename = System.IO.Path.Combine(Environment.GetFolderPath(
Environment.SpecialFolder.Desktop), @"interop.docx");

            if (!File.Exists(filename.ToString())) File.Create(filename.ToString());

            doc = word.Documents.Open(filename, Visible:true);


            p1 = doc.Paragraphs.Add();
            headingStyle = "Cím";
            p1.Range.set_Style(ref headingStyle);
            p1.Range.Text = "Az excel által számított érték:";
            p1.Range.InsertParagraphAfter();


            p2 = doc.Paragraphs.Add(ref missing);
            p2.Range.Text = sumValues.ToString();
            p2.Range.InsertParagraphAfter();

            doc.SaveAs(ref filename);

            saveChanges = true;
            word.Quit(ref saveChanges);
            excel.Quit();

            #endregion
        }
    }
}
