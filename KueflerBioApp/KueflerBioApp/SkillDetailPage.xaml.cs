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
	public partial class SkillDetailPage : ContentPage
	{
		public SkillDetailPage (Skill incomingSkill)
		{
			InitializeComponent ();

		    skillImage.Source = incomingSkill.Icon;
		    skillDescriptionLabel.Text = incomingSkill.Description;
		    skillNameLabel.Text = incomingSkill.Name;
		    skillTypeLabel.Text = incomingSkill.Type;
		    skillAlertnateNameLabel.Text = incomingSkill.AlternateName;
		}
	}
}