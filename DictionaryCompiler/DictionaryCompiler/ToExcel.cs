using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace DictionaryCompiler
{
    public class ToExcel
    {
        public static void ExportToExcel(string path, string fileName)
        {
            using (ExcelPackage excel = new ExcelPackage())
            {
                excel.Workbook.Worksheets.Add("Worksheet1");

                FileInfo excelFile = new FileInfo(path + fileName + ".xlsx");
                excel.SaveAs(excelFile);
            }
        }
    }
}
