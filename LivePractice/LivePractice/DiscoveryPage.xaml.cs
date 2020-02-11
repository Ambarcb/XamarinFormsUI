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
    public partial class DiscoveryPage : ContentPage
    {
        public DiscoveryPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackgroundColor.Equals(Color.WhiteSmoke))
                btn.BackgroundColor = Color.FromHex("#FFBC00");
            else
                btn.BackgroundColor = Color.Transparent;
        }
    }
}
