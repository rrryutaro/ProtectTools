using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace ProtectTools
{
    class ProtectToolsGlobalWall : GlobalWall
    {
        public override void KillWall(int i, int j, int type, ref bool fail)
        {
            if (Config.isProtect && !fail)
            {
                fail = WallUtils.isProtected(i, j);
            }
        }
        public override bool CreateDust(int i, int j, int type, ref int dustType)
        {
            bool result = true;
            if (Config.isProtect)
            {
                result = !WallUtils.isProtected(i, j);
            }
            return result;
        }
        public override bool KillSound(int i, int j, int type)
        {
            bool result = true;
            if (Config.isProtect)
            {
                result = !WallUtils.isProtected(i, j);
            }
            return result;
        }
    }
}
