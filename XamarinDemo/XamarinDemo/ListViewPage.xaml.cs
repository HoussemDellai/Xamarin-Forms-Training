using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinDemo
{
    public partial class ListViewPage : ContentPage
    {
        List<string> names = new List<string>
        {
            "Mohamed", "Ahmed", "Ali", "Farid", "Hassen"
        };
        public ListViewPage()
        {
            InitializeComponent();

            PersonnesListView.ItemsSource = names;
        }
    }
}
