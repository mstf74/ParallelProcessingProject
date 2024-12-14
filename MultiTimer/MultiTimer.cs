using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;
using System.Reflection;


namespace MultiTimer
{
    public class Multitimer
    {
        private int EndTime { get; set; }
        private int _counter { get; set; }
        // property to foramte the remain time to HH:MM:SS.
        public string FormattedCounter
        {
            get
            {
                TimeSpan time = TimeSpan.FromSeconds(_counter);
                return time.ToString(@"hh\:mm\:ss");
            }
        }
        // Property to calculate the progress.
        public int ProgressPercentage
        {
            get
            {
                if (EndTime == 0)
                    return 0;
                var val = (int)((double)(EndTime - _counter) / EndTime * 100);
                if (val >= 100)
                    val = 100;
                return val;
            }
        }
        public string Name { get; private set; }
        public string Status { get; private set; } = "Ready to start";
        private Object locker;
        private CancellationTokenSource StopSource { get; set; }
        private CancellationTokenSource PauseSource { get; set; }

        public Multitimer(int Hours, int Minutes, int Seconds, string _name = null)
        {
            EndTime = (Hours * 60 * 60) + (Minutes * 60) + Seconds;
            StopSource = new CancellationTokenSource();
            PauseSource = new CancellationTokenSource();
            locker = new Object();
            _counter = EndTime;
            this.Name = _name;
        }
        // the start function that is assigned to the thread to run.
        // using the monitor to ensure that only one thread runs the start methode
        // and terminate other threads attemping to run it if they didn't join within a second.
        public async Task<bool> Start()
        {
            if (Monitor.TryEnter(locker, 1000))
            {
                try
                {
                    Status = "Running";
                    while (_counter >= 0)
                    {
                        Task.Delay(1000, StopSource.Token).Wait();
                        while (PauseSource.IsCancellationRequested)
                        {
                            Task.Delay(100).Wait();
                        }

                        _counter--;
                    }
                    Status = "Finished";
                    return true;
                }
                catch
                {
                    return false;
                }
                finally
                {
                    Monitor.Exit(locker);
                }
            }
            return false;
        }
        // reset function to reset the finishing time and regenerate the cancellationToken.
        public void Reset()
        {
            Status = "Ready to start";
            _counter = EndTime;
            StopSource.Cancel();
            StopSource = new CancellationTokenSource();
            if (PauseSource.IsCancellationRequested)
                PauseSource = new CancellationTokenSource();
        }
        // function to pause the timer by calling the pause cancellationToken.
        public void Pause()
        {
            if (_counter != EndTime)
            {
                PauseSource.Cancel();
                Status = "Paused";
            }
        }
        // function to resume the timer by regenerating the pause token; 
        public void Resume()
        {
            PauseSource = new CancellationTokenSource();
            Status = "Running";
        }
    }
}