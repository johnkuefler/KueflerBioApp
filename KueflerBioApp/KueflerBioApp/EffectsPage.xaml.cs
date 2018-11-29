using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KueflerBioApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EffectsPage : ContentPage
    {
        public EffectsPage()
        {
            InitializeComponent();

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await alertFrame.TranslateTo(alertFrame.TranslationX, alertFrame.TranslationY - 100, 500);
            await alertFrame.FadeTo(0.7, 700);

            agendaFrame.FadeTo(0.7, 700);
            agendaFrame.TranslateTo(agendaFrame.TranslationX, agendaFrame.TranslationY - 140, 500);

        }
    }
}