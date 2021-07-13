using System;

namespace stopwatch_console 
{
    public class Stopwatch : InfoWriter
    {
        private DateTime _startOfClock;
        private DateTime _endtOfClock;


        public void Start()
        {
            this._startOfClock = DateTime.Now;
          
           
        }

        public void End()
        {
            this._endtOfClock = DateTime.Now;
           

        }

        public  void Calculate()
        {
            var result = _endtOfClock - _startOfClock;
            Console.WriteLine($"{result.Hours}H {result.Minutes}min {result.Seconds}sec");
        }
    }


}
