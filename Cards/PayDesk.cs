using System;
using System.Collections.Generic;
using System.Text;

namespace Cards
{

	public class PayDesk 
	{
		public static void OutputData(CardBase card)
		{
			Console.WriteLine("Purchase value: ${0:F2}", card.PurchaseValue);
			Console.WriteLine("Discount rate: {0:F1}%" , card.DiscountRate * 100);
			Console.WriteLine("Discount: ${0:F2}" , card.CalculateDiscount());
			Console.WriteLine("Total: ${0:F2}", card.PurchaseValue - card.CalculateDiscount());
		}
	}
}
