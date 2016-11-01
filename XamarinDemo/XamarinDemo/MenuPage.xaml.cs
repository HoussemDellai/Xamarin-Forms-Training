using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinDemo
{

    public partial class MenuPage : MasterDetailPage//ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new ProductsPage();
        }
    }
}
