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
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<Models.Contact>
            {
                new Models.Contact{Name = "Jatin" , Status = "True"},
                new Models.Contact{Name = "Mosh" , Status = "False"}
            };
        }

        async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var contact = e.SelectedItem as Models.Contact;
            await Navigation.PushAsync(new ContactDetailPage(contact));

            listView.SelectedItem = null;

        }
    }
}