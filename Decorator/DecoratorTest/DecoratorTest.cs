using DecoratorKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecoratorTest
{
    [TestClass]
    public class HelloPrintTest
    {
        [TestMethod]
        public void HelloPrintTest_TestHelloPrint()
        {
            IHelloPrint ph = new HelloPrint();

            Assert.IsTrue(ph.PrintHello() == "Hello World!");
        }

        [TestMethod]
        public void HelloPrintTest_PrintOneSetOfParentheses()
        {
            IHelloPrint ph = new HelloPrint();
            ph = new HelloPrintParenthesesDecorator(ph);

            Assert.IsTrue(ph.PrintHello() == "(Hello World!)");
        }

        [TestMethod]
        public void HelloPrintTest_PrintOneSetOfBrackets()
        {
            IHelloPrint ph = new HelloPrint();
            ph = new HelloPrintBracketDecorator(ph);

            Assert.IsTrue(ph.PrintHello() == "[Hello World!]");
        }

        [TestMethod]
        public void HelloPrintTest_PrintTwoSetsOfBrackets()
        {
            IHelloPrint ph = new HelloPrint();
            ph = new HelloPrintBracketDecorator(ph);
            ph = new HelloPrintBracketDecorator(ph);

            Assert.IsTrue(ph.PrintHello() == "[[Hello World!]]");
        }

        [TestMethod]
        public void HelloPrintTest_PrintTwoSetsOfParentheses()
        {
            IHelloPrint ph = new HelloPrint();
            ph = new HelloPrintParenthesesDecorator(ph);
            ph = new HelloPrintParenthesesDecorator(ph);

            Assert.IsTrue(ph.PrintHello() == "((Hello World!))");
        }

        [TestMethod]
        public void HelloPrintTest_PrintBracketAndParentheses()
        {
            IHelloPrint ph = new HelloPrint();
            ph = new HelloPrintParenthesesDecorator(ph);
            ph = new HelloPrintBracketDecorator(ph);

            Assert.IsTrue(ph.PrintHello() == "[(Hello World!)]");
        }
    }
}
