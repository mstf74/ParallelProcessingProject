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
        public string FormattedCounter
        {
            get
            {
                TimeSpan time = TimeSpan.FromSeconds(_counter);
                return time.ToString(@"hh\:mm\:ss");
            }
        }
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
        public async Task<bool> Start()
        {

            lock (locker)
            {
                try
                {
                    while (_counter >= 0)
                    {
                        Task.Delay(1000, StopSource.Token).Wait();
                        while (PauseSource.IsCancellationRequested)
                        {
                            Task.Delay(100).Wait();
                        }
                        Status = "Running";

                        _counter--;
                    }
                    Status = "Finished";
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public void Reset()
        {
            Status = "Ready to start";
            _counter = EndTime;
            StopSource.Cancel();
            StopSource = new CancellationTokenSource();
            if (PauseSource.IsCancellationRequested)
                PauseSource = new CancellationTokenSource();
        }
        public void Pause()
        {
            if (_counter != EndTime)
            {
                PauseSource.Cancel();
                Status = "Paused";
            }
        }

        public void Resume()
        {
            PauseSource = new CancellationTokenSource();
            Status = "Running";
        }
    }
}