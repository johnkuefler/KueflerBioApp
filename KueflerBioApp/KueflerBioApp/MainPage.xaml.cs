using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KueflerBioApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (Application.Current.Properties.ContainsKey("username"))
            {
                loginButton.IsVisible = false;
                usernameLabel.IsVisible = true;
                usernameLabel.Text = Application.Current.Properties["username"] as string;
            }
            else
            {
                loginButton.IsVisible = true;
                usernameLabel.IsVisible = false;
                usernameLabel.Text = "";
            }
        }

        private void BioTapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutMePage());
        }

        private void SkillsTapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SkillsPage());
        }

        private void ContactTapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactPage());
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Loginpage());
        }
    }
}
