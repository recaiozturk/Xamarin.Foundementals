using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HelloWorld.CollectionViews
{
    public class MovieDataTemplateSelector:DataTemplateSelector
    {
        public DataTemplate MovieDataTemplate { get; set; }
        public DataTemplate PopulerMovieDataTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var movie = item as Movie;

            if (movie.Raiting > 4.5)
            {
                return PopulerMovieDataTemplate;
            }
            else
            {
                return MovieDataTemplate;
            }
        }
    }
}
