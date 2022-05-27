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
            long number = 0;

            int j = Collect_Data_Stack.Instance.myStack.Count;

            for (int i = 0; i < j; i++)
            {
                Collect_Data_Stack.Instance.TakeDataFromStack(ref number);
                OutData += number;

            }
            Console.WriteLine($"OutData {OutData}");
            Collect_Data_Stack.Instance.AddToStack(OutData);
            OutData = 0;
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
            Collect_Data_Stack.Instance.ClearTheStock();
            Console.WriteLine("Clear the stack");
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

