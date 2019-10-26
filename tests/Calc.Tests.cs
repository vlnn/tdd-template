using NUnit.Framework;
using calc;

namespace tests {
    public class Tests {
    private Calc calc = new Calc();

        [SetUp]
        public void Setup() {
        }

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
    }
}
