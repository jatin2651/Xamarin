using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {

        private int index = 0;
        private String[] quotes = new String[4]
        {
            "Hello my name is jatin",
            "Hello good after noon mate",
            "Cya bbye take care",
            "Mondays are boring"
        };


        public Page2()
        {
            InitializeComponent();
            label2.Text = quotes[0];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            index = index + 1;

            if(index >= quotes.Length)
            {
                index = 0;
            }

            label2.Text = quotes[index];
        }
    }
}