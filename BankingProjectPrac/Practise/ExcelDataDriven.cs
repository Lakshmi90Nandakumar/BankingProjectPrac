using Bytescout.Spreadsheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankingProjectPrac.Practise
{
    [TestClass]
    public class ExcelDataDriven//class 
    {
        Spreadsheet sheet;//declaring sheet as global variable
        [TestMethod]
        [TestCategory("Excel Data fetch")]
        public void TestMethod1()//test method used to read single data from excel
        {
            
            string data = sheet.Workbook.Worksheets.ByName("Sheet1").Cell(0, 0).ToString();//get the data
            Console.WriteLine(data); //print the data on the console   

        }
        [TestMethod]
        [TestCategory("multiple data")]
        public void TestMethod2() //test methoad used to get multiple data from  excel
        {
            ;
            Worksheet sh=sheet.Workbook.Worksheets.ByName("Sheet1")//getting sheet
            int rowNum=sh.UsedRangeRowMax;//getting last row number
            int colNum=sh.UsedRangeColumnMax;//getting last column number
            for(int i=0; i<=rowNum; i++) //to iterate through every row in excel
            {
              for(int j=0; j<=colNum; j++) //to iterate through every cloumn in excel
                {
                string data=sh.Cell(i, j).ToString();//getting data in the particular cell
                Console.Write(data+"   ");//printing the data
              }
              Console.WriteLine();
            }
        }
        [TestInitialize]
        public void TestInit()
        {
            sheet = new Spreadsheet();//vreating instance to spreadsheet
            sheet.LoadFromFile("C:/Users/LENOVO/Downloads/details.xlsx");//loading the file
        }
        [TestCleanup] 
        public void TestCleanup() 
        {
          sheet.Dispose();//removing control from excel file
        }
    }
}
