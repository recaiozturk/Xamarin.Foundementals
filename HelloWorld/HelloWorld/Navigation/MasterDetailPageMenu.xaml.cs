using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPageMenu : MasterDetailPage
    {

        List<MasterDetailPageModel> menuList;
        public MasterDetailPageMenu()
        {
            InitializeComponent();

            menuList = new List<MasterDetailPageModel>();

            menuList.Add(new MasterDetailPageModel()
            {
                Title ="FirstPage",
                Icon="first.png",
                PageType= typeof(FirstPage),

            });

            menuList.Add(new MasterDetailPageModel()
            {
                Title = "SecondPage",
                Icon = "first.png",
                PageType = typeof(SecondPage),

            });

            menuList.Add(new MasterDetailPageModel()
            {
                Title = "ThirdPage",
                Icon = "first.png",
                PageType = typeof(ThirdPage),

            });

            //Master page in menu kısmı
            listView.ItemsSource = menuList;

            //Master Page in detail kısmı sag taraf
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(FirstPage)));

        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item=e.SelectedItem as MasterDetailPageModel;
            Type page=item.PageType;
            Detail=new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented=false;
            
        }
    }
}