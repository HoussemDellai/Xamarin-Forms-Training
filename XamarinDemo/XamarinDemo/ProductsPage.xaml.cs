using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinDemo
{
    public partial class ProductsPage : ContentPage
    {
        private List<Product> products = new List<Product>
        {
            new Product
            {
                Name = "TV",
                Price = 800,
                ImageUrl = ""
            },
            new Product
            {
                Name = "Radio",
                Price = 40,
                ImageUrl = ""
            },
            new Product
            {
                Name = "Table",
                Price = 90,
                ImageUrl = ""
            },
        };
        public ProductsPage()
        {
            InitializeComponent();

            ProductsListView.ItemsSource = products;
        }

        private async void Products_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //var p = ProductsListView.SelectedItem as Product;
            Product product = e.Item as Product;
            if (product != null)
            {
                await DisplayAlert("Produit Selectionné",
                    product.Name,
                    "Ok");

                await Navigation.PushModalAsync(new ProductDetailsPage(product));
            }
        }
    }
}
