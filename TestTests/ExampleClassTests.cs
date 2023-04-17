using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tests
{
    [TestClass()]
    public class ExampleClassTests
    {
        [TestMethod()]
        public void MethodTest()
        {
            int[,] array = new int[,]
            {
                { 1, 2 },
                { 1, 2 }
            };
            int value = 3;

            int[,] expected = new int[,]
            {
                { 0, 3 },
                { 0, 3 }
            };

            int[,] actual = ExampleClass.Method(array, value);

            for (int i = 0; i < actual.GetLength(0); i++)
            {
                for (int j = 0; j < actual.GetLength(1); j++)
                {
                    Assert.AreEqual(expected[i,j], actual[i,j]);
                }

            }
        }

        [TestMethod()]
        public void MethodTest2()
        {
            int value = 3;

            Assert.ThrowsException<NullReferenceException>(() => ExampleClass.Method(null, value));
        }

        [TestMethod()]
        public void MethodTest3()
        {
            int[,] array = new int[,]
            {
                { 1, 2 },
                { 1, 2 }
            };
            int value = 2;

            int[,] expected = new int[,]
            {
                { 0, 0 },
                { 0, 0 }
            };

            int[,] actual = ExampleClass.Method(array, value);

            for (int i = 0; i < actual.GetLength(0); i++)
            {
                for (int j = 0; j < actual.GetLength(1); j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j]);
                }

            }
        }
    }
}