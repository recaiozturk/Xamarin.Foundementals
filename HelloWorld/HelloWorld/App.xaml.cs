using HelloWorld.CollectionViews;
using HelloWorld.Controls;
using HelloWorld.Databases;
using HelloWorld.DataBindings;
using HelloWorld.Lists;
using HelloWorld.Navigation;
using HelloWorld.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    public partial class App : Application
    {
        public static string  FolderPath { get; private set; }

        private static NoteDatabase database;

        //Singleten işlemi -varolan objeyi her zaman kullanıyoruz  --her yeni istekte coccection objesi olusturmuyoruz
        public static NoteDatabase Database
        {
            get 
            {
                if (database == null)
                {
                    database = new NoteDatabase(Path.Combine(App.FolderPath, "NotesDb.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new RestApiPage();

            FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
