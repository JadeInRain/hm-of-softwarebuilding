﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ClockEvent
{

    //声明委托类型定义事件处理函数格式
    public delegate void TickHandler(object sender, TickEventArgs args);
    public class TickEventArgs
    {
        public DateTime CurrentTime { get; }
        public TickEventArgs(DateTime time)
        {
            CurrentTime = time;
        }
    }

    public delegate void AlarmHandler(object sender, AlarmEventArgs args);
    public class AlarmEventArgs
    {
        public DateTime AlarmTime { get; }
        public AlarmEventArgs(DateTime time)
        {
            AlarmTime = time;
        }
    }

    public class AlarmClock
    {
        //闹钟响铃时间
        private DateTime alarmTime;
        public event TickHandler OnTick;
        public event AlarmHandler OnAlarm;
        public void Run()
        {
            alarmTime = System.DateTime.Now.AddSeconds(10);
            Console.WriteLine($"The alarm clock will go off in ten seconds({alarmTime.ToString("HH:mm:ss")}).");
            DateTime tmpTime;

            while (DateTime.Compare(alarmTime, tmpTime = System.DateTime.Now) > 0)
            {
                TickEventArgs args = new TickEventArgs(tmpTime);
                OnTick(this, args);
                Thread.Sleep(1000);
            }
            AlarmEventArgs args1 = new AlarmEventArgs(tmpTime);
            OnAlarm(this, args1);
            return;
        }
    }

    public class Form
    {
        public AlarmClock alarmClock = new AlarmClock();

        public Form()
        {
            //给OnTick事件添加处理方法
            alarmClock.OnTick += new TickHandler(Clock_OnTick);
            //给OnAlarm事件添加处理方法
            alarmClock.OnAlarm += new AlarmHandler(Clock_OnAlarm);
        }

        void Clock_OnTick(object sender, TickEventArgs args)
        {
            Console.WriteLine($"Tick! Now time is {args.CurrentTime.ToString("HH:mm:ss")}");
        }

        void Clock_OnAlarm(object sender, AlarmEventArgs args)
        {
            Console.WriteLine($"Ring! Time's up! Now time is {args.AlarmTime.ToString("HH:mm:ss")}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Form form1 = new Form();
            form1.alarmClock.Run();
        }
    }
}