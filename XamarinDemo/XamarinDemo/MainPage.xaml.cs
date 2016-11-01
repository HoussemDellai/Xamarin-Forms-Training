using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            TitleLabel.Text = Device.OnPlatform<string>(
                "iOS App",
                "Android App", 
                "Windows App");

            Button b = new Button();
            b.Text = "C Sharp Button";
            b.TextColor = Color.White;
            b.BackgroundColor = Color.Teal;

            MainStackLayout.Children.Add(b);
            b.Clicked += SayHello_Clicked;
            b.Clicked += (o, e) =>
            {
                DisplayAlert("Lambda Expression", "C Sharp", "Ok");
            };

            ProfessionPicker.Items.Add("Etudiant");
            ProfessionPicker.Items.Add("Ingénieur");
            ProfessionPicker.Items.Add("Docteur");
        }
        private void SayHello_Clicked(object o, EventArgs e)
        {
            string name = NameLabel.Text;

            HelloLabel.Text = "Hello " + name;

            string profession = ProfessionPicker.Items.ElementAt(ProfessionPicker.SelectedIndex).ToString();

            DateTime birthdate = BirthdayDatePicker.Date;
        }
    }
}
