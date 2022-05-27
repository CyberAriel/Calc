using System;
using System.Collections;
namespace Calc_Project
{
    public class Collect_Data_Stack
    {
        public static Collect_Data_Stack Instance = new Collect_Data_Stack();
        public Stack myStack = new Stack();
        public Stack revStack = new Stack();

        public Collect_Data_Stack()
        {
        }

        public void AddToStack(double DataFromCalc)
        {
            if (DataFromCalc!=02)
            myStack.Push(DataFromCalc);
            
            PrintValuesFromStack(myStack);
        }

        public void TakeDataFromStack(ref double stack)
        {
            stack = (double)myStack.Peek();
            myStack.Pop();
            PrintValuesFromStack(myStack);
        }

        public void TakeDataFromReverseStack(ref double stack)
        {
            while (myStack.Count != 0)
            {
                revStack.Push(myStack.Pop());
            }
            stack = (double)revStack.Peek();
            revStack.Pop();
            PrintValuesFromStack(myStack);

        }

        public void ClearTheStock()
        {
            myStack.Clear();
            PrintValuesFromStack(myStack);

        }
        public void PrintValuesFromStack(IEnumerable myCollection)
        {
            Console.Write("Stack includes");
            foreach (Object obj in myCollection)
            {
                Console.Write("    {0}", obj);
            }
            Console.WriteLine();
        }

    }
}


