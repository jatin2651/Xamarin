using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AirBnb : ContentPage
    {

        
        public AirBnb()
        {
            InitializeComponent();

            listView.ItemsSource = getSearch();
      
        }

        IEnumerable<Models.Search> getSearch(string text = null)
        {
            var search = new List<Models.Search>
            {
                new Models.Search { name = "West Hollywood, CA, United States", date = "Sep 1, 2016 - Nov 1, 2016" },
                new Models.Search { name = "Santa Monica, CA, United States", date = "Sep 1, 2016 - Nov 1, 2016" }
            };

            if (string.IsNullOrWhiteSpace(text))
                return search;

            return search.Where(x => x.name.StartsWith(text));
   
        }

        

        

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var search = menuItem.CommandParameter as Models.Search;

            




            
            
            

        }

        private void ListView_Refreshing(object sender, EventArgs e)
        {
            listView.ItemsSource = getSearch();

            listView.EndRefresh();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = getSearch(e.NewTextValue);
        }
    }
}