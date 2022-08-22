using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.ThemeResources
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RedTheme : ResourceDictionary
    {
        public RedTheme()
        {
            InitializeComponent();
        }
    }
}