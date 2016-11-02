using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HockeyApp;
using Xamarin.Forms;

namespace XamarinDemo.WebServices
{
    public partial class GetStudentsPage : ContentPage
    {
        private string url = "http://mystudents.azurewebsites.net/api/StudentsApi";
        public GetStudentsPage()
        {
            InitializeComponent();

            DownloadStudentsAsync();
        }
        private async Task DownloadStudentsAsync()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var httpClient = new HttpClient();
            string json = await httpClient.GetStringAsync(url);

            var students = JsonConvert.DeserializeObject<List<Student>>(json);

            StudentsListView.ItemsSource = students;

            stopwatch.Stop();
            var time = stopwatch.ElapsedMilliseconds;

            MetricsManager.TrackEvent(
                "DownloadStudentsAsync()",
                new Dictionary<string, string>
                {
                    { "DateTime", DateTime.UtcNow.ToString() }
                },
                new Dictionary<string, double>
                {
                    { "Duration", time }
                });
        }

        private async void GoToAddStudent_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddStudentPage());
        }

        private async void GoToUpdateOrDelete_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var student = e.Item as Student;
            if (student != null)
            {
                await Navigation.PushModalAsync(new UpdateOrDeleteStudentPage(student));
            }
        }
    }
}
