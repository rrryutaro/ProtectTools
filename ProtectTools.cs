using System.Collections.Generic;
using Terraria;
using Terraria.UI;
using Terraria.ModLoader;

namespace ProtectTools
{
	class ProtectTools : Mod
	{
        internal static ProtectTools instance;
        internal ModHotKey HotKey;
        internal TileWallTool tileWallTool;

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
