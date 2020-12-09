using System;
using Xamarin.Forms;
using PKHeX.Core;
using SysBot.Base;
using SysBot.Pokemon;
using Newtonsoft.Json;
using System.IO;
using Xamarin.Essentials;
using SysBot.NET_Mobile.Helpers;
using SysBot.AnimalCrossing;
using System.Threading;

namespace SysBot.NET_Mobile.Views
{
    public partial class BotPage : ContentPage
    {
        #region Bindings
        // Pokemon
        private string configStatus;
        public string ConfigStatus
        {
            get { return configStatus; }
            set
            {
                configStatus = value;
                OnPropertyChanged(nameof(ConfigStatus));
            }
        }

        private bool pkmConfigIdle = true;
        public bool PKMConfigIdle
        {
            get { return pkmConfigIdle; }
            set
            {
                pkmConfigIdle = value;
                OnPropertyChanged(nameof(PKMConfigIdle));
            }
        }
        // ACNH
        private string configStatusACNH;
        public string ConfigStatusACNH
        {
            get { return configStatusACNH; }
            set
            {
                configStatusACNH = value;
                OnPropertyChanged(nameof(ConfigStatusACNH));
            }
        }

        private bool acnhConfigIdle = true;
        public bool ACNHConfigIdle
        {
            get { return acnhConfigIdle; }
            set
            {
                acnhConfigIdle = value;
                OnPropertyChanged(nameof(ACNHConfigIdle));
            }
        }
        #endregion

        public BotPage()
        {
            InitializeComponent();
            BindingContext = this;
            ConfigStatus = "No PKM config loaded.";
            ConfigStatusACNH = "No ACNH config loaded";

            SysBotFileHelper.CreateDummyDlls();
            Directory.SetCurrentDirectory(SysBotFileHelper.WritablePath);

            // test z3 on android
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

            var pickResult = await FilePicker.PickAsync(new PickOptions
            {
                PickerTitle = "Select your config.json"
            }); 

            if (pickResult != null)
                file = pickResult.FullPath;

            if (!file.ToLower().EndsWith(".json"))
            {
                Log("User attemped to load file that isn't a .json");
                ConfigStatus = "ERROR: File was not valid json.";
                return;
            }

            Log("Starting up...");
            PokeTradeBot.SeedChecker = new Z3SeedSearchHandler<PK8>();


            if (File.Exists(file))
            {
                var lines = File.ReadAllText(file);
                var prog = JsonConvert.DeserializeObject<ProgramConfig>(lines);

                // Handle these manually
                prog.Hub.Folder.DistributeFolder = SysBotFileHelper.DistributionPath;
                prog.Hub.Legality.MGDBPath = SysBotFileHelper.MGDBPath;

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
                DeviceDisplay.KeepScreenOn = true;
                PKMConfigIdle = false;
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
                Log($"{cfg.IP}'s config is not valid. IP could not be validated.");
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

        async void Button_Clicked_ACNH(object sender, EventArgs e)
        {
            var file = "";

            var pickResult = await FilePicker.PickAsync(new PickOptions
            {
                PickerTitle = "Select your config.json"
            });

            if (pickResult != null)
                file = pickResult.FullPath;

            if (!file.ToLower().EndsWith(".json"))
            {
                Log("User attemped to load file that isn't a .json");
                ConfigStatus = "ERROR: File was not valid json.";
                return;
            }

            Log("Starting up...");

            if (File.Exists(file))
            {
                var lines = File.ReadAllText(file);
                var prog = JsonConvert.DeserializeObject<CrossBotConfig>(lines);

                LogUtil.Forwarders.Add(Log);
                Log("Started all bots.");
                ConfigStatus = "Bots started. Check logs.";
                DeviceDisplay.KeepScreenOn = true;
                ACNHConfigIdle = false;

                await BotRunner.RunFrom(prog, CancellationToken.None).ConfigureAwait(false);
            }
            else
            {
                Log("Unable to parse config file. Please copy your config from the Windows application directory.");
                ConfigStatusACNH = "ERROR: File was not valid config.";
            }
        }

        private static void Log(string msg, string ident = "Program")
        {
            // Xamarin forms view instance does not carry over when opening files for now
            var log = LogPage.LastInstance;
            try
            {
                log.UpdateLog($"{ident}: {msg}");
            }
            catch { };
        }

        private const string Hatterne_229B77A88B718ADD = "OPUOrgAAHK1aAwAAUKVA42AsAwCcABQAAAAAAEydXEEYGAQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACgUQAAAAAAAEgAYQB0AHQAZQByAGUAbgBlAAAAAAAAAAAAXQA+ArUCXQIZDxQKAAAAAAAAAAAAAAAAhwDu+/8/CAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAALAAAAAIAAAAAAP8AAAAAAAAAAAAAAAAAAABCAGUAcgByAHkAAAAAAAAAAAAAAAAAAAAAADIGUAA+Ag0AAAAUBxwAAACOAAk3AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAWNlOpxG6X7It3PKCmcvdg=";
    }
}