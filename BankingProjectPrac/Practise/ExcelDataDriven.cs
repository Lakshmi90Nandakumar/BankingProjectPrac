using Bytescout.Spreadsheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankingProjectPrac.Practise
{
    [TestClass]
    public class ExcelDataDriven
    {
        Spreadsheet sheet;
        [TestMethod]
        [TestCategory("Excel Data fetch")]
        public void TestMethod1()
        {
            
            string data = sheet.Workbook.Worksheets.ByName("Sheet1").Cell(0, 0).ToString();
            Console.WriteLine(data);    

        }
        [TestMethod]
        [TestCategory("multiple data")]
        public void TestMethod2() 
        {
            ;
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
        [TestInitialize]
        public void TestInit()
        {
            sheet = new Spreadsheet();
            sheet.LoadFromFile("C:/Users/LENOVO/Downloads/details.xlsx");
        }
        [TestCleanup] 
        public void TestCleanup() 
        {
          sheet.Dispose();
        }
    }
}
