using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Project
{
    internal class Trigonometric_Functions
    {
        double number = 0;
        public void Cosine()
        {
            Collect_Data_Stack.Instance.TakeDataFromStack(ref number);
            double cosAngle = Math.Cos(number);
            Console.WriteLine($"OutData {cosAngle}");
            Collect_Data_Stack.Instance.AddToStack(cosAngle);
            number = 0;

        }
        public void Sine()
        {

            Collect_Data_Stack.Instance.TakeDataFromStack(ref number);
            double sinAngle = Math.Sin(number);
            Console.WriteLine($"OutData {sinAngle}");
            Collect_Data_Stack.Instance.AddToStack(sinAngle);
            number = 0;

        }
    }
}
