using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MelehovAG.Sprint6.Task3.V1.Lib;

namespace Tyuiu.MelehovAG.Sprint6.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] array = { { 25, 20, 28, 2, 6 },
                             { 19, 9,  18, -7, 24},
                             { 21, 16, 5, -7, -8},
                             { 30, -13, 1, -15, 2 },
                             { 31, 9, -3, -9, -18 } };
            int[,] valueWaitArray = { { 2, 6, 20, 25, 28 },
                             { 19, 9,  18, -7, 24},
                             { 21, 16, 5, -7, -8},
                             { 30, -13, 1, -15, 2 },
                             { 31, 9, -3, -9, -18 } };
            var res = ds.Calculate(array);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
