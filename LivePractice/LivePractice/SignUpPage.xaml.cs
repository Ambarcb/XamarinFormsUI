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
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage(string name)
        {
            InitializeComponent();
            emailLabel.Text = name;
        }

        async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(emailLabel.Text))
            {
                await DisplayAlert("Empty field", "The email address field can't be left empty, please fill it out and try again.", "Ok");
            }
            else if (String.IsNullOrEmpty(usernameLabel.Text))
            {
                await DisplayAlert("Empty field", "The username field can't be left empty, please fill it out and try again.", "Ok");
            }
            else if (String.IsNullOrEmpty(passwordLabel.Text))
            {
                await DisplayAlert("Empty field", "The password field can't be left empty, please fill it out and try again.", "Ok");
            }
            else if (String.IsNullOrEmpty(rPasswordLabel.Text))
            {
                await DisplayAlert("Empty field", "The password repeat field can't be left empty, please fill it out and try again.", "Ok");
            }

            else
            {
                await Navigation.PushModalAsync(new mainTabbedPage());
            }
        }
    }
}