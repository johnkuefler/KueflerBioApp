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
    }
}
