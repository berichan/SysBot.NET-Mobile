using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SysBot.NET_Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditorPage : ContentPage
    {
        private string editorText;
        public string EditorText
        {
            get { return editorText; }
            set
            {
                editorText = value;
                OnPropertyChanged(nameof(EditorText)); // Notify that there was a change on this property
            }
        }

        private string filenameText;
        public string FilenameText
        {
            get { return filenameText; }
            set
            {
                filenameText = value;
                OnPropertyChanged(nameof(FilenameText));
            }
        }

        public EditorPage()
        {
            InitializeComponent();
        }
    }
}