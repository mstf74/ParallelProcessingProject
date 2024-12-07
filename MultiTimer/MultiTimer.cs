using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;


namespace MultiTimer
{
    public class Multitimer
    {
        private int EndTime { get; }
        public int Counter { get; private set; }
        public int Delay { get; private set; } = 0;
        public string Status { get; private set; } = "Ready to start";
        private Object locker;
        private CancellationTokenSource StopSource { get; set; }
        private CancellationTokenSource PauseSource { get; set; }

        public Multitimer(int Hours, int Minutes, int Seconds)
        {
            EndTime = (Hours * 60 * 60) + (Minutes * 60) + Seconds;
            StopSource = new CancellationTokenSource();
            PauseSource = new CancellationTokenSource();
            locker = new Object();
            Counter = EndTime;
        }
        public async Task<bool> Start()
        {
            //lock (locker)
            //{
                try
                {
                    while (Counter != 0)
                    {
                    await Task.Delay(Timeout.Infinite, PauseSource.Token).ContinueWith(_ => { }, TaskContinuationOptions.OnlyOnCanceled);

                    await Task.Delay(1000, StopSource.Token);
                        Console.WriteLine($"counter: {Counter}");
                        Counter--;
                    }
                    Status = "Finished";
                    return true;
                }
                catch
                {
                    Status = "Stopped";
                    return false;
                }
            //}
        }
        public void Reset()
        {
            Status = "Ready to run";
            StopSource.Cancel();
            Counter = EndTime;
            StopSource = new CancellationTokenSource();
        }
        public void Pause()
        {
          PauseSource.Cancel();
            Status = "Paused";
        }

        public void Resume()
        {
            PauseSource = new CancellationTokenSource();
            Status = "Running";
        }
    }
}