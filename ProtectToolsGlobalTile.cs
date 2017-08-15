﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace ProtectTools
{
    class ProtectToolsGlobalTile : GlobalTile
    {
        public override void KillTile(int i, int j, int type, ref bool fail, ref bool effectOnly, ref bool noItem)
        {
            if (Config.isProtect && !fail)
            {
                fail = TileUtils.isProtected(i, j);
            }
        }
        public override bool CreateDust(int i, int j, int type, ref int dustType)
        {
            bool result = true;
            if (Config.isProtect)
            {
                result = !TileUtils.isProtected(i, j);
            }
            return result;
        }
        public override bool KillSound(int i, int j, int type)
        {
            bool result = true;
            if (Config.isProtect)
            {
                result = !TileUtils.isProtected(i, j);
            }
            return result;
        }
    }
}
