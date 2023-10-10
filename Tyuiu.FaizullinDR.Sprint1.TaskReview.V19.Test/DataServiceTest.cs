using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FaizullinDR.Sprint1.TaskReview.V19.Lib;

namespace Tyuiu.FaizullinDR.Sprint1.TaskReview.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 3;
            double res = ds.Calculate(x);
            double wait = 162.808;
            Assert.AreEqual(wait, res);
        }
    }
}
