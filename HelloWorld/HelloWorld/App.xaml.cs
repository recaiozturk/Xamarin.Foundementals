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

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new DemoFileSystemNotesPage());

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
