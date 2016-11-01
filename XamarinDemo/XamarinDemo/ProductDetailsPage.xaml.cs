using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinDemo
{
    public partial class ProductDetailsPage : ContentPage
    {
        public ProductDetailsPage(Product product)
        {
            InitializeComponent();

            ProductNameLabel.Text = product.Name;
            ProductPriceLabel.Text = product.Price.ToString();
        }
    }
}
