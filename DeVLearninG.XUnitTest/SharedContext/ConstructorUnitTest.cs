using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Threading;
using System.Xml.Linq;
using Xunit;

namespace DeVLearninG.MyReservation.Test
{
    public class ConstructorUnitTest
    {
        ConstructorHeavyCalculator _heavyCalculator;

        public ConstructorUnitTest()
        {
            _heavyCalculator = new ConstructorHeavyCalculator();
        }

        [Fact]
        public void TestSum_CorrectResult()
        {
            _heavyCalculator.Test = "ConstructorUnitTest - TestSum_CorrectResult";

            int val = _heavyCalculator.Sum(2, 3);

            Assert.Equal(5, val);
        }

        [Fact]
        public void TestSub_CorrectResult()
        {
            _heavyCalculator.Test = "ConstructorUnitTest - TestSub_CorrectResult";

            int val = _heavyCalculator.Sub(2, 3);

            Assert.Equal(-1, val);
        }
    }

    public class ConstructorHeavyCalculator : IDisposable
    {
        public string Test { get; set; }

        public ConstructorHeavyCalculator()
        {
            Thread.Sleep(2000);
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public void Dispose()
        {
            //clean up code
        }
    }
}
