using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BogdanovaSA.Sprint6.Task0.V15.Lib;

namespace Tyuiu.BogdanovaSA.Sprint6.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            public void ValidCalculate()
            {
                DataService ds = new DataService();

                int x = 3;
                var res = ds.Calculate(x);
                double wait = 64.0;

                Assert.AreEqual(wait, res);
            }
        }
    }
}
