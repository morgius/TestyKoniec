using NUnit.Framework;
using TestyKoniec;

namespace Tests
{
    public class Tests
    {
        SumaCyfr sc = new SumaCyfr();
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("12345",15)]
        [TestCase("999",27)]
        [TestCase("XC123",0)]
        public void SumaTest(string input, int expected)
        {
            var resoult = sc.Suma(input);
            Assert.AreEqual(expected, resoult);
        }
    }
}