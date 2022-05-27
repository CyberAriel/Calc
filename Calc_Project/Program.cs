using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Project
{
    class Program
    {
        static async Task Main(string[] args)
        { 
            CancellationTokenSource cancellationToken = new CancellationTokenSource();
            User_Space user_Space = new User_Space();
            Arithmetic_Operators arithmetic_Operators = new Arithmetic_Operators();
            Bitwise_Operators bitwise_Operators = new Bitwise_Operators();
            Numeric_Utilities numeric_Utilities = new Numeric_Utilities();
            Constants constants = new Constants();
            var task = user_Space.ConsoleInputAsync(cancellationToken);


            user_Space.ExecuteWhenCommandAppears("+", () => arithmetic_Operators.Add());
            user_Space.ExecuteWhenCommandAppears("-", () => arithmetic_Operators.Subtract());
            user_Space.ExecuteWhenCommandAppears("*", () => arithmetic_Operators.Multiply());
            user_Space.ExecuteWhenCommandAppears("/", () => arithmetic_Operators.Divide());
            user_Space.ExecuteWhenCommandAppears("clr", () => arithmetic_Operators.ClearTheStack());
            user_Space.ExecuteWhenCommandAppears("!", () => arithmetic_Operators.BooleanNOT());
            user_Space.ExecuteWhenCommandAppears("!=", () => arithmetic_Operators.NotEqualTo());
            user_Space.ExecuteWhenCommandAppears("%", () => arithmetic_Operators.Modulus());
            user_Space.ExecuteWhenCommandAppears("++", () => arithmetic_Operators.Increment());
            user_Space.ExecuteWhenCommandAppears("--", () => arithmetic_Operators.Decrement());

            // user_Space.ExecuteWhenCommandAppears("exit", () =>
            //  {
            //       cancellationToken.Cancel();

            //  });
            await task;
            Console.WriteLine("End of application");
        }
    }
}