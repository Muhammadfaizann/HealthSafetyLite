using HealthSafetyAppLite.Models;
using HealthSafetyAppLite.Views.TopicViews;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HealthSafetyAppLite.ViewModels
{
   public class LandingPageViewModel  :BaseViewModel
    {
        public INavigation Navigation { get; set; }
       
        public ICommand EmailCommand { get; set; }
        public ICommand NavigationCommand { get; set; }
        public LandingPageViewModel(INavigation navigation)
        {
            this.Navigation = navigation;

            EmailCommand = new Command( () => {  SendEmail(); });
            NavigationCommand = new Command((item) => { PageNavigation(item); });
            
        }

        private async void PageNavigation(object item)
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var title = (string)item;
                if (title == "Dynamic Assessment Tool")
                {
                    await Navigation.PushAsync(new DynamicToolPage());
                }
                else if (title == "Cash Assessment Tool")
                {
                    await Navigation.PushAsync(new CashToolPage());
                }
                else if (title == "Work Station Assessment Tool")
                {
                    await Navigation.PushAsync(new WorkStationToolPage());
                }
                else if (title == "Manual Handling Risk Assessment Tool")
                {
                    await Navigation.PushAsync(new ManualRiskToolPage());
                }
                else if (title == "Accident Record Form Tool")
                {
                    await Navigation.PushAsync(new AccidentToolPage());

                }
                else if (title == "Safe System of Work Tool")
                {
                    await Navigation.PushAsync(new SafeSystemToolPage());
                }
                else if (title == "Audit Form Tool")
                {
                    await Navigation.PushAsync(new AuditToolPage());
                }
                else if (title == "ToolBox Talks")
                {
                    await Navigation.PushAsync(new ToolBoxPage());
                }

            }
            catch (Exception ex)
            {

               
            }
            IsBusy = false;

            
        }
        bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged("IsBusy");
            }
        }

        private async void SendEmail()
        {
           // var emailReceiver = Preferences.Get("UserName", "");

            //await Email.ComposeAsync("","", "support@thehealthandsafetyapp.co.uk");
            Device.OpenUri(new Uri("mailto:support@thehealthandsafetyapp.co.uk"));

        }
    }
}
