using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamIntune
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            PopulateTheWelcomeDialog();
        }

        private async void PopulateTheWelcomeDialog()
        {
            try
            {
                var WelcomeLabel = DependencyService.Get<ICreateWelcomeLabel>();
                lblUserInfo.Text = WelcomeLabel.GetFirstName();
            }
            catch (Exception Except)
            {
                await DisplayAlert("Error in PopulateTheWelcomeDialog", Except.Message, "OK");
            }
        }
    }
}
