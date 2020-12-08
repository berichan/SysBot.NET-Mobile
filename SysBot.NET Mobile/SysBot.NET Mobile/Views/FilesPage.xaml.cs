using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Acr.UserDialogs;
using PKHeX.Core;
using System.Threading.Tasks;

namespace SysBot.NET_Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilesPage : ContentPage
    {
        private string pk8List;
        public string PK8List
        {
            get { return pk8List; }
            set
            {
                pk8List = value;
                OnPropertyChanged(nameof(PK8List));
            }
        }

        private string wc8List;
        public string WC8List
        {
            get { return wc8List; }
            set
            {
                wc8List = value;
                OnPropertyChanged(nameof(WC8List));
            }
        }

        public FilesPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void RefreshFileLists()
        {
            var pk8Files = Directory.GetFiles(Helpers.SysBotFileHelper.DistributionPath);
            PK8List = string.Join("\r\n", pk8Files);

            var wc8Files = Directory.GetFiles(Helpers.SysBotFileHelper.MGDBPath);
            WC8List = string.Join("\r\n", wc8Files);
        }

        async void Button_Clicked_PK8(object sender, EventArgs e)
        {
            var pickResult = await FilePicker.PickAsync(new PickOptions
            {
                PickerTitle = "Select your PK8"
            });

            string file;
            if (pickResult != null)
                file = pickResult.FullPath;
            else
                return;

            await Task.Delay(500);

            if (!file.ToLower().EndsWith(".pk8"))
            {
                UserDialogs.Instance.Toast("ERROR: \r\nFile is not a PK8");
                return;
            }

            var bytes = File.ReadAllBytes(file);
            if (bytes.Length != 344)
            {
                UserDialogs.Instance.Toast("ERROR: \r\nPK8 is not the correct size");
                return;
            }

            File.WriteAllBytes(Path.Combine(Helpers.SysBotFileHelper.DistributionPath, Path.GetFileName(file)), bytes);
            RefreshFileLists();
        }

        async void Button_Clicked_WC8(object sender, EventArgs e)
        {
            var pickResult = await FilePicker.PickAsync(new PickOptions
            {
                PickerTitle = "Select your WC8"
            });

            string file;
            if (pickResult != null)
                file = pickResult.FullPath;
            else
                return;

            await Task.Delay(500);

            if (!file.ToLower().EndsWith(".wc8"))
            {
                UserDialogs.Instance.Toast("ERROR: \r\nFile is not a WC8");
                return;
            }

            var bytes = File.ReadAllBytes(file);
            File.WriteAllBytes(Path.Combine(Helpers.SysBotFileHelper.MGDBPath, Path.GetFileName(file)), bytes);
            RefreshFileLists();
        }

        void Button_Clicked_DeletePK8(object sender, EventArgs e)
        {

        }

        void Button_Clicked_DeleteWC8(object sender, EventArgs e)
        {

        }

    }
}