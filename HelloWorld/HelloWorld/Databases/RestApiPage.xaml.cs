using HelloWorld.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Databases
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestApiPage : ContentPage
    {

        const string apiUrl = "https://jsonplaceholder.typicode.com/posts";
        private HttpClient _client = new HttpClient();
        public RestApiPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            //apiye sorgumuzu gonderiyoruz
            var result =await _client.GetStringAsync(apiUrl);
            listView.ItemsSource = JsonConvert.DeserializeObject<List<Post>>(result);

            base.OnAppearing();
        }
    }
}