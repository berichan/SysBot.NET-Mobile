using System;
using Xamarin.Forms;
using PKHeX.Core;
using SysBot.Base;
using SysBot.Pokemon;
using Newtonsoft.Json;
using System.IO;
using Xamarin.Essentials;

namespace SysBot.NET_Mobile.Views
{
    public partial class BotPage : ContentPage
    {
        private string configStatus;
        public string ConfigStatus
        {
            get { return configStatus; }
            set
            {
                configStatus = value;
                OnPropertyChanged(nameof(ConfigStatus)); // Notify that there was a change on this property
            }
        }

        private StackLayout stackLayout;
        private Button killButton;
        private EventHandler currentHandler = null;

        public BotPage()
        {
            InitializeComponent();
            BindingContext = this;
            ConfigStatus = "No config loaded.";

            stackLayout = new StackLayout
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            killButton = new Button
            {
                Text = "Stop all bots"
            };
            stackLayout.Children.Add(killButton);
            killButton.IsVisible = false;
            
            // test z3
            /*
            var HatBytes = Convert.FromBase64String(Hatterne_229B77A88B718ADD);
            PK8 pkm = new PK8(HatBytes);
            var ec = pkm.EncryptionConstant;
            var pid = pkm.PID;
            var IVs = PKX.ReorderSpeedLast((int[])pkm.IVs.Clone());
            var match = Z3Search.GetFirstSeed(ec, pid, IVs, SeedCheckResults.FirstStarAndSquare);
            Log(match.Seed.ToString("X"));
            */
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            var file = "";
            var log = LogPage.LastInstance;

            var pickResult = await FilePicker.PickAsync(new PickOptions
            {
                PickerTitle = "Select your config.json"
            }); 

            if (pickResult != null)
            {
                /*var stream = await pickResult.OpenReadAsync().ConfigureAwait(false);
                var bytes = new byte[stream.Length];
                await stream.ReadAsync(bytes, 0, (int)stream.Length).ConfigureAwait(false);*/

                file = pickResult.FullPath;
            }

            if (!file.ToLower().EndsWith(".json"))
            {
                Log("User attemped to load file that isn't a .json");
                ConfigStatus = "ERROR: File was not valid json.";
                return;
            }

            Log("Starting up...");
            PokeTradeBot.SeedChecker = new Z3SeedSearchHandler<PK8>();
            Directory.SetCurrentDirectory(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal));


            if (File.Exists(file))
            {
                var lines = File.ReadAllText(file);
                var prog = JsonConvert.DeserializeObject<ProgramConfig>(lines);
                var env = new PokeBotRunnerImpl(prog.Hub);

                foreach (var bot in prog.Bots)
                {
                    bot.Initialize();
                    if (!AddBot(env, bot))
                        Console.WriteLine($"Failed to add bot: {bot.IP}");
                }

                LogUtil.Forwarders.Add(Log);
                env.StartAll();
                Log("Started all bots.");
                ConfigStatus = "Bots started. Check logs.";

                // add kill button
                killButton.IsVisible = true;
                if (currentHandler != null)
                {
                    killButton.Clicked -= currentHandler;
                    currentHandler = null;
                }
                currentHandler = (a, b) => { env.StopAll(); killButton.IsVisible = false;};
                killButton.Clicked += currentHandler;
            }
            else
            {
                Log("Unable to parse config file. Please copy your config from the WinForms project.");
                ConfigStatus = "ERROR: File was not valid config.";
            }
        }

        private static bool AddBot(PokeBotRunner env, PokeBotConfig cfg)
        {
            if (!cfg.IsValidIP())
            {
                Log($"{cfg.IP}'s config is not valid.");
                return false;
            }

            var newbot = env.CreateBotFromConfig(cfg);
            try
            {
                env.Add(newbot);
            }
            catch (ArgumentException ex)
            {
                Log(ex.Message);
                return false;
            }

            Log($"Added: {cfg.IP}: {cfg.InitialRoutine}");
            return true;
        }

        private static void Log(string msg, string ident = "Program")
        {
            // Xamarin forms instance does not carry over when opening files for now
            var log = LogPage.LastInstance;
            try
            {
                log.UpdateLog($"\r\n{ident}: {msg}");
            }
            catch { };
        }

        private const string Hatterne_229B77A88B718ADD = "OPUOrgAAHK1aAwAAUKVA42AsAwCcABQAAAAAAEydXEEYGAQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACgUQAAAAAAAEgAYQB0AHQAZQByAGUAbgBlAAAAAAAAAAAAXQA+ArUCXQIZDxQKAAAAAAAAAAAAAAAAhwDu+/8/CAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAALAAAAAIAAAAAAP8AAAAAAAAAAAAAAAAAAABCAGUAcgByAHkAAAAAAAAAAAAAAAAAAAAAADIGUAA+Ag0AAAAUBxwAAACOAAk3AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAWNlOpxG6X7It3PKCmcvdg=";
    }
}