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
    public partial class ListDemo : ContentPage
    {
        public ListDemo()
        {
            InitializeComponent();


            listview.ItemsSource = GetContacts();

            /*  
             For demonstrating normal list view items
             
            listview.ItemsSource = new List<Models.Contact>             
            {
                new Models.Contact{ Name = "Jatin", Image = "http://lorenpixel.com/100/100/people/1"},
                new Models.Contact{ Name = "Jatin", Image = "http://lorenpixel.com/100/100/people/2", Status = "True" }
            };
            */
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listview.ItemsSource =  GetContacts(e.NewTextValue);
        }

        List<Models.Contact> GetContacts(string searchText = null )
        {
            
            var contacts  = new List<Models.Contact> 
            { 
            new Models.Contact{ Name = "Jatin", Image = "http://lorenpixel.com/100/100/people/1"},
            new Models.Contact{ Name = "Abhi", Image = "http://lorenpixel.com/100/100/people/1", Status = "Let's Talk"}, 
            };

            if(String.IsNullOrWhiteSpace(searchText))
                return contacts;

            return contacts.Where(c => c.Name.StartsWith(searchText)).ToList();
   
        }


            
        

        private void listview_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Models.Contact;
            DisplayAlert("Tapped Items", contact.Name, "OK");
        }


        private void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Models.Contact;
            DisplayAlert("Selected", contact.Name, "OK");

        }

       
    }
}