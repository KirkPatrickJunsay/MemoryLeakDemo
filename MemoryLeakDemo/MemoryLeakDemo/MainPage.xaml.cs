using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MemoryLeakDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private async void Page1Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubPage1());

            MessagingCenter.Send<string>("Hello Page 1", "UpdatePage1Label");
        }

        private async void Page2Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubPage2());

            MessagingCenter.Send<string>("Hello Page 2", "UpdatePage2Label");
        }

        private async void Page3Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubPage3());

            MessagingCenter.Send<string>("Hello Page 3", "UpdatePage3Label");
        }
    }
}
