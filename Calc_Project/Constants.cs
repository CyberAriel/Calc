using System;
namespace Calc_Project
{
	public class Constants
	{
		double OutData = 0;
		public Constants()
		{
		}
		public void PushE()
        {
			double e = 2.71828182845904523536028747135266249775724709369995;
			Collect_Data_Stack.Instance.AddToStack(e);
			Console.WriteLine($"OutData {e}");
		}
		public void PushPi()
        {
			double pi = 3.14159265359;
			Collect_Data_Stack.Instance.AddToStack(pi);
			Console.WriteLine($"OutData {pi}");
		}
		public void GenerateARandomNumber()
        {
			Random rnd = new Random();
			double random = rnd.Next();
			Collect_Data_Stack.Instance.AddToStack(random);
			Console.WriteLine($"OutData {random}");
		}

	}
}