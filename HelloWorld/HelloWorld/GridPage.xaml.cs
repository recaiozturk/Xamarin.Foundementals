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
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            InitializeComponent();

            var layout = new Grid
            {
                RowSpacing = 10,
                ColumnSpacing = 10
            };

            var lbl1 = new Label { Text = "Row 1 Column 1", BackgroundColor = Color.White };
            var lbl2 = new Label { Text = "Row 1 Column 2", BackgroundColor = Color.White };
            var lbl3 = new Label { Text = "Row 2 Column 1", BackgroundColor = Color.White };
            var lbl4 = new Label { Text = "Row 2 Column 2", BackgroundColor = Color.White };
            var lbl5 = new Label { Text = "Row 3 Column 1", BackgroundColor = Color.White };
            var lbl6 = new Label { Text = "Row 3 Column 2", BackgroundColor = Color.White };

            var lbl7 = new Label { Text = "Colspan", BackgroundColor = Color.White };
            var lbl8 = new Label { Text = "RowSpan", BackgroundColor = Color.White };

            layout.Children.Add(lbl1, 0, 0);  //0. sütün 0.satır.
            layout.Children.Add(lbl2, 1, 0);
            layout.Children.Add(lbl3, 0, 1);
            layout.Children.Add(lbl4, 1, 1);
            layout.Children.Add(lbl5, 0, 2);
            layout.Children.Add(lbl6, 1, 2);

            layout.Children.Add(lbl7, 0, 3);
            Grid.SetColumnSpan(lbl7, 2);

            layout.Children.Add(lbl8, 2, 0);
            Grid.SetRowSpan(lbl8, 4);

            layout.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(100, GridUnitType.Absolute),
            });

            layout.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(200, GridUnitType.Absolute),
            });

            layout.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(1, GridUnitType.Star),
            });

            layout.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(2, GridUnitType.Star),
            });

            //Colum Defination
            layout.ColumnDefinitions.Add(new ColumnDefinition
            {
                Width = new GridLength(1, GridUnitType.Auto),
            });

            layout.ColumnDefinitions.Add(new ColumnDefinition
            {
                Width = new GridLength(100, GridUnitType.Absolute),
            });

            layout.ColumnDefinitions.Add(new ColumnDefinition
            {
                Width = new GridLength(1, GridUnitType.Star),
            });

            Content = layout;


        }



    }

}