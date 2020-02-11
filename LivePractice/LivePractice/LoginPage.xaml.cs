using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LivePractice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage(labelName.Text));
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            
            
            if (String.IsNullOrEmpty(labelName.Text))
            {
                await DisplayAlert("Empty field", "The username or email address field can't be left empty, please fill it out", "Ok");
            }
            else if (String.IsNullOrEmpty(labelPassword.Text))
            {
                await DisplayAlert("Empty field", "The password field can't be left empty, please fill it out", "Ok");
            }
            else
            {
                await Navigation.PushModalAsync(new mainTabbedPage());
            }

            
        }
    }
}