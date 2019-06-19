using System;
using System.Collections.Generic;
using System.Text;

namespace Cards
{
	public class SilverCard : CardBase
	{
		public SilverCard(decimal TurnOverPreviousMonth, decimal purchaseValue) : base(TurnOverPreviousMonth, purchaseValue)
		{
			if (TurnOverPreviousMonth > 300)
			{
				DiscountRate = 0.035M;
			}
			else
			{
				DiscountRate = 0.02M;
			}
		}
	}

}
