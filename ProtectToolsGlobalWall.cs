using Terraria.ModLoader;

namespace ProtectTools
{
    class ProtectToolsGlobalWall : GlobalWall
    {
        public override void KillWall(int i, int j, int type, ref bool fail)
        {
            if (!fail)
            {
                fail = WallUtils.isProtected(i, j);
            }
        }
        public override bool CreateDust(int i, int j, int type, ref int dustType)
        {
            return !WallUtils.isProtected(i, j);
        }
        public override bool KillSound(int i, int j, int type)
        {
            return !WallUtils.isProtected(i, j);
        }
    }
}
