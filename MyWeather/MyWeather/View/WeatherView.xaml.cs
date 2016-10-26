using MyWeather.ViewModels;
using System;
using Xamarin.Forms;

namespace MyWeather.View
{
    public partial class WeatherView : ContentPage
    {
        public WeatherView()
        {
            InitializeComponent();

            if (Device.OS == TargetPlatform.iOS)
                Icon = new FileImageSource { File = "tab1.png" };

           // Background.Source = ImageSource.FromResource("MyWeather.cloud.jpg");
        }
    }
}