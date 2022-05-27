using System;
namespace Calc_Project
{
	public class Bitwise_Operators
	{


		double OutData = 0;
		double number = 0;
		double val = 0;
		uint _outData = 0;
		uint _numberData = 0;
		public Bitwise_Operators()
		{
		}
		public void BitwiseAND()
		{
			


			int j = Collect_Data_Stack.Instance.myStack.Count;
			Collect_Data_Stack.Instance.TakeDataFromReverseStack(ref number);
			OutData = number;
			; for (int i = 1; i < j; i++)
			{
				Collect_Data_Stack.Instance.TakeDataFromReverseStack(ref number);
				_outData = Convert.ToUInt32(OutData);
				_numberData = Convert.ToUInt32(number);

				_outData &= _numberData;

			}
			OutData=Convert.ToDouble(_outData);
			Console.WriteLine($"OutData {OutData}");
			Collect_Data_Stack.Instance.AddToStack(OutData);
			OutData = 0;
		}
		public void BitwiseOR()
        {
			



			int j = Collect_Data_Stack.Instance.myStack.Count;
			Collect_Data_Stack.Instance.TakeDataFromReverseStack(ref number);
			OutData = number;
			; for (int i = 1; i < j; i++)
			{
				Collect_Data_Stack.Instance.TakeDataFromReverseStack(ref number);
				_outData = Convert.ToUInt32(OutData);
				_numberData = Convert.ToUInt32(number);

				_outData |= _numberData;

			}
			OutData = Convert.ToDouble(_outData);
			Console.WriteLine($"OutData {OutData}");
			Collect_Data_Stack.Instance.AddToStack(OutData);
			OutData = 0;
		}

	
		public void BitwiseXOR()
        {
			int j = Collect_Data_Stack.Instance.myStack.Count;
			Collect_Data_Stack.Instance.TakeDataFromReverseStack(ref number);
			OutData = number;
			; for (int i = 1; i < j; i++)
			{
				Collect_Data_Stack.Instance.TakeDataFromReverseStack(ref number);
				_outData = Convert.ToUInt32(OutData);
				_numberData = Convert.ToUInt32(number);

				_outData ^= _numberData;

			}
			OutData = Convert.ToDouble(_outData);
			Console.WriteLine($"OutData {OutData}");
			Collect_Data_Stack.Instance.AddToStack(OutData);
			OutData = 0;
		}
		public void BitwiseNOT()
		{
			int j = Collect_Data_Stack.Instance.myStack.Count;
			Collect_Data_Stack.Instance.TakeDataFromReverseStack(ref number);
			OutData = number;
			
				_numberData = Convert.ToUInt32(number);

				_outData = ~ _numberData;


			OutData = Convert.ToDouble(_outData);
			Console.WriteLine($"OutData {OutData}");
			Collect_Data_Stack.Instance.AddToStack(OutData);
			OutData = 0;
		}
		public void BitwiseShiftLeft()
        {
			Collect_Data_Stack.Instance.TakeDataFromReverseStack(ref val);
			Collect_Data_Stack.Instance.TakeDataFromReverseStack(ref number);
			int _number = Convert.ToInt32(number);
			int _val = Convert.ToInt32(val);
			int  x = _number << _val;
			OutData = Convert.ToDouble(x);
			Console.WriteLine($"OutData {OutData}");
			Collect_Data_Stack.Instance.AddToStack(OutData);


		}
		public void BitwiseShiftRight()
        {
			Collect_Data_Stack.Instance.TakeDataFromReverseStack(ref val);
			Collect_Data_Stack.Instance.TakeDataFromReverseStack(ref number);
			int _number = Convert.ToInt32(number);
			int _val = Convert.ToInt32(val);
			int x = _number >> _val;
			OutData = Convert.ToDouble(x);
			Console.WriteLine($"OutData {OutData}");
			Collect_Data_Stack.Instance.AddToStack(OutData);

		}

	}
}

