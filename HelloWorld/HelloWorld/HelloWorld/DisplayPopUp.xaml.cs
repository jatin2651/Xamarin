using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayPopUp : ContentPage
    {
        public DisplayPopUp()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            // var response = await DisplayAlert("Warning", "Are your sure", "Yes", "No");       This was to demonstrate DisplayAlert

            //if (response)
            //  await DisplayAlert("Thanks", "Your response has been saved", "OK");

            var response = await DisplayActionSheet("Title", "Cancel", "Delete", "Copy Link", "Message", "Email");

            await DisplayAlert("Response", response, "OK");
        }



    }
}