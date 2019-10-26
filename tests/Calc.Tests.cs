using calc;
using NUnit.Framework;

namespace tests {
    public class Tests {
        private Calc calc = new Calc();

        [SetUp]
        public void Setup() {}

        [Test]
        public void AddReturnsZeroForEmpty() {
            var zero = calc.Add("");
            Assert.Zero(zero);
        }

        [Test]
        public void AddReturnsZeroForZero() {
            var zero = calc.Add("0");
            Assert.Zero(zero);
        }

        [Test]
        public void AddReturns121For121() {
            var onetwoone = calc.Add("121");
            Assert.AreEqual(onetwoone, 121);
        }

        [Test]
        public void Add2And2() {
            var result = calc.Add("2,2");
            Assert.AreEqual(result, 4);
        }

        [Test]
        public void Add2And2And3() {
            var result = calc.Add("2,2,3");
            Assert.AreEqual(result, 7);
        }

        [Test]
        public void Add2And2AndNegative3() {
            var result = calc.Add("2,2,-3");
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void NegativeResult() {
            var result = calc.Add("2,-3");
            Assert.AreEqual(result, -1);
        }
    }
}
