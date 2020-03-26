﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactDetail : ContentPage 
    {
        
        public ContactDetail(NewFolder2.Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException();

            BindingContext = contact;
            InitializeComponent();
        }

        
    }
}