using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            pkOper.Items.Add("Suma");
            pkOper.Items.Add("Resta");
            pkOper.Items.Add("Multiplicacion");
            pkOper.Items.Add("Division");
        }

        private void pkOper_SelectedIndexChanged(object sender, EventArgs e)
        {
            string op = pkOper.SelectedItem.ToString();
            float n1 = float.Parse(txtN1.Text);
            float n2 = float.Parse(txtN2.Text);
            double res = 0;

            if (op == "Suma")
                res = n1 + n2;
            else if (op == "Resta")
                res = n1 - n2;
            else if (op == "Multiplicacion")
                res = n1 * n2;
            else if (op == "Division")
                res = n1 / n2;
            lblRes.Text = res + "";
        }
    }
}
