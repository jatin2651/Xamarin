using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercise1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HelloPage : ContentPage
    {

        private int index = 0;


        private string[] quotes = new string[]
        {
            "i am feeling hungry",
            "I will eat during the lunch time",
            " have eaten already"
            
        };

       




        public HelloPage()
        {
            InitializeComponent();

            CurrentQuote.Text = quotes[index];

            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            index++;

            if(index >= quotes.Length)
            {
                index = 0;
            }

            CurrentQuote.Text = quotes[index];

        }
    }
}