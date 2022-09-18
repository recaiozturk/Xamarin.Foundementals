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
        public partial class DemoFileSystemEntryPage : ContentPage
        {

        

            public DemoFileSystemEntryPage()
            {
                InitializeComponent();

            

            }

            async private void saveButton_Clicked(object sender, EventArgs e)
            {
                var note = (Note)BindingContext;

                //gelen note nesnesinin FileName i bos ise
                if (string.IsNullOrWhiteSpace(note.FileName))
                {
                    var fileName = Path.Combine(App.FolderPath, $" {Path.GetRandomFileName()}.notes.txt");

                    File.WriteAllText(fileName, note.Text);
                }
                else
                {
                    File.WriteAllText(note.FileName, note.Text);
                }

           

                await Navigation.PopAsync();
            }

            private async void deleteButton_Clicked(object sender, EventArgs e)
            {
                var note = (Note)BindingContext;

                if (File.Exists(note.FileName))
                {
                    File.Delete(note.FileName);
                }

                await Navigation.PopAsync();

            }
        }
}