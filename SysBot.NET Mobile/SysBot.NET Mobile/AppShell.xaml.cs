using SysBot.NET_Mobile.ViewModels;
using SysBot.NET_Mobile.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SysBot.NET_Mobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(LogPage), typeof(LogPage));
            Routing.RegisterRoute(nameof(BotPage), typeof(BotPage));
        }

    }
}
