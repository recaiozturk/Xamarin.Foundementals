using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Databases
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoteEntryPage : ContentPage
    {
        public NoteEntryPage()
        {
            InitializeComponent();
        }

        private async void saveButton_Clicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            note.Date=DateTime.Now;

            await App.Database.SaveNoteAsync(note);
            await Navigation.PopAsync();
        }

        private async void deleteButton_Clicked(object sender, EventArgs e)
        {
            var note = BindingContext as Note;
            await App.Database.DeleteNoteAsync(note);
            await Navigation.PopAsync();
        }
    }
}