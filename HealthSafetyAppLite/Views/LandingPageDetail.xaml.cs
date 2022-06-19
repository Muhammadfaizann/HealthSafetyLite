using HealthSafetyAppLite.ViewModels;
using HealthSafetyAppLite.Views.TopicViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace HealthSafetyAppLite.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingPageDetail : ContentPage
    {
        public LandingPageDetail()
        {
        
            InitializeComponent();
            this.BindingContext = new LandingPageViewModel(Navigation);
        }

       

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {

        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
           Navigation.PushAsync(new  DynamicToolPage());
        }
    }
}