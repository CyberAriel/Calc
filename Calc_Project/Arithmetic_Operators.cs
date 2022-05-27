using System;
using System.Collections;

namespace Calc_Project
{
    public class Arithmetic_Operators
    {
        long OutData = 0;
        long number = 0;
        public Arithmetic_Operators()
        {

        }
        public void Add()
        {

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
            int j = Collect_Data_Stack.Instance.myStack.Count;
            for (int i = 0; i < j; i++)
            {
                Collect_Data_Stack.Instance.TakeDataFromStack(ref number);
                OutData -= number;
            }
            Console.WriteLine($"OutData {OutData}");
            Collect_Data_Stack.Instance.AddToStack(OutData);
            OutData = 0;
        }
        public void Multiply()
        {
            int j = Collect_Data_Stack.Instance.myStack.Count;
            Collect_Data_Stack.Instance.TakeDataFromStack(ref number);
            OutData = number;
;            for (int i = 1; i < j; i++)
            {
                Collect_Data_Stack.Instance.TakeDataFromStack(ref number);
                OutData *= number;
            }
            Console.WriteLine($"OutData {OutData}");
            Collect_Data_Stack.Instance.AddToStack(OutData);
            OutData = 0;
        }
        public void Divide()
        {
            
            int j = Collect_Data_Stack.Instance.myStack.Count;
            Collect_Data_Stack.Instance.TakeDataFromReverseStack(ref number);
            OutData = number;
            ; for (int i = 1; i < j; i++)
            {
                Collect_Data_Stack.Instance.TakeDataFromReverseStack(ref number);
                Console.WriteLine($"Number {number}");
                OutData /= number;
                Console.WriteLine($"Output in for {OutData}");
            }
            Console.WriteLine($"OutData {OutData}");
            Collect_Data_Stack.Instance.AddToStack(OutData);
            OutData = 0;
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
            int j = Collect_Data_Stack.Instance.myStack.Count;
            for (int i = 0; i < j; i++)
            {
                Collect_Data_Stack.Instance.TakeDataFromStack(ref number);
                OutData %= number;
            }
            Console.WriteLine($"OutData {OutData}");
            Collect_Data_Stack.Instance.AddToStack(OutData);
            OutData = 0;
        }
        public void Increment()
        {
            int j = Collect_Data_Stack.Instance.myStack.Count;
            for (int i = 0; i < j; i++)
            {
                Collect_Data_Stack.Instance.TakeDataFromStack(ref number);
                OutData = number++;
            }
            Console.WriteLine($"OutData {OutData}");
            Collect_Data_Stack.Instance.AddToStack(OutData);
            OutData = 0;
        }
        public void Decrement()
        {
            int j = Collect_Data_Stack.Instance.myStack.Count;
            for (int i = 0; i < j; i++)
            {
                Collect_Data_Stack.Instance.TakeDataFromStack(ref number);
                OutData = number--;
            }
            Console.WriteLine($"OutData {OutData}");
            Collect_Data_Stack.Instance.AddToStack(OutData);
            OutData = 0;
        }

    }
}

