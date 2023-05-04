using Bytescout.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProjectPrac.PractiseProjectActitime.Generic
{
    public class ExcelUtility
    {
        Spreadsheet sheet;
        public string FetchSingleDataExcel(string sheetName,int row,int col)
        {
            sheet = new Spreadsheet();
            sheet.LoadFromFile("C:/Users/LENOVO/Downloads/demodata.xlsx");
            string data=sheet.Workbook.Worksheets.ByName(sheetName).Cell(row, col).ToString();
            return data;
        }
    }
}
