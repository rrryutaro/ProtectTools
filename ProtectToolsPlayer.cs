using Terraria;
using Terraria.GameInput;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace ProtectTools
{
    public class ProtectToolsPlayer : ModPlayer
    {
        private TagCompound saveData;

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
                ["TileWallUI"] = ProtectTools.instance.tileWallTool.uistate.Save(),
            };
        }

        public override void Load(TagCompound tag)
        {
            if (tag.ContainsKey("TileWallUI"))
            {
                if (tag.Get<object>("TileWallUI").GetType().Equals(typeof(TagCompound)))
                {
                    saveData = tag.Get<TagCompound>("TileWallUI");
                }
            }
        }

        public override void OnEnterWorld(Player player)
        {
            TileWallUI.instance.InitializeUI();
            if (saveData != null)
            {
                ProtectTools.instance.tileWallTool.uistate.Load(saveData);
            }
        }
    }
}
