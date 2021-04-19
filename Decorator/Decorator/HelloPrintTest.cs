using NUnit.Framework;

namespace Decorator
{
    [TestFixture]
    class HelloPrintTest
    {
        [Test]
        public void HelloPrintTest_TestHelloPrint()
        {
            IHelloPrint ph = new HelloPrint();

            Assert.IsTrue(ph.PrintHello() == "Hello World!");
        }

        [Test]
        public void HelloPrintTest_PrintOneSetOfParentheses()
        {
            IHelloPrint ph = new HelloPrint();
            ph = new HelloPrintParenthesesDecorator(ph);

            Assert.IsTrue(ph.PrintHello() == "(Hello World!)");
        }

        [Test]
        public void HelloPrintTest_PrintOneSetOfBrackets()
        {
            IHelloPrint ph = new HelloPrint();
            ph = new HelloPrintBracketDecorator(ph);

            Assert.IsTrue(ph.PrintHello() == "[Hello World!]");
        }
    }
}
