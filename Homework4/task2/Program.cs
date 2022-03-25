using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
        public delegate void TickHandler(object sender, TickEventArgs args);

        public class TickEventArgs
        {
            public DateTime Time { get; set; }
        }

        public delegate void AlarmHandler(object sender, AlarmEventArgs args);

        public class AlarmEventArgs
        {
            public DateTime Time { get; set; }
        }

        public class Clock
        {
            /// <summary>
            /// 当前时间
            /// </summary>
            public DateTime Time { get; set; }
            /// <summary>
            /// 响铃时间
            /// </summary>
            public DateTime AlarmTime { get; set; }
            /// <summary>
            /// 响铃开关
            /// </summary>
            public bool AlarmStatus { get; set; }

            /// <summary>
            /// 滴答事件
            /// </summary>
            public event TickHandler OnTick;
            /// <summary>
            /// 响铃事件
            /// </summary>
            public event AlarmHandler OnAlarm;

            private bool ClockStatus;
            private readonly TimeSpan eps = TimeSpan.FromSeconds(0.5);

            public Clock()
            {
                Time = DateTime.MinValue;
                AlarmTime = DateTime.MinValue;
                ClockStatus = false;
                AlarmStatus = false;
                OnTick = ((c, a) => { });
                OnAlarm = ((c, a) => { });
            }

            /// <summary>
            /// 异步开始
            /// </summary>
            /// <returns></returns>
            /// <exception cref="InvalidOperationException"></exception>
            public async Task StartAsync()
            {
                if (ClockStatus)
                    throw new InvalidOperationException("Clock already started.");
                ClockStatus = true;
                while (ClockStatus)
                {
                    Time = Time.AddSeconds(1);
                    var args = new TickEventArgs()
                    {
                        Time = Time,
                    };

                    OnTick(this, args);

                    if (AlarmStatus && (Time - AlarmTime).Duration() <= eps)
                        Alarm();

                    await Task.Delay(TimeSpan.FromSeconds(1));
                }
            }

            /// <summary>
            /// 同步非阻塞开始
            /// </summary>
            public void Start()
            {
                Task.Run(StartAsync);
            }

            /// <summary>
            /// 结束
            /// </summary>
            /// <exception cref="InvalidOperationException"></exception>
            public void Stop()
            {
                if (!ClockStatus)
                    throw new InvalidOperationException("Clock already stopped.");
                ClockStatus = false;
            }

            /// <summary>
            /// 响铃操作
            /// </summary>
            private void Alarm()
            {
                AlarmStatus = false;

                var args = new AlarmEventArgs()
                {
                    Time = Time,
                };

                OnAlarm(this, args);
            }

        static void Main(string[] args)
        {
            Clock clock = new Clock();

            void onTick(object sender, TickEventArgs args) // 订阅滴答事件
            {
                Console.WriteLine($"Tick {args.Time}");
            }

            void onAlarm(object sender, AlarmEventArgs args) // 订阅响铃事件
            {
                Console.WriteLine($"!! Alarm {args.Time}");
            }

            clock.OnTick += onTick;
            clock.OnAlarm += onAlarm;

            // 打开时钟
            Console.WriteLine($"Set current time and start the clock at {DateTime.Now}");
            clock.Time = DateTime.Now;
            clock.Start();
            Thread.Sleep(5000);

            // 关闭时钟
            Console.WriteLine($"Stop the clock at {DateTime.Now}");
            clock.Stop();

            Thread.Sleep(2000);

            // 打开时钟
            Console.WriteLine($"Set current time and start the clock at {DateTime.Now}");
            clock.Time = DateTime.Now;
            clock.Start();

            Thread.Sleep(1500);

            // 设定响铃
            Console.WriteLine($"Turn on the alarm and set the alarm time at {DateTime.Now + TimeSpan.FromSeconds(5)}");
            clock.AlarmTime = DateTime.Now + TimeSpan.FromSeconds(5);
            clock.AlarmStatus = true;

            Console.ReadKey();
        }
    }
}
