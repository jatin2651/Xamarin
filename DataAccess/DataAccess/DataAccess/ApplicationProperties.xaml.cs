using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataAccess
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApplicationProperties : ContentPage
    {

        private const string TitleKey = "Name";
        private const string NotificationsEnabledKay = "NotificationsEnabled";
        public ApplicationProperties()
        {
            InitializeComponent();

            if(Application.Current.Properties.ContainsKey("TitleKey"))
                title.Text = Application.Current.Properties["TitleKey"].ToString();
            
            if(Application.Current.Properties.ContainsKey("NotificationsEnabledKay"))
                notificationsEnabled.On = (bool)Application.Current.Properties["NotificationsEnabledKay"];
        }

      

        private void change(object sender, EventArgs e)
        {
            Application.Current.Properties["Name"] = title.Text;
            Application.Current.Properties["NotificationsEnabled"] = notificationsEnabled.On;


        }

        

        
    }
}