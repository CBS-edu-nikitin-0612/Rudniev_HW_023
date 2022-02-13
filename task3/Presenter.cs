using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace task3
{
    class Presenter
    {
        Model model;
        MainWindow view;
        Timer timer;
        DateTime timeCreateTimer;
        DateTime timeNow;
        TimeSpan interval;
        public Presenter(MainWindow view)
        {
            this.model = new Model();
            this.view = view;
            this.view.timerStartEvent += new EventHandler(timerStart_Handler);

            timer = new Timer();
            timer.Interval = 10;
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;

        }

        public void timerStart_Handler(object sender, EventArgs e)
        {
            timeCreateTimer = DateTime.Now;
            timer.Enabled = true;
            
        }
        public void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            timeNow = DateTime.Now;
            interval = timeNow - timeCreateTimer;
            view.infoAboutTimer.Text = "Timer: " + interval.Seconds.ToString();
            
        }
    }
}
