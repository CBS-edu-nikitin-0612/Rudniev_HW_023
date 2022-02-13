using System;
using System.Windows;

// View

namespace MVP
{    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }
        EventHandler myEvent = null;

        public event EventHandler MyEvent
        {
            add { myEvent += value; }
            remove { myEvent -= value; }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            myEvent.Invoke(sender, e);
        }
    }
}
