using System;

namespace CashRegister
{
	public class CashRegister
	{
		private readonly SpyPrinter printer;

		public CashRegister(SpyPrinter printer)
		{
			this.printer = printer;
		}

		public void Process(Purchase purchase)
		{
			try
			{
				printer.Print(purchase.AsString());
			}
			catch (PrinterOutOfPaperException e)
			{
				Console.WriteLine(e.Message);
				throw new HardwareException("Printer is out of paper.");
			}
		}
	}
}
