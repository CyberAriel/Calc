using System;
using System.Collections;

namespace Calc_Project
{
	public class Arithmetic_Operators
	{
        long OutData = 0;
		public Arithmetic_Operators()
		{
            
		}
		public void Add()
        {

            long[] arr = new long[10];
             Stack stack = new Stack();
       Collect_Data_Stack.Instance.TakeDataFromStack(ref arr);
            
            foreach (long l in arr)
            {
                OutData += l;
            }

            Console.WriteLine($"OutData {OutData}");
            



            Collect_Data_Stack.Instance.AddToStack(OutData);

        }


        public void Subtract()
        {

        }
		public void Multiply()
        {

        }
		public void Divide()
        {

        }
		public void ClearTheStack()
        {

        }
		public void BooleanNOT()
        {

        }
        public void NotEqualTo()
        {

        }
        public void Modulus()
        {

        }
        public void Increment()
        {

        }
        public void Decrement()
        {

        }

    }
}

