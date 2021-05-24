namespace DecoratorKata
{
    public interface IHelloPrint
    {
        string PrintHello();
    }

    public class HelloPrint : IHelloPrint
    {
        public string PrintHello()
        {
            return "Hello World!";
        }
    }

    public class HelloPrintParenthesesDecorator : IHelloPrint
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

    public class HelloPrintBracketDecorator : IHelloPrint
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
