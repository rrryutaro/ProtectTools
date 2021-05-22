using System.IO;
using System.Collections.Generic;
using Terraria;
using Terraria.UI;
using Terraria.ModLoader;

namespace ProtectTools
{
    class ProtectTools : Mod
    {
        internal static string OldConfigFilePath = Path.Combine(Main.SavePath, "Mod Configs", "ProtectTools.json");
        internal static ProtectTools instance;
        internal ModHotKey HotKey;
        internal TileWallTool tileWallTool;

        public bool LoadedFKTModSettings = false;

        int lastSeenScreenWidth;
        int lastSeenScreenHeight;

        public ProtectTools()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }

        public override void Load()
        {
            instance = this;
            HotKey = RegisterHotKey("Toggle Protect Tool", "Y");
            if (!Main.dedServ)
            {
                // 旧設定ファイルの削除
                var oldConfigPath = Path.Combine(Main.SavePath, "Mod Configs", "TeraBackup.json"); ;
                if (File.Exists(oldConfigPath))
                {
                    File.Delete(oldConfigPath);
                }

                tileWallTool = new TileWallTool();
            }
        }

        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {

            int layerIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Interface Logic 1"));
            if (layerIndex != -1)
            {
                layers.Insert(layerIndex, new LegacyGameInterfaceLayer(
                    "Protect Tools: UI",
                    delegate
                    {
                        if (lastSeenScreenWidth != Main.screenWidth || lastSeenScreenHeight != Main.screenHeight)
                        {
                            tileWallTool.ScreenResolutionChanged();
                            lastSeenScreenWidth = Main.screenWidth;
                            lastSeenScreenHeight = Main.screenHeight;
                        }
                        tileWallTool.UIUpdate();
                        tileWallTool.UIDraw();

                        return true;
                    },
                    InterfaceScaleType.UI)
                );
            }

            layerIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));
            if (layerIndex != -1)
            {
                layers.Insert(layerIndex, new LegacyGameInterfaceLayer(
                    "Protect Tools: Tooltip",
                    delegate
                    {
                        tileWallTool.TooltipDraw();
                        return true;
                    },
                    InterfaceScaleType.UI)
                );
            }
        }
    }
}
