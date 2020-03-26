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
    public partial class ListExercise : ContentPage
    {
        public ListExercise()
        {
            InitializeComponent();

            listView.ItemsSource = getLocations();
            
        }
        
        private List<Models.AirBnb> getLocations(string text = null)
        {
            var locations = new List<Models.AirBnb>
            {
                new Models.AirBnb{Location = "West Hollywood, CA, United States" , CheckIn = "Sep 1,2016 -" , CheckOut = "Nov 1,2016"},
                new Models.AirBnb{Location = "Santa Monica, CA, United States" , CheckIn = "Sep 1,2016 -" , CheckOut = "Nov 1,2016"}
            };

            if(String.IsNullOrWhiteSpace(text))
                return locations;
            return locations.Where(x => x.Location.StartsWith(text)).ToList();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = getLocations(e.NewTextValue);

        }

        private void listView_Refreshing(object sender, EventArgs e)
        {
            listView.ItemsSource = getLocations();

            listView.EndRefresh();
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var location = e.SelectedItem as Models.AirBnb;
            DisplayAlert("Selected", location.Location, "OK");
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var location = menuItem.CommandParameter as Models.AirBnb;
            DisplayAlert("Call", location.Location, "OK");
        }

        private List<Models.AirBnb> _locations;
        private void Deleted_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var location = menuItem.CommandParameter as Models.AirBnb;

            getLocations().Remove(location);

            



        }

        

        
    }
}