using System;

namespace stopwatch_console
{
    public class InfoWriter
    {
        public void StartInfo()
        {
            Console.WriteLine("Please Enter start if you want to start clock counter \n ");
        }
        public void EndInfo()
        {
            Console.WriteLine("Please Enter End if you want to End clock counter \n ");
        }
        public void Exit()
        {
            Console.WriteLine("Please enter start to start clock again or press 'k' to quit program \n");
        }
    }
}
