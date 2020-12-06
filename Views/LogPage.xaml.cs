using SysBot.NET_Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SysBot.NET_Mobile.Views
{
    public partial class LogPage : ContentPage
    {
        private string logData;
        public string LogData
        {
            get { return logData; }
            set
            {
                logData = value;
                OnPropertyChanged(nameof(LogData)); // Notify that there was a change on this property
            }
        }

        public static LogPage LastInstance;

        public void UpdateLog(string line)
        {
            LogData += $"\r\n{line}";
        }

        public LogPage()
        {
            InitializeComponent();
            BindingContext = this;

            LogData = "Waiting for config..."; // It will be shown at your label
            LastInstance = this;
        }
    }
}