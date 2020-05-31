using System;
using System.Threading;
using Xunit;

namespace DeVLearninG.MyReservation.Test
{
    [CollectionDefinition("CalculatorCollection")]
    public class HeavyCalculatorCollection : ICollectionFixture<CollectionHeavyCalculatorFixture>
    {

    }

    [Collection("CalculatorCollection")]
    public class CollectionFixtureUnitTest1
    {
        CollectionHeavyCalculatorFixture _heavyCalculatorFixture;

        public CollectionFixtureUnitTest1(CollectionHeavyCalculatorFixture heavyCalculatorFixture)
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


    [Collection("CalculatorCollection")]
    public class CollectionFixtureUnitTest2
    {
        CollectionHeavyCalculatorFixture _heavyCalculatorFixture;

        public CollectionFixtureUnitTest2(CollectionHeavyCalculatorFixture heavyCalculatorFixture)
        {
            _heavyCalculatorFixture = heavyCalculatorFixture;
        }

        [Fact]
        public void TestSum_CorrectResult()
        {
            _heavyCalculatorFixture.Test = "CollectionFixtureUnitTest2 - TestSum_CorrectResult";

            int val = _heavyCalculatorFixture.Sum(2, 3);

            Assert.Equal(5, val);
        }

        [Fact]
        public void TestSub_CorrectResult()
        {
            _heavyCalculatorFixture.Test = "CollectionFixtureUnitTest2 - TestSub_CorrectResult";

            int val = _heavyCalculatorFixture.Sub(2, 3);

            Assert.Equal(-1, val);
        }
    }

    public class CollectionHeavyCalculatorFixture : IDisposable
    {
        public string Test { get; set; }

        public CollectionHeavyCalculatorFixture()
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
