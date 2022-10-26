using System.Dynamic;

namespace CashRegister
{
	public class SpyPrinter : IPrinter
	{
        public SpyPrinter()
        {
            this.HasPrinted = false;
        }

        public bool HasPrinted { get; set; }

        public void Print(string content)
		{
            // send message to a real printer
            this.HasPrinted = true;
        }
	}
}
