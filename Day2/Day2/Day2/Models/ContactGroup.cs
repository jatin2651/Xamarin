using System;
using System.Collections.Generic;
using System.Text;

namespace Day2.Models
{
    class ContactGroup : List<Models.Contact>
    {
        public string Title { get; set; }
        public string ShortTitle { get; set; }

        public ContactGroup(string Title, string ShortTitle)
        {
            this.Title = Title;
            this.ShortTitle = ShortTitle;
        }
    }
}
