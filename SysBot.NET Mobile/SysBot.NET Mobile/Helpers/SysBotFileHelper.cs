using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SysBot.NET_Mobile.Helpers
{
    public class SysBotFileHelper
    {
        public static string WritablePath { get => Environment.GetFolderPath(Environment.SpecialFolder.Personal); }
        public static string MGDBPath { get
            {
                var mgdb = Path.Combine(WritablePath, "MGDB");
                if (!Directory.Exists(mgdb))
                    Directory.CreateDirectory(mgdb);
                return mgdb;
            } }

        public static string DistributionPath
        {
            get
            {
                var dist = Path.Combine(WritablePath, "Distribute");
                if (!Directory.Exists(dist))
                    Directory.CreateDirectory(dist);
                return dist;
            }
        }

        public static void CreateDummyDlls()
        {
            var dummyBytes = new byte[1];
            File.WriteAllBytes(Path.Combine(WritablePath, "PKHeX.Core.dll"), dummyBytes);
            File.WriteAllBytes(Path.Combine(WritablePath, "PKHeX.Core.AutoMod.dll"), dummyBytes);
        }
    }
}
