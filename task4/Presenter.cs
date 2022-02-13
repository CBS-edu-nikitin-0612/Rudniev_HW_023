using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Presenter
    {
        Model model;
        MainWindow view;

        public Presenter(MainWindow view)
        {
            this.model = new Model();
            this.view = view;
            this.view.EventAddition += new EventHandler(view_add);
            this.view.EventSubtraction += new EventHandler(view_sub);
            this.view.EventMultiplication += new EventHandler(view_mult);
            this.view.EventDivision += new EventHandler(view_div);
        }
        void view_add(object sender, System.EventArgs e)
        {
            this.view.BoxResult.Content = "= " + model.Addition(double.Parse(view.BoxA.Text), double.Parse(view.BoxB.Text));
        }
        void view_sub(object sender, System.EventArgs e)
        {
            this.view.BoxResult.Content = "= " + model.Subtraction(double.Parse(view.BoxA.Text), double.Parse(view.BoxB.Text));
        }
        void view_mult(object sender, System.EventArgs e)
        {
            this.view.BoxResult.Content = "= " + model.Multiplication(double.Parse(view.BoxA.Text), double.Parse(view.BoxB.Text));
        }
        void view_div(object sender, System.EventArgs e)
        {
            this.view.BoxResult.Content = "= " + model.Division(double.Parse(view.BoxA.Text), double.Parse(view.BoxB.Text));
        }
    }
}
