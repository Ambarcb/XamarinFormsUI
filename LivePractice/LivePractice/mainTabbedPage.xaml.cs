using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;



namespace LivePractice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class mainTabbedPage : Xamarin.Forms.TabbedPage
    {
        public mainTabbedPage()
        {
            InitializeComponent();

            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            On<Android>().SetBarSelectedItemColor(Color.Yellow);
            

        }

        
    }
}