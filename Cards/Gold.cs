using System;
using System.Collections.Generic;
using System.Text;

namespace Cards
{
	class Gold : CardBase
	{

		public Gold() : base() { }
		public Gold(decimal TurnOverPreviousMonth, decimal purchaseValue) : base(TurnOverPreviousMonth, purchaseValue)
		{
			int numberOfHundreds = (int)(Math.Truncate(TurnOverPreviousMonth));
			DiscountRate = 0.02M;
			for (int i = 0; i < numberOfHundreds; i++)
			{
				DiscountRate += 0.01M;
				if (DiscountRate == 0.1M)
				{
					break;
				}
			}
		}
	}
}
