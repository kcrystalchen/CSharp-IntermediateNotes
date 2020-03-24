using System;

namespace DesignAStopWatch
{
    // methods: Start(call first) and Stop(call second) 
    // ask stopwatch about the duration between start and stop <= value in TimeSpan 
    // start and stop multiple times to add on to Duration 
    // display the Duration 
    // should not start a stopwatch twice in a row, it will overwrite the initial start time, and throw an InvalidOperationException

    public class StopWatch
    {

        public DateTime _startTime;
        public DateTime _endTime;

        private bool _running;

        public void Start()
        {
            if(_running == true)
            {
                throw new InvalidOperationException("Stopwatch is already running!");
            }
            else
            {
                _running = true;
                _startTime = DateTime.Now;
            }
        }

        public void Stop()
        {
            if(_running == false)
            {
                throw new InvalidOperationException("Stopwatch is Not running!");
            }
            else
            {
                _running = true;
                _endTime = DateTime.Now;
            }

        }

        public TimeSpan GetInterval()
        {
           TimeSpan duration = _startTime - _endTime;

            return duration;
        }
    }
}
