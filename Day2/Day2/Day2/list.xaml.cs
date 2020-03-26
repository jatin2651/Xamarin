using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Day2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class list : ContentPage
    {
        private ObservableCollection<Models.Contact> _contacts; 
        public list()
        {
            InitializeComponent();
            listview.ItemsSource = GetContacts();
        }

        IEnumerable<Models.Contact> GetContacts(string searchText = null)
        {
            var contacts =  new List<Models.Contact>
            {

                    new Models.Contact{name = "Jatin" , status = "Hey,Lets Talk"},
                    new Models.Contact{name = "John" , status = "Sleeping"},
                    new Models.Contact{name = "Mosh" },
                    new Models.Contact{name = "Mohan" , status = "Take care"}
            };

            if (string.IsNullOrWhiteSpace(searchText))
                return contacts;

            return contacts.Where(c => c.name.StartsWith(searchText));
        }

        

        private void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Models.Contact;
            DisplayAlert("Selected", contact.name, "OK");
        }

        private void listview_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Models.Contact;
            DisplayAlert("Tapped", contact.name, "OK");
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Models.Contact;

            DisplayAlert("CAll", contact.name, "OK");

        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Models.Contact;

            _contacts.Remove(contact);
        }

        private void listview_Refreshing(object sender, EventArgs e)
        {
            listview.ItemsSource = GetContacts();

            listview.EndRefresh();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listview.ItemsSource = GetContacts(e.NewTextValue);
        }
    }
}