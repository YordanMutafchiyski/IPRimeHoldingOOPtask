using System;
using System.Collections.Generic;
using System.Text;

namespace Cards
{
	public class BronzeCard : CardBase
	{
		public BronzeCard(decimal turnoverPreviousMonth, decimal purchaseValue) : base(turnoverPreviousMonth, purchaseValue)
		{
			if (TurnOverPreviousMonth < 100)
			{
				DiscountRate = 0;
			}
			else if (TurnOverPreviousMonth <= 300 && TurnOverPreviousMonth >= 100)
			{
				DiscountRate = 0.01M;
			}
			else
			{
				DiscountRate = 0.025M;
			}
		}
	}
}
