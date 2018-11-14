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
	public partial class Loginpage : ContentPage
	{
		public Loginpage ()
		{
			InitializeComponent ();
		}

	    private void Button_OnClicked(object sender, EventArgs e)
	    {
            // validate

            // call login api with username and password

            // save user info to device
            Application.Current.Properties["username"] = usernameEntry.Text;

	        Navigation.PopAsync();
	    }
    }
}