using Plugin.Media;
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
	public partial class PicturePage : ContentPage
	{
		public PicturePage ()
		{
			InitializeComponent ();
		}

	    private async void Button_OnClicked(object sender, EventArgs e)
	    {
	        await CrossMedia.Current.Initialize();

	        if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
	        {
	            DisplayAlert("No Camera", ":( No camera available.", "OK");
	            return;
	        }

	        var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
	        {
	            Directory = "Sample",
	            Name = "test.jpg"
	        });

	        if (file == null)
	            return;

	        await DisplayAlert("File Location", file.Path, "OK");

	        pictureOnPage.Source = ImageSource.FromStream(() =>
	        {
	            var stream = file.GetStream();
	            return stream;
	        });

        }
	}
}