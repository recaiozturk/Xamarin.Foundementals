using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Databases
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DemoFileSystemNotesPage : ContentPage
    {
        public DemoFileSystemNotesPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var notes= new List<Note>();

            //sonu .notes.txt ile biten dosyaları bize liste olarak verir
            var files = Directory.EnumerateFiles(App.FolderPath, "*.notes.txt");

            foreach (var file in files)
            {
                notes.Add(new Note
                {
                    FileName= file,
                    Text=File.ReadAllText(file),
                    Date=File.GetCreationTime(file)
                });
            }

            listView.ItemsSource = notes.OrderBy(d=>d.Date).ToList();
        }

        async private void ToolbarPlus_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DemoFileSystemEntryPage
            {
                BindingContext = new Note()
            });
        }

        async private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem is Note)
            {
                await Navigation.PushAsync(new DemoFileSystemEntryPage()
                {
                    BindingContext=e.SelectedItem as Note
                });
            }
        }
    }
}