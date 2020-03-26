using HelloWorld.Models;
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
    public partial class ActivityFeed : ContentPage
    {

        public ActivityFeed()
        {
            InitializeComponent();

            listView.ItemsSource = GetActivities();
        }

        public IEnumerable<Activity> GetActivities()
        {
            return new List<Activity>
            {
                new Activity { UserId = 1, Description = "Your Facebook friend Jenny Dalby is on Instagram" },
                new Activity { UserId = 2, Description = "Jonv started following you" },
                new Activity { UserId = 3, Description = "Rachel Martin liked your photo" },
                new Activity { UserId = 4, Description = "Your facebook friend Nivan jay is on intsagram" },
                new Activity { UserId = 5, Description = "SanazZ sent a photo posted by @wfwf" },
                new Activity { UserId = 6, Description = "NextLab started following you" },
                new Activity { UserId = 7, Description = "Your facebook friend Alex B is on Instagram" },
                new Activity { UserId = 8, Description = "Your facebook friend Tara chang is on Instagram" },
                new Activity { UserId = 9, Description = "Your facebook friend Tom K is on Instagram" }
            };
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var  detail =  e.SelectedItem as Activity;
            listView.SelectedItem = null;
            Navigation.PushAsync(new ProfilePage(detail.UserId));
            


        }
    }
}