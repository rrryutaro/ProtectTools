using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.UI;
using Terraria.ID;
using Terraria.GameContent.UI.Elements;
using Terraria.ModLoader;
using ProtectTools.UIElements;

namespace ProtectTools
{
	class TileWallUI : UIModState
	{
		static internal TileWallUI instance;

		internal UIDragablePanel mainPanel;
		internal UIPanel inlaidPanel;
		internal UIGrid grid;
        internal UIHoverImageButton closeButton;
        internal UIHoverImageButton showTileButton;
        internal UIHoverImageButton showWallButton;

        internal bool updateNeeded;
        internal string caption = "Protect Tools v0.0.1.0";

        public static bool[] killItems = Enumerable.Repeat<bool>(true, ItemLoader.ItemCount).ToArray();

        internal bool showTiles;
        internal bool showWalls;


        public TileWallUI(UserInterface ui) : base(ui)
		{
			instance = this;

            showTiles = true;
            showWalls = true;
        }

		public override void OnInitialize()
		{
			mainPanel = new UIDragablePanel(true, true, true);
            mainPanel.caption = caption;
            mainPanel.SetPadding(6);
			mainPanel.Left.Set(400f, 0f);
			mainPanel.Top.Set(400f, 0f);
            mainPanel.Width.Set(314f, 0f);
            mainPanel.MinWidth.Set(314f, 0f);
            mainPanel.MaxWidth.Set(1393f, 0f);
            mainPanel.Height.Set(116, 0f);
            mainPanel.MinHeight.Set(116, 0f);
            mainPanel.MaxHeight.Set(1000, 0f);
			Append(mainPanel);

            Texture2D texture = ProtectTools.instance.GetTexture("UIElements/closeButton");
            closeButton = new UIHoverImageButton(texture, "Close");
            closeButton.OnClick += CloseButtonClicked;
            closeButton.Left.Set(-20f, 1f);
            closeButton.Top.Set(3f, 0f);
            mainPanel.Append(closeButton);

            inlaidPanel = new UIPanel();
			inlaidPanel.SetPadding(6);
            inlaidPanel.Top.Pixels = 20;
            inlaidPanel.Width.Set(0, 1f);
            inlaidPanel.Height.Set(0 - 40, 1f);
            mainPanel.Append(inlaidPanel);

            UIItemSlot.defaultBackgroundTexture = UIItemSlot.defaultBackgroundTexture.Resize(32, 32);
            UIItemSlot.selectedBackgroundTexture = UIItemSlot.selectedBackgroundTexture.Resize(32, 32);

            grid = new UIGrid();
			grid.Width.Set(-20f, 1f); 
			grid.Height.Set(0, 1f);
			grid.ListPadding = 2f;
			inlaidPanel.Append(grid);

			var lootItemsScrollbar = new FixedUIScrollbar(userInterface);
			lootItemsScrollbar.SetView(100f, 1000f);
			lootItemsScrollbar.Height.Set(0, 1f);
			lootItemsScrollbar.Left.Set(-20, 1f);
			inlaidPanel.Append(lootItemsScrollbar);
			grid.SetScrollbar(lootItemsScrollbar);

            showTileButton = new UIHoverImageButton(Main.itemTexture[ItemID.DirtBlock].Resize(14, 14), "Show Tiles - on/off");
            showTileButton.OnClick += showTileButtonClicked;
            showTileButton.Left.Set(-40f, 1f);
            showTileButton.Top.Set(3f, 0f);
            mainPanel.Append(showTileButton);

            showWallButton = new UIHoverImageButton(Main.itemTexture[ItemID.WoodWall].Resize(14, 14), "Show Walls - on/off");
            showWallButton.OnClick += showWallButtonClicked;
            showWallButton.Left.Set(-60f, 1f);
            showWallButton.Top.Set(3f, 0f);
            mainPanel.Append(showWallButton);
        }

        private void CloseButtonClicked(UIMouseEvent evt, UIElement listeningElement)
		{
            ProtectTools.instance.tileWallTool.visible = !ProtectTools.instance.tileWallTool.visible;
        }
        private void showTileButtonClicked(UIMouseEvent evt, UIElement listeningElement)
        {
            showTiles = !showTiles;
            updateNeeded = true;
        }
        private void showWallButtonClicked(UIMouseEvent evt, UIElement listeningElement)
        {
            showWalls = !showWalls;
            updateNeeded = true;
        }

        internal void UpdateGrid()
		{
			if (!updateNeeded) { return; }
			updateNeeded = false;

            grid.Clear();
            mainPanel.DragTargetClear();
            mainPanel.AddDragTarget(inlaidPanel);
            mainPanel.AddDragTarget(grid);

            if (showTiles)
            {
                int[][] arrays =
                {
                    TileUtils.arrayItemBlock,
                    TileUtils.arrayItemOre,
                    TileUtils.arrayItemWood,
                    TileUtils.arrayItemBrick,
                    TileUtils.arrayItemJewelry,
                };

                foreach (var itemType in arrays.SelectMany(x => x).ToArray())
                {
                    Item item = new Item();
                    item.SetDefaults(itemType);

                    var box = new UITileWallSlot(item, 1f);
                    grid._items.Add(box);
                    grid._innerList.Append(box);
                    mainPanel.AddDragTarget(box);
                }
            }
            if (showWalls)
            {
                int[][] arrays =
                {
                    WallUtils.arrayItemEnvironmentWall,
                    WallUtils.arrayItemWoodWall,
                    WallUtils.arrayItemBrickWall,
                    WallUtils.arrayItemStuccoWall,
                    WallUtils.arrayItemOreWall,
                    WallUtils.arrayItemDungeonWall,
                    WallUtils.arrayItemGlassWall,
                    WallUtils.arrayItemFenceWall,
                    WallUtils.arrayItemOtherCraftWall,
                    WallUtils.arrayItemWallpaperWall,
                    WallUtils.arrayItemSellWall,
                };

                foreach (var itemType in arrays.SelectMany(x => x).ToArray())
                {
                    Item item = new Item();
                    item.SetDefaults(itemType);

                    var box = new UITileWallSlot(item, 1f);
                    grid._items.Add(box);
                    grid._innerList.Append(box);
                    mainPanel.AddDragTarget(box);
                }
            }

            grid.UpdateOrder();
			grid._innerList.Recalculate();

            mainPanel.caption = caption.Replace("??", $"{grid.Count}");
        }

		public override void Update(GameTime gameTime)
		{
			base.Update(gameTime);
			UpdateGrid();
		}

        private class SaveInfo
        {
            public string position;
            public string killItems;
            public bool? showTiles;
            public bool? showWalls;
        }
        public override string SaveJsonString()
        {
            string result = string.Empty;

            var info = new SaveInfo();
            info.position = mainPanel.SavePositionJsonString();
            info.killItems = string.Join(",", TileWallUI.killItems.Select(x => x ? 1 : 0));
            info.showTiles = showTiles;
            info.showWalls = showWalls;
            result = Newtonsoft.Json.JsonConvert.SerializeObject(info);
            return result;
        }
        public override void LoadJsonString(string jsonString)
        {
            if (!string.IsNullOrEmpty(jsonString))
            {
                var info = Newtonsoft.Json.JsonConvert.DeserializeObject<SaveInfo>(jsonString);
                if (info.position != null)
                    mainPanel.LoadPositionJsonString(info.position);
                if (info.killItems != null)
                    TileWallUI.killItems = info.killItems.Split(',').Select(x => x.Equals("1") ? true : false).ToArray<bool>();
                if (info.showTiles != null)
                    showTiles = (bool)info.showTiles;
                if (info.showWalls != null)
                    showWalls = (bool)info.showWalls;
            }
        }
    }
}
