using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KueflerBioApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SkillsPage : ContentPage
	{
        public ObservableCollection<Skill> Skills { get; set; }
 
		public SkillsPage ()
		{
			InitializeComponent ();

            Skills = new ObservableCollection<Skill>();

		    Skills.Add(new Skill
		    {
		        Icon="csharp.png",
		        Description = "C# Programming",
                Name = "C#",
                Type = "programming",
                AlternateName = "Csharp"
		    });
            Skills.Add(new Skill
            {
                Icon="teacher.png",
                Description = "Teaching programming courses",
                Name = "Teaching",
                Type = "communication",
                AlternateName = "Making stuff up"
            });

            skillsListView.ItemsSource = this.Skills;
		}

        private void SkillsListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }

            Skill selectedSkill = e.SelectedItem as Skill;

            (sender as ListView).SelectedItem = null;

            Navigation.PushAsync(new SkillDetailPage(selectedSkill));
            // DisplayAlert("Hi", "You tapped " + selectedSkill.Name, "ok");
        }
    }

    public class Skill
    {
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string AlternateName { get; set; }
    }
}