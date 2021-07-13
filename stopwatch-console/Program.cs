using System;

namespace stopwatch_console
{
    class Program
           {
        static void Main(string[] args)
        {

            var clock = new Stopwatch();



            while (true)
            {
                clock.StartInfo();
                var firstEntry = Console.ReadLine().ToLower();
                    if (firstEntry == "start")
                    {
                        clock.Start();
                            while (true)
                            {
                                clock.EndInfo();
                                var secondEntry = Console.ReadLine().ToLower();

                                if (secondEntry == "end")
                                {
                                    clock.End();
                                    clock.Calculate();
                                    break;
                                }
                           
                            }

                    }
                clock.Exit();
                if (Console.ReadKey().Key == ConsoleKey.K)
                {
                    break;
                }
                   
            }



            


            



        }
    }
}
