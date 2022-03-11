using System;
using System.Threading;
namespace Test2
{
    public delegate void ClockHandler(object sender, ClockEventArgs args);

    public class ClockEventArgs : EventArgs
    {
        public int hour { get; set; }
        public int min { get; set; }
        public int sec { get; set; }

        public ClockEventArgs()
        {
            hour = min = sec = 0;
        }

        public ClockEventArgs(int h, int m, int s)
        {
            hour = h;
            min = m;
            sec = s;
        }
    }
    public class Clock
    {
        public event ClockHandler Tick;
        public event ClockHandler Alarm;

        public int hour { get; set; } = 0;
        public int min { get; set; } = 0;
        public int sec { get; set; } = 0;
        private int alarmHour = 0;
        private int alarmMin = 0;
        private int alarmSec = 0;
        private bool flag = true;
        
        public void Start()
        {
            // Console.WriteLine($"The clock starts at {h}:{m}:{s}.");
            while (flag)
            {
                sec = (sec + 1) % 60;
                if (sec == 0)
                {
                    min = (min + 1) % 60;
                }

                if (min == 0 && sec == 0)
                {
                    hour = (hour + 1) % 24;
                }

                Tick(this, null);

                if (alarmHour == hour && alarmMin == min && alarmSec == sec)
                {
                    Alarm(this, null);
                    Stop();
                }
                
                Thread.Sleep(1000);
            }
        }

        public void Stop()
        {
            flag = false;
        }

        public void SetTime(int h, int m, int s)
        { 
            hour = h;
            min = m;
            sec = s;
        }
        
        public void SetAlarm(int h, int m, int s)
        {
            alarmHour = h;
            alarmMin = m;
            alarmSec = s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            clock.SetTime(0,0,10);
            clock.SetAlarm(0,0,20);
            clock.Tick += (sender, clockEventArgs) =>
                Console.WriteLine($"The clock ticks at {clock.hour}:{clock.min}:{clock.sec}.");
            clock.Alarm += (sender, eventArgs) =>
                Console.WriteLine($"The clock alarms at {clock.hour}:{clock.min}:{clock.sec}.");
            
            clock.Start();
        }
    }
}