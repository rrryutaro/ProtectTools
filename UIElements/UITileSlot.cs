using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.UI;

namespace ProtectTools.UIElements
{
	class UITileWallSlot : UIItemSlot
	{
		public static Texture2D selectedBackgroundTexture = Main.inventoryBack15Texture;
		public static Texture2D recentlyDiscoveredBackgroundTexture = Main.inventoryBack10Texture;

        public UITileWallSlot(Item item) : base(item)
		{
            enable = TileWallUI.killItems[item.type];
        }

        public override void RightClick(UIMouseEvent evt)
        {
            int itemType = item.type;
            TileWallUI.killItems[itemType] = !TileWallUI.killItems[itemType];
            enable = TileWallUI.killItems[itemType];
        }

        protected override void DrawSelf(SpriteBatch spriteBatch)
        {
            base.DrawSelf(spriteBatch);
            if (IsMouseHovering)
            {
                Tool.tooltip = item.Name;
               
            }
        }
    }
}
