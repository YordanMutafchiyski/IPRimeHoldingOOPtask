using System;
namespace Cards
{

	public class CardBase
	{
		private decimal turnoverPreviousMonth;
		private decimal purchaseValue;
		private decimal discountRate;

		public CardBase() { }
		public CardBase(decimal turnoverPreviousMonth, decimal purchaseValue)
		{
			this.turnoverPreviousMonth = turnoverPreviousMonth;
			this.purchaseValue = purchaseValue;


		}

		public decimal PurchaseValue
		{
			get { return this.purchaseValue; }
			set { this.purchaseValue = value; }
		}
		public decimal TurnOverPreviousMonth
		{
			get { return this.turnoverPreviousMonth; }
			set { this.turnoverPreviousMonth = value; }
		}

		public decimal DiscountRate
		{
			get { return this.discountRate; }
			set { this.discountRate = value; }
		}



		public decimal CalculateDiscount()
		{
			return this.purchaseValue * this.discountRate;
		}

		
	}
}

