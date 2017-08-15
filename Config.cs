using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.IO;
using Terraria.ModLoader;
using Terraria.GameContent.UI.Chat;
using Terraria.ModLoader.IO;
using Terraria.UI;
using Terraria.UI.Chat;

namespace ProtectTools
{
    public static class Config
    {
        private static string ConfigPath = $@"{Main.SavePath}\Mod Configs\ProtectTools.json";
        private static Preferences config;
        private static int version = 1;
        public static void LoadConfig()
        {
            config = new Preferences(ConfigPath);

            if (config.Load())
            {
                config.Get("version", ref version);
                config.Get("isProtect", ref isProtect);
            }
            else
            {
                SaveValues();
            }
        }

        internal static void SaveValues()
        {
            config.Put("version", version);
            config.Put("isProtect", isProtect);
            config.Save();
        }

        public static bool isProtect = true;
    }
}
