using MyWeather.View;
using MyWeather.ViewModels;
using Xamarin.Forms;

namespace MyWeather
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new WeatherView())
            {
                BindingContext = new WeatherViewModel(),
            };
        }
    }
}