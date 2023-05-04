using Bytescout.Spreadsheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankingProjectPrac.Practise
{
    [TestClass]
    public class ExcelDataDriven
    {
        
        [TestMethod]
        [TestCategory("Excel Data fetch")]
        public void TestMethod1()
        {
            Spreadsheet sheet = new Spreadsheet();
            sheet.LoadFromFile("C:/Users/LENOVO/Downloads/details.xlsx");
            string data = sheet.Workbook.Worksheets.ByName("Sheet1").Cell(0, 0).ToString();
            Console.WriteLine(data);    

        }
        [TestMethod]
        [TestCategory("multiple data")]
        public void TestMethod2() 
        {
            Spreadsheet sheet = new Spreadsheet();
            sheet.LoadFromFile("C:/Users/LENOVO/Downloads/details.xlsx");
            Worksheet sh=sheet.Workbook.Worksheets.ByName("Sheet1");
            int rowNum=sh.UsedRangeRowMax;
            int colNum=sh.UsedRangeColumnMax;
            for(int i=0; i<=rowNum; i++) 
            {
              for(int j=0; j<=colNum; j++) 
              {
                string data=sh.Cell(i, j).ToString();
                Console.Write(data+"   ");
              }
              Console.WriteLine();
            }
        }
    }
}
