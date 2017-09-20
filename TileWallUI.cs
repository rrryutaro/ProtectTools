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
using Terraria.ModLoader.IO;
using ProtectTools.UIElements;

namespace ProtectTools
{
	class TileWallUI : UIModState
	{
		static internal TileWallUI instance;

		internal UIDragablePanel panelMain;
        internal UISplitterPanel panelSplitter;
        internal UIPanel panelLeft;
        internal UIPanel panelRight;
        internal UIGrid gridLeft;
        internal UIGrid gridRight;
        internal UIHoverImageButton btnClose;
        internal UIImageListButton btnIconSize;
        internal UIImageListButton btnFilterNear;
        internal UIImageListButton btnShowTile;
        internal UIImageListButton btnShowWall;

        static internal int menuIconSize = 28;
        static internal int menuMargin = 4;

        internal bool updateNeeded;
        internal string caption = $"Protect Tools v{ProtectTools.instance.Version} Count:??";

        public static bool[] killItems = Enumerable.Repeat<bool>(true, ItemLoader.ItemCount).ToArray();

        internal bool showTiles;
        internal bool showWalls;

        public TileWallUI(UserInterface ui) : base(ui)
		{
			instance = this;

            showTiles = true;
            showWalls = true;
        }

        public void InitializeUI()
        {
            RemoveAllChildren();

            //メインパネル
            panelMain = new UIDragablePanel(true, true, true);
            panelMain.caption = caption;
            panelMain.SetPadding(6);
			panelMain.Left.Set(400f, 0f);
			panelMain.Top.Set(400f, 0f);
            panelMain.Width.Set(314f, 0f);
            panelMain.MinWidth.Set(314f, 0f);
            panelMain.MaxWidth.Set(1393f, 0f);
            panelMain.Height.Set(116f, 0f);
            panelMain.MinHeight.Set(116f, 0f);
            panelMain.MaxHeight.Set(1000f, 0f);
			Append(panelMain);

            //左パネル
            panelLeft = new UIPanel();
            panelLeft.SetPadding(6);
            panelLeft.MinWidth.Set(100, 0);
            gridLeft = new UIGrid();
            gridLeft.Width.Set(-20f, 1f);
            gridLeft.Height.Set(0, 1f);
            gridLeft.ListPadding = 2f;
            panelLeft.Append(gridLeft);
            var gridLeftScrollbar = new FixedUIScrollbar(userInterface);
            gridLeftScrollbar.SetView(100f, 1000f);
            gridLeftScrollbar.Height.Set(0, 1f);
            gridLeftScrollbar.Left.Set(-20, 1f);
            panelLeft.Append(gridLeftScrollbar);
            gridLeft.SetScrollbar(gridLeftScrollbar);
            //右パネル
            panelRight = new UIPanel();
            panelRight.SetPadding(6);
            panelRight.MinWidth.Set(100, 0);
            gridRight = new UIGrid();
            gridRight.Width.Set(-20f, 1f);
            gridRight.Height.Set(0, 1f);
            gridRight.ListPadding = 2f;
            panelRight.Append(gridRight);
            var chestGridScrollbar = new FixedUIScrollbar(userInterface);
            chestGridScrollbar.SetView(100f, 1000f);
            chestGridScrollbar.Height.Set(0, 1f);
            chestGridScrollbar.Left.Set(-20, 1f);
            panelRight.Append(chestGridScrollbar);
            gridRight.SetScrollbar(chestGridScrollbar);
            //スプリッターパネル
            panelSplitter = new UISplitterPanel(panelLeft, panelRight);
            panelSplitter.SetPadding(0);
            panelSplitter.Top.Pixels = menuIconSize + menuMargin * 2;
            panelSplitter.Width.Set(0, 1f);
            panelSplitter.Height.Set(-26 - menuIconSize, 1f);
            panelSplitter.Panel1Visible = false;
            panelMain.Append(panelSplitter);

            //閉じるボタン
            Texture2D texture = ProtectTools.instance.GetTexture("UIElements/closeButton");
            btnClose = new UIHoverImageButton(texture, "Close");
            btnClose.OnClick += (a, b) => ProtectTools.instance.tileWallTool.visible = false;
            btnClose.Left.Set(-20f, 1f);
            btnClose.Top.Set(3f, 0f);
            panelMain.Append(btnClose);

            UIItemSlot.defaultBackgroundTexture = UIItemSlot.defaultBackgroundTexture.Resize(32, 32);
            UIItemSlot.selectedBackgroundTexture = UIItemSlot.selectedBackgroundTexture.Resize(32, 32);

            //アイコンサイズボタン
            btnIconSize = new UIImageListButton(
                new List<Texture2D>() {
                    Main.itemTexture[ItemID.Chest].Resize(menuIconSize),
                    Main.itemTexture[ItemID.Chest].Resize((int)(menuIconSize * 0.8f)),
                    Main.itemTexture[ItemID.Chest].Resize((int)(menuIconSize * 0.6f))},
                new List<object>() { 1.0f, 0.8f, 0.6f },
                new List<string>() { "Icon size large", "Icon size medium", "Icon size small" });
            btnIconSize.OnClick += (a, b) =>
            {
                btnIconSize.NextIamge();
                UIItemSlot.scale = btnIconSize.GetValue<float>();
            };
            btnIconSize.Left.Set(btnClose.Left.Pixels - menuMargin - menuIconSize, 1f);
            btnIconSize.Top.Set(3f, 0f);
            panelMain.Append(btnIconSize);

            //タイル表示/非表示ボタン
            btnFilterNear = new UIImageListButton(
                new List<Texture2D>() { Main.itemTexture[ItemID.AlphabetStatueF].Resize(menuIconSize), Main.itemTexture[ItemID.AlphabetStatueF].Resize(menuIconSize) },
                new List<object>() { true, false },
                new List<string>() { "Filter near", "Filter none" });
            btnFilterNear.OnClick += (a, b) =>
            {
                btnFilterNear.NextIamge();
                updateNeeded = true;
            };
            btnFilterNear.Left.Set(menuMargin, 0f);
            btnFilterNear.Top.Set(3f, 0f);
            panelMain.Append(btnFilterNear);

            //タイル表示/非表示ボタン
            btnShowTile = new UIImageListButton(
                new List<Texture2D>() { Main.itemTexture[ItemID.DirtBlock].Resize(menuIconSize), Main.itemTexture[ItemID.DirtBlock].Resize(menuIconSize) },
                new List<object>() { true, false },
                new List<string>() { "Display Tiles", "Hide Tiles" });
            btnShowTile.OnClick += (a, b) =>
            {
                btnShowTile.NextIamge();
                showTiles = btnShowTile.GetValue<bool>();
                updateNeeded = true;
            };
            btnShowTile.Left.Set(btnFilterNear.Left.Pixels + menuIconSize + menuMargin, 0f);
            btnShowTile.Top.Set(3f, 0f);
            panelMain.Append(btnShowTile);

            //壁紙表示/非表示ボタン
            btnShowWall = new UIImageListButton(
                new List<Texture2D>() { Main.itemTexture[ItemID.WoodWall].Resize(menuIconSize), Main.itemTexture[ItemID.WoodWall].Resize(menuIconSize) },
                new List<object>() { true, false },
                new List<string>() { "Display Walls", "Hide Walls" });
            btnShowWall.OnClick += (a, b) =>
            {
                btnShowWall.NextIamge();
                showWalls = btnShowWall.GetValue<bool>();
                updateNeeded = true;
            };
            btnShowWall.Left.Set(btnShowTile.Left.Pixels + menuIconSize + menuMargin, 0f);
            btnShowWall.Top.Set(3f, 0f);
            panelMain.Append(btnShowWall);
        }

        private void showWallButtonClicked(UIMouseEvent evt, UIElement listeningElement)
        {
            showWalls = !showWalls;
            updateNeeded = true;
        }

        private void Clear()
        {
            gridLeft.Clear();
            gridRight.Clear();
            panelMain.DragTargetClear();
            panelSplitter.Recalculate();
        }

        internal void UpdateGrid()
		{
			if (!updateNeeded) { return; }
			updateNeeded = false;

            Clear();

            List<int> tiles;
            List<int> walls;

            if (btnFilterNear.GetValue<bool>())
            {
                List<int>[] lists = ProtectToolsUtils.GetScreenContainTilesAndWalls();
                tiles = lists[0];
                walls = lists[1];
            }
            else
            {
                tiles = TileUtils.GetAllTiles();
                walls = WallUtils.GetAllWalls();
            }

            if (showTiles)
            {
                foreach (var itemType in tiles)
                {
                    Item item = new Item();
                    item.SetDefaults(itemType);

                    var box = new UITileWallSlot(item);
                    gridRight._items.Add(box);
                    gridRight._innerList.Append(box);
                    panelMain.AddDragTarget(box);
                }
            }
            if (showWalls)
            {
                foreach (var itemType in walls)
                {
                    Item item = new Item();
                    item.SetDefaults(itemType);

                    var box = new UITileWallSlot(item);
                    gridRight._items.Add(box);
                    gridRight._innerList.Append(box);
                    panelMain.AddDragTarget(box);
                }
            }

            gridRight.UpdateOrder();
            gridRight._innerList.Recalculate();

            panelMain.caption = caption.Replace("??", $"{gridRight.Count}");
        }

		public override void Update(GameTime gameTime)
		{
			base.Update(gameTime);
			UpdateGrid();
		}

        public override TagCompound Save()
        {
            TagCompound result = base.Save();

            if (panelMain != null)
            {
                result.Add("position", panelMain.SavePositionJsonString());
                result.Add("SplitterBarLeft", panelSplitter.GetSplitterBarLeft());
                result.Add("killItems", string.Join(",", TileWallUI.killItems.Select(x => x ? 1 : 0)));
            
                result.Add("btnIconSize", btnIconSize.Index);
                result.Add("btnFilterNear", btnFilterNear.Index);
                result.Add("btnShowTile", btnShowTile.Index);
                result.Add("btnShowWall", btnShowWall.Index);
            }

            return result;
        }

        public override void Load(TagCompound tag)
        {
            base.Load(tag);

            if (tag.ContainsKey("position"))
            {
                panelMain.LoadPositionJsonString(tag.GetString("position"));
            }
            if (tag.ContainsKey("SplitterBarLeft"))
            {
                panelSplitter.SetSplitterBarLeft(tag.GetFloat("SplitterBarLeft"));
            }
            if (tag.ContainsKey("killItems"))
            {
                TileWallUI.killItems = tag.GetString("killItems").Split(',').Select(x => x.Equals("1") ? true : false).ToArray<bool>();
            }
            if (tag.ContainsKey("btnIconSize"))
            {
                btnIconSize.Index = tag.GetInt("btnIconSize");
                UIItemSlot.scale = btnIconSize.GetValue<float>();
            }
            if (tag.ContainsKey("btnFilterNear"))
            {
                btnFilterNear.Index = tag.GetInt("btnFilterNear");
            }
            if (tag.ContainsKey("btnShowTile"))
            {
                btnShowTile.Index = tag.GetInt("btnShowTile");
            }
            if (tag.ContainsKey("btnShowWall"))
            {
                btnShowWall.Index = tag.GetInt("btnShowWall");
            }
        }

    }
}
