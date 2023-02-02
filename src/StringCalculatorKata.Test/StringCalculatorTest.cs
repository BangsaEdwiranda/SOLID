using NUnit.Framework;
using StringCalculatorKata;

namespace StringCalculatorKata.Test
{
    public class StringCalculatorTest
    {

        [Test]
        [TestCase("abc")]
        [TestCase("def")]
        public void Add_EmptyStringAsParam_ReturnsZero(string name)
        {
            Assert.AreEqual(0, StringCalculator.Add(""));
            Assert.AreEqual(0, (new StringCalculator()).Sub());
            Assert.AreEqual(name, name);
        }


    }
}
