using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinDemo.MVVM
{
    public partial class NonMvvmPersonPage : ContentPage
    {
        public NonMvvmPersonPage()
        {
            InitializeComponent();
        }

        private void SayHello_Clicked(object sender, EventArgs e)
        {
            var name = NameEntry.Text;

            HelloLabel.Text = "Hello " + name;
        }
    }
}
