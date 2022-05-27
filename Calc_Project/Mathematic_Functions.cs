using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Project
{
    internal class Mathematic_Functions
    {
        double OutData = 0;
        double number;
        public void Exp()
        {
            Collect_Data_Stack.Instance.TakeDataFromStack(ref number);
            double exp = Math.Exp(number);
            Console.WriteLine($"OutData {exp}");
            Collect_Data_Stack.Instance.AddToStack(exp);
            OutData = 0 ;
        }

        double factorial(double n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        public void Fact()
        {
            Console.WriteLine("test");
           Collect_Data_Stack.Instance.TakeDataFromStack(ref number);
          OutData = factorial(number);
           Console.WriteLine($"OutData {OutData}");
          Collect_Data_Stack.Instance.AddToStack(OutData);
           OutData = 0;
        }

        public void Sqrt()
        {
            Collect_Data_Stack.Instance.TakeDataFromStack(ref number);
            double sqrt = Math.Sqrt(number);
            Console.WriteLine($"OutData {sqrt}");
            Collect_Data_Stack.Instance.AddToStack(sqrt);
            OutData = 0;
        }

        public void Ln()
        {
            Collect_Data_Stack.Instance.TakeDataFromStack(ref number);
        }
        public void Log ()
        {

            Collect_Data_Stack.Instance.TakeDataFromStack(ref number);
            double log = Math.Log(number);
            Console.WriteLine($"OutData {log}");
            Collect_Data_Stack.Instance.AddToStack(log);
            OutData = 0;
        }
        public void Pow()
        {
            double value = 0, power = 0;


            Collect_Data_Stack.Instance.TakeDataFromReverseStack(ref power);
            Collect_Data_Stack.Instance.TakeDataFromReverseStack(ref value);
            OutData = (double)Math.Pow(value, power);
            Console.WriteLine($"OutData {OutData}");
            Collect_Data_Stack.Instance.AddToStack(OutData);
            OutData = 0;


        }
    }


}
    