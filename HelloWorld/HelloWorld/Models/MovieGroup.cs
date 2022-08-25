using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HelloWorld.Models
{
    public class MovieGroup:ObservableCollection<Movie>
    {
        public string Title { get; set; }
        public string ShorName { get; set; }

        public MovieGroup(string title,string shorname)
        {
            Title = title;
            ShorName = shorname;
        }
    }
}
