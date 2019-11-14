using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestyKoniec;

namespace TestYKoniecTest
{
    public class StringTest
    {
        StringPrzewijanie sc = new StringPrzewijanie();
        public void Setup()
        {
        }
        [TestCase(4, "Hello", "o")]
        [TestCase(6, "Hello", "e")]
        [TestCase(0, "Hello", "H")]
        [TestCase(7, null, "")]
        [TestCase(9, "", "")]
        public void CharNumTest(int num, string input, string expected)
        {
            var resoult = sc.CharNum(num, input);
            Assert.AreEqual(expected, resoult);
        }
    }
}
