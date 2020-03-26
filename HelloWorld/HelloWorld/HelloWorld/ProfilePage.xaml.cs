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
    public partial class ProfilePage : ContentPage
    {
        

        public readonly ActivityFeed activity = new ActivityFeed();
        public ProfilePage(int UserId)
        {

            BindingContext = getUser(UserId);

            

            InitializeComponent();
        }

        public List<Models.UserProfile> user = new List<Models.UserProfile>
        {
            new Models.UserProfile {Id = 1 , Description = "My Name is Jenny Dalby", Name = "Jenny Dalby"},
            new Models.UserProfile {Id = 2 , Description = "My Name is Jonv", Name = "Jonv"},
            new Models.UserProfile {Id = 3 , Description = "My Name is Rachel Martin", Name = "Rachel Martin"},
            new Models.UserProfile {Id = 4 , Description = "My Name is Nivan Jay", Name = "Nivan Jay"},
            new Models.UserProfile {Id = 5 , Description = "My Name is Sanazz", Name = "Sanazz"},
            new Models.UserProfile {Id = 6 , Description = "My Name is NextLab", Name = "NextLab"},
            new Models.UserProfile {Id = 7 , Description = "My Name is Alex B", Name = "Alex B"},
            new Models.UserProfile {Id = 8 , Description = "My Name is Tara Chang", Name = "Tara Chang"},
            new Models.UserProfile {Id = 9 , Description = "My Name is TomK", Name = "TomK"},
        };
            
        public Models.UserProfile getUser(int userId)
        {
            return user.SingleOrDefault(u => u.Id == userId);
        }

    }
}