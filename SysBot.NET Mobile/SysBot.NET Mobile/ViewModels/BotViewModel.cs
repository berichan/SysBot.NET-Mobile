using System;
using System.IO;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using PKHeX.Core;
using SysBot.Base;
using SysBot.Pokemon;
using Newtonsoft.Json;

namespace SysBot.NET_Mobile.ViewModels
{
    public class BotViewModel : BaseViewModel
    {
        public BotViewModel()
        {
            Title = "Bot";
        }
    }
}