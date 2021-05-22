using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ProtectTools
{
    [Label("Config")]
    public class ProtectToolsConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Label("Enable Protect Mode")]
        [DefaultValue(true)]
        public bool isProtect;
    }
}
