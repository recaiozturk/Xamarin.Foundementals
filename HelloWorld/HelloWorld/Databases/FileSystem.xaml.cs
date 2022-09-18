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
    public partial class FileSystem : ContentPage
    {
        //data klasörümüzün yolu
        public static string dataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string fileName = Path.Combine(dataFolder, "notes.txt");

        public FileSystem()
        {
            InitializeComponent();

            if (File.Exists(fileName))
            {
                editor.Text=File.ReadAllText(fileName);
            }
        }

        private void saveButton_Clicked(object sender, EventArgs e)
        {
            File.WriteAllText(fileName, editor.Text);
        }

        private void deleteButton_Clicked(object sender, EventArgs e)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                editor.Text =String.Empty;
            }
        }
    }
}