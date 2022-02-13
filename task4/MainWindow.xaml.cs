using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace task4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }
        public event EventHandler EventAddition = null;
        public event EventHandler EventSubtraction = null;
        public event EventHandler EventMultiplication = null;
        public event EventHandler EventDivision = null;
        private void Addition_Click(object sender, RoutedEventArgs e)
        {
            EventAddition.Invoke(sender, e);
        }
        private void Subtraction_Click(object sender, RoutedEventArgs e)
        {
            EventSubtraction.Invoke(sender, e);
        }
        private void Multiplication_Click_1(object sender, RoutedEventArgs e)
        {
            EventMultiplication.Invoke(sender, e);
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            EventDivision.Invoke(sender, e);
        }
    }
}
