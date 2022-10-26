using System.Dynamic;

namespace CashRegister
{
	public class Printer
	{
        public Printer()
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
