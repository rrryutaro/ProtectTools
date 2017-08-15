using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.DataStructures;

namespace ProtectTools
{
	public class ProtectToolsPlayer : ModPlayer
	{
        private string saveInfoTileWallUI;

        public override void ProcessTriggers(TriggersSet triggersSet)
		{
			if (ProtectTools.instance.HotKey.JustPressed)
			{
                ProtectTools.instance.tileWallTool.visible = !ProtectTools.instance.tileWallTool.visible;
                if (ProtectTools.instance.tileWallTool.visible)
                    TileWallUI.instance.updateNeeded = true;
            }
        }

		public override TagCompound Save()
		{
            return new TagCompound
            {
                ["TileWallUI"] = ProtectTools.instance.tileWallTool.uistate.SaveJsonString(),
            };
        }

		public override void Load(TagCompound tag)
		{
            if (tag.ContainsKey("TileWallUI"))
            {
                saveInfoTileWallUI = tag.GetString("TileWallUI");
            }
		}

        public override void OnEnterWorld(Player player)
        {
            ProtectTools.instance.tileWallTool.uistate.LoadJsonString(saveInfoTileWallUI);
        }
    }
}
