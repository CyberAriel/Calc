using System;
using System.Collections;

namespace Calc_Project
{
    public class Arithmetic_Operators
    {
        double OutData = 0;
        double number = 0;
        bool flaga = true;
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
                
                OutData /= number;
               
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
            int j = Collect_Data_Stack.Instance.myStack.Count;
            Collect_Data_Stack.Instance.TakeDataFromReverseStack(ref number);
            double tmp = number;
            ; for (int i = 1; i < j; i++)
            {
                Collect_Data_Stack.Instance.TakeDataFromReverseStack(ref number);

                if(tmp != number)
                {
                    OutData = 1;
                }
                else
                {
                    OutData = 0;
                }

            }
            Console.WriteLine($"OutData {OutData}");
            Collect_Data_Stack.Instance.AddToStack(OutData);
            OutData = 0;
        }
        public void Modulus()
        {
            int j = Collect_Data_Stack.Instance.myStack.Count;
            Collect_Data_Stack.Instance.TakeDataFromReverseStack(ref number);
            OutData = number;
            ; for (int i = 1; i < j; i++)
            {
                Collect_Data_Stack.Instance.TakeDataFromReverseStack(ref number);

                OutData %= number;

            }
            Console.WriteLine($"OutData {OutData}");
            Collect_Data_Stack.Instance.AddToStack(OutData);
            OutData = 0;
        }
        public void Increment()
        {
            /*
            Collect_Data_Stack.Instance.TakeDataFromStack(ref number);
            number++;
            OutData = number;
            Collect_Data_Stack.Instance.AddToStack(OutData);
            Console.WriteLine($"OutData {OutData}");
            */
        }
        public void Decrement()
        {
           
        }

    }
}

