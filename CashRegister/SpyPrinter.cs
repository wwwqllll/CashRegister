using System.Dynamic;

namespace CashRegister
{
	public class SpyPrinter : Printer
	{
        public SpyPrinter()
        {
            this.HasPrinted = false;
        }

        public bool HasPrinted { get; set; }

        public override void Print(string content)
		{
            // send message to a real printer
            base.Print(content);
            this.HasPrinted = true;
        }
	}
}
