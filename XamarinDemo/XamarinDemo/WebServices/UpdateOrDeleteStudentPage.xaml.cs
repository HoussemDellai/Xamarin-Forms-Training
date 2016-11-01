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
    public partial class UpdateOrDeleteStudentPage : ContentPage
    {
        private readonly Student _student;
        private string url = "http://mystudents.azurewebsites.net/api/StudentsApi/";
        public UpdateOrDeleteStudentPage(Student student)
        {
            InitializeComponent();

            _student = student;
            FullnameEntry.Text = student.Fullname;
            DepartmentEntry.Text = student.Department;
        }

        private async void EditStudent_Clicked(object sender, EventArgs e)
        {
            var student = new Student
            {
                Id = _student.Id,
                Fullname = FullnameEntry.Text,
                Department = DepartmentEntry.Text,
            };

            var json = JsonConvert.SerializeObject(student);

            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var httpClient = new HttpClient();

            var response = await httpClient.PutAsync(url + _student.Id, httpContent);
        }
        private async void DeleteStudent_Clicked(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();

            var response = await httpClient.DeleteAsync(url + _student.Id);
        }
    }
}
