using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void Add_btn(object sender, EventArgs e)
        {
            double first = double.Parse(value1.Text);
            double second = double.Parse(value2.Text);
            result.Text =(first + second).ToString();

        }
    }
}
