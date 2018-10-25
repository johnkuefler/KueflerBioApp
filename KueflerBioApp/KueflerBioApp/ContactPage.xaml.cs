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
	public partial class ContactPage : ContentPage
	{
		public ContactPage ()
		{
			InitializeComponent ();
		}

	    private void Button_OnClicked(object sender, EventArgs e)
	    {
	        if (string.IsNullOrEmpty(nameEntry.Text))
	        {
	            DisplayAlert("Error", "Please enter name", "Ok");
	            return;
	        }

	        if (string.IsNullOrEmpty(emailEntry.Text))
	        {
	            DisplayAlert("Error", "Please enter email", "Ok");
	            return;
	        }

	        if (string.IsNullOrEmpty(messageEditor.Text))
	        {
	            DisplayAlert("Error", "Please enter message", "Ok");
	            return;
	        }

            DisplayAlert("Alert", "Your message was sent!", "Ok");
	    }
	}
}