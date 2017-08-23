using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HelloXamarinForms
{
    public partial class App : Application
    {
        public App()
        {
            // The root page of your application
            var layout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children ={new Label{HorizontalTextAlignment = TextAlignment.Center, Text = "Welcome to Xamarin Forms!"}}
            };

            MainPage = new ContentPage
            {
                Content = layout
            };

            Button button = new Button
            {
                Text = "Click Me"
            };

            button.Clicked += async (s, e) => {
                await MainPage.DisplayAlert("Alert", "You clicked me", "OK");
            };

            layout.Children.Add(button);
        }
    }
}
