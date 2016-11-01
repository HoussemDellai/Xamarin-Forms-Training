using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XamarinDemo.TabbedPage;
using XamarinDemo.WebServices;

namespace XamarinDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GetStudentsPage();
            //MainPage = new Xamarin.Forms.TabbedPage
            //{
            //    Children =
            //    {
            //        new FirstPage(),
            //        new SecondPage(),
            //        new ThirdPage()
            //    }
            //};
            //MainPage = new MenuPage();
            //MainPage = new ProductsPage();
            //MainPage = new ListViewPage();
            //MainPage = new StylesPage();
            //MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
