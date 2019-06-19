using System;

namespace Cards
{
	class Program
	{
		static void Main(string[] args)
		{			
			BronzeCard bronze = new BronzeCard(0, 150);
			SilverCard silver = new SilverCard(600, 850);
			Gold gold = new Gold(1500, 1300);
			PayDesk.OutputData(bronze);
			PayDesk.OutputData(silver);
			PayDesk.OutputData(gold);
		}
	}
}