using System;
using System.Collections;
namespace Calc_Project
{
	public class Collect_Data_Stack
	{
        public static Collect_Data_Stack Instance = new Collect_Data_Stack();
        public Stack myStack = new Stack();
        
        public Collect_Data_Stack()
		{
		}

        public void AddToStack(long DataFromCalc)
        {
            myStack.Push(DataFromCalc);

            PrintValuesFromStack(myStack);
        }
        public void TakeDataFromStack(ref long[] stack)
        {
            int stackLenght = myStack.Count;
            long[] vs = new long[stackLenght];



            int i = 0;
            Console.Write("Zawartość stosu: ");
            foreach (long sto in myStack)
            {
                vs[i] = sto;
                Console.Write(sto + " ");
            }
            vs = stack;

        }

        internal void AddToStack(string v)
        {
            throw new NotImplementedException();
        }

        public void PrintValuesFromStack(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }
    }
}


