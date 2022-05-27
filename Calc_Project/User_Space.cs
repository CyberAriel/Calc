using System;
namespace Calc_Project
{
	public class User_Space
	{
        List<string> data = new List<string>();
        private delegate void ReceivedLine(string line);
        private event ReceivedLine OnReceivedLine;

        public User_Space()
		{
		}

        public void ExecuteWhenCommandAppears(string command, Action callback)
        {
            void Menu_OnReceivedLine(string line)
            {
                if (line.Contains(command, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"Method called{command}");
                    string tmp = line.Replace(command, "").Trim();
                    string[] subs = tmp.Split(' ');
                    foreach (string s in subs)
                    {
                        long.TryParse(s, out long number);
                        Collect_Data_Stack.Instance.AddToStack(number);
                    }
                    
                    //OnReceivedLine -= Menu_OnReceivedLine;
                    callback?.Invoke();
                }
            }
            OnReceivedLine += Menu_OnReceivedLine;
        }

        public Task ConsoleInputAsync(CancellationTokenSource cancellationToken)
        {

            return Task.Run(() =>
            {
                while (!cancellationToken.IsCancellationRequested)
                {

                    string line = Console.ReadLine();
                    OnReceivedLine?.Invoke(line);
                }
            });
        }
    }
}

