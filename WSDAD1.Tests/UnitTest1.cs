using NUnit.Framework;
using WSDAD1;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        public void Test1(int a, int b)
        {
            Program monProg = new Program();
            int result = a + b;
            Assert.AreEqual(result, monProg.somme(a, b));
        }
    }
}