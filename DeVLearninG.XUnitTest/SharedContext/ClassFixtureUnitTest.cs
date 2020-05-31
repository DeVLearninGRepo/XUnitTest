using System;
using System.Threading;
using Xunit;

namespace DeVLearninG.MyReservation.Test
{
    public class ClassFixtureTest1 : IClassFixture<ClassHeavyCalculatorFixture>
    {
        ClassHeavyCalculatorFixture _heavyCalculatorFixture;

        public ClassFixtureTest1(ClassHeavyCalculatorFixture heavyCalculatorFixture)
        {
            _heavyCalculatorFixture = heavyCalculatorFixture;
        }

        [Fact]
        public void TestSum_CorrectResult()
        {
            _heavyCalculatorFixture.Test = "ClassFixtureTest1 - TestSum_CorrectResult";

            int val = _heavyCalculatorFixture.Sum(2, 3);

            Assert.Equal(5, val);
        }

        [Fact]
        public void TestSub_CorrectResult()
        {
            _heavyCalculatorFixture.Test = "ClassFixtureTest1 - TestSub_CorrectResult";

            int val = _heavyCalculatorFixture.Sub(2, 3);

            Assert.Equal(-1, val);
        }
    }


    public class ClassFixtureTest2 : IClassFixture<ClassHeavyCalculatorFixture>
    {
        ClassHeavyCalculatorFixture _heavyCalculatorFixture;

        public ClassFixtureTest2(ClassHeavyCalculatorFixture heavyCalculatorFixture)
        {
            _heavyCalculatorFixture = heavyCalculatorFixture;
        }

        [Fact]
        public void TestSum_CorrectResult()
        {
            _heavyCalculatorFixture.Test = "ClassFixtureTest2 - TestSum_CorrectResult";

            int val = _heavyCalculatorFixture.Sum(2, 3);

            Assert.Equal(5, val);
        }

        [Fact]
        public void TestSub_CorrectResult()
        {
            _heavyCalculatorFixture.Test = "ClassFixtureTest2 - TestSub_CorrectResult";

            int val = _heavyCalculatorFixture.Sub(2, 3);

            Assert.Equal(-1, val);
        }
    }

    public class ClassHeavyCalculatorFixture : IDisposable
    {
        public string Test { get; set; }

        public ClassHeavyCalculatorFixture()
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
