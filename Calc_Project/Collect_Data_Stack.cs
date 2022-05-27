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

        public void AddToStack(long DataFromCalc)
        {
            myStack.Push(DataFromCalc);
            
            PrintValuesFromStack(myStack);
        }




        public void TakeDataFromStack(ref long stack)
        {
            stack = (long)myStack.Peek();
            myStack.Pop();
            PrintValuesFromStack(myStack);
        }

        public void TakeDataFromReverseStack(ref long stack)
        {
            while (myStack.Count != 0)
            {
                revStack.Push(myStack.Pop());
            }
            stack = (long)revStack.Peek();
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


