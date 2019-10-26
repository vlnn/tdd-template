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
    }
}
