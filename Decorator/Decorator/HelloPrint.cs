namespace Decorator
{
    interface IHelloPrint
    {
        string PrintHello();
    }

    class HelloPrint : IHelloPrint
    {
        public string PrintHello()
        {
            return "Hello World!";
        }
    }

    class HelloPrintParenthesesDecorator : IHelloPrint
    {
        private IHelloPrint HelloPrinter;

        public HelloPrintParenthesesDecorator(IHelloPrint hp)
        {
            this.HelloPrinter = hp;
        }

        public string PrintHello()
        {
            return $"({this.HelloPrinter.PrintHello()})";
        }
    }

    class HelloPrintBracketDecorator : IHelloPrint
    {
        private IHelloPrint HelloPrinter;

        public HelloPrintBracketDecorator(IHelloPrint hp)
        {
            this.HelloPrinter = hp;
        }

        public string PrintHello()
        {
            return $"[{this.HelloPrinter.PrintHello()}]";
        }
    }
}
