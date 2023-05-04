using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace BankingProjectPrac.Practise
{
    [TestClass]
    public class DynamicDataDriven//data driven testing using dymanic data 
    {
        public static IEnumerable<object[]> Data//defining dynamic data property
        {
            get
            {
                return new[]
                {
                    new object[] {1,1,2},
                    new object[] {1,2,3},
                    new object[] {1,3,4},
                    new object[] {1,4,5},
                    new object[] {1,5,6},

                };
            }
        }
        public static IEnumerable<object[]> DynMethod()//defining dymanic data method
        {
            yield return new object[] { 1, 1, 2 };
            yield return new object[] { 1, 2, 4 };
            yield return new object[] { 2, 3, 5 };
            yield return new object[] { 4, 5, 9 };
        }

        [TestMethod]
        [TestCategory("TestUsingProperty")]
        [DynamicData(nameof(Data),DynamicDataSourceType.Property)]
        public void TestMethod1(int a,int b,int c)//implementing data driven testing using property
        {
            int add = a + b;
            bool res = false;
            if(add == c) 
            {
                res = true;
            }
            Assert.IsTrue(res,"Result is matching");
        }
        [TestMethod]
        [TestCategory("TestUsingMethod")]
        [DynamicData(nameof(DynMethod),DynamicDataSourceType.Method)]
        public void UsingDynamicMethod(int a,int b,int c)//implementing data driven testing using dymanic method
        {
            int add = a + b;
            bool result = false;
            if(add==c)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
    }
}
