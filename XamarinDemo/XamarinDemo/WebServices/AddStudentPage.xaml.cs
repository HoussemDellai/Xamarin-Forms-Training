using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace XamarinDemo.WebServices
{
    public partial class AddStudentPage : ContentPage
    {
        private string url = "http://mystudents.azurewebsites.net/api/StudentsApi";
        public AddStudentPage()
        {
            InitializeComponent();
        }

        private async void AddStudent_Clicked(object sender, EventArgs e)
        {
            var student = new Student
            {
                Fullname = FullnameEntry.Text,
                Department = DepartmentEntry.Text,
            };

            var json = JsonConvert.SerializeObject(student);

            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var httpClient = new HttpClient();

            var response = await httpClient.PostAsync(url, httpContent);
        }
    }
}
