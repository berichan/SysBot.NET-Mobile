using SysBot.NET_Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;
using System.Linq;

namespace SysBot.NET_Mobile.Views
{
    public partial class LogPage : ContentPage
    {
        private const int MaxCharCount = 3_000; // to stop app slugging

        private string logData;
        public string LogData
        {
            get { return logData; }
            set
            {
                logData = value;
                if (logData.Length > MaxCharCount)
                    logData = logData.Substring(logData.Length - MaxCharCount);
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

            LogData = "Waiting for config..."; 
            LastInstance = this;
        }
    }
}