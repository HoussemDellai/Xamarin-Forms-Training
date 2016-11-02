using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinDemo.MVVM.ViewModels
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private string _helloMessage;
        public string Name { get; set; }

        public string HelloMessage
        {
            get { return _helloMessage; }
            set
            {
                _helloMessage = value; 
                OnPropertyChanged();
            }
        }

        public Command SayHelloCommand
        {
            get
            {
                return new Command(() =>
                {
                    HelloMessage = "Hello " + Name;
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
