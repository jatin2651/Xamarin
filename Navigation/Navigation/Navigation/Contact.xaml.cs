using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contact : ContentPage
    {
        public Contact()
        {
            InitializeComponent();

            var contact = new List<NewFolder2.Contact>
            {
                new NewFolder2.Contact{name = "Jatin", status= "Hello i am available"},
                new NewFolder2.Contact{name = "Mohit", status= "Sunday was fun"}
            };

            listView.ItemsSource = contact;
        }

        async private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var contact = e.SelectedItem as NewFolder2.Contact;
            await Navigation.PushAsync(new ContactDetail(contact));
            listView.SelectedItem = null;
        }
    }
}