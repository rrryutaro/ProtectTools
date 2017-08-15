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
	class UITileSlot : UIItemSlot
	{
		public static Texture2D selectedBackgroundTexture = Main.inventoryBack15Texture;
		public static Texture2D recentlyDiscoveredBackgroundTexture = Main.inventoryBack10Texture;

        public UITileSlot(Item item, float scale = 0.75f) : base(item, scale)
		{
            enable = TileUtils.killItems[item.type];
        }

		public override void Click(UIMouseEvent evt)
		{
		}

        public override void RightClick(UIMouseEvent evt)
        {
            int itemType = item.type;
            TileUtils.killItems[itemType] = !TileUtils.killItems[itemType];
            enable = TileUtils.killItems[itemType];
        }

        public override void DoubleClick(UIMouseEvent evt)
		{
            //ChestBrowserUtils.Teleport(chest.x, chest.y);
		}

        protected override void DrawSelf(SpriteBatch spriteBatch)
        {
            base.DrawSelf(spriteBatch);
            if (IsMouseHovering)
            {
                ProtectTools.instance.tileWallTool.tooltip = item.Name;
            }
        }

    }
}
