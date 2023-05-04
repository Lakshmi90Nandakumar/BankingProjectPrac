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
        //reading single data from excel
        public string FetchSingleDataExcel(string sheetName,int row,int col)
        {
            string projdata = "C:\\Users\\LENOVO\\source\\repos\\BankingProjectPrac\\BankingProjectPrac\\PractiseProjectActitime\\Resources\\demodata.xlsx";
            sheet = new Spreadsheet();
            sheet.LoadFromFile(projdata);//loading the excel
            //getting single data from excel sheet
            string data=sheet.Workbook.Worksheets.ByName(sheetName).Cell(row, col).ToString();
            return data;//returning the data
        }
    }
}
