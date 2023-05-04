using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankingProjectPrac.Practise
{
    [TestClass]
    public class SampleTest
    {
        
            [DataTestMethod]
            [DataRow("lakshmi", "bangalore")]
            [DataRow("chitra", "Madurai")]
            [TestMethod]
            [TestCategory("sample")]
            [Priority(1)]
            public void TestMethod(string name, string place)
            {
                Console.WriteLine("Data 1: " + name + "  Data 2 : " + place);
            }
        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("welcome");
        }
            [TestInitialize]
            public void TestInitialize()
            {
                Console.WriteLine("Test Started");
            }
            [TestCleanup]
            public void Cleanup()
            {
                Console.WriteLine("Test method ended");
            }
        }
        
    }

