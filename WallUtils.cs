using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ProtectTools
{
    public static class WallUtils
    {
        public static List<int> GetAllWalls()
        {
            List<int> result = new List<int>();

            result.AddRange(arrayItemEnvironmentWall);
            result.AddRange(arrayItemWoodWall);
            result.AddRange(arrayItemBrickWall);
            result.AddRange(arrayItemStuccoWall);
            result.AddRange(arrayItemOreWall);
            result.AddRange(arrayItemDungeonWall);
            result.AddRange(arrayItemGlassWall);
            result.AddRange(arrayItemFenceWall);
            result.AddRange(arrayItemOtherCraftWall);
            result.AddRange(arrayItemWallpaperWall);
            result.AddRange(arrayItemSellWall);

            return result;
        }

        /// <summary>
        /// 環境背景壁
        /// </summary>
        public static int[] arrayItemEnvironmentWall =
        {
            ItemID.DirtWall,
            ItemID.StoneWall,
            ItemID.MarbleWall,
            ItemID.GraniteWall,
            ItemID.CloudWall,
            ItemID.HiveWall,
            ItemID.DiscWall,
            ItemID.SandstoneBrickWall,
            ItemID.LihzahrdBrickWall,
        };

        /// <summary>
        /// 木材背景壁
        /// </summary>
        public static int[] arrayItemWoodWall =
        {
            ItemID.WoodWall,
            ItemID.LivingWoodWall,
            ItemID.BorealWoodWall,
            ItemID.PalmWoodWall,
            ItemID.RichMahoganyWall,
            ItemID.EbonwoodWall,
            ItemID.ShadewoodWall,
            ItemID.PearlwoodWall,
            ItemID.WhiteDynastyWall,
            ItemID.BlueDynastyWall,
            ItemID.SpookyWoodWall,
        };

        /// <summary>
        /// レンガ背景壁
        /// </summary>
        public static int[] arrayItemBrickWall =
        {
            ItemID.GrayBrickWall,
            ItemID.RedBrickWall,
            ItemID.MudstoneBrickWall,
            ItemID.IridescentBrickWall,
            ItemID.SnowBrickWall,
            ItemID.IceBrickWall,
            ItemID.MarbleBlockWall,
            ItemID.GraniteBlockWall,
            ItemID.PearlstoneBrickWall,
            ItemID.EbonstoneBrickWall,
        };

        /// <summary>
        /// スタッコ背景壁
        /// </summary>
        public static int[] arrayItemStuccoWall =
        {
            ItemID.GrayStuccoWall,
            ItemID.RedStuccoWall,
            ItemID.YellowStuccoWall,
            ItemID.GreenStuccoWall,
        };

        /// <summary>
        /// 鉱石系背景壁
        /// </summary>
        public static int[] arrayItemOreWall =
        {
            ItemID.CopperBrickWall,
            ItemID.CopperPlatingWall,
            ItemID.TinBrickWall,
            ItemID.TinPlatingWall,
            ItemID.SilverBrickWall,
            ItemID.TungstenBrickWall,
            ItemID.GoldBrickWall,
            ItemID.PlatinumBrickWall,
            ItemID.DemoniteBrickWall,
            ItemID.CrimtaneBrickWall,
            ItemID.MeteoriteBrickWall,
            ItemID.ObsidianBrickWall,
            ItemID.HellstoneBrickWall,
            ItemID.CobaltBrickWall,
            ItemID.PalladiumColumnWall,
            ItemID.MythrilBrickWall,
            ItemID.BubblegumBlockWall,
            ItemID.AdamantiteBeamWall,
            ItemID.TitanstoneBlockWall,
            ItemID.ChlorophyteBrickWall,
            ItemID.ShroomitePlatingWall,
            ItemID.LunarBrickWall,
        };

        /// <summary>
        /// ダンジョン背景壁
        /// </summary>
        public static int[] arrayItemDungeonWall =
        {
            ItemID.BlueBrickWall,
            ItemID.BlueSlabWall,
            ItemID.BlueTiledWall,
            ItemID.GreenBrickWall,
            ItemID.GreenSlabWall,
            ItemID.GreenTiledWall,
            ItemID.PinkBrickWall,
            ItemID.PinkSlabWall,
            ItemID.PinkTiledWall,
        };

        /// <summary>
        /// ガラスブロック背景壁
        /// </summary>
        public static int[] arrayItemGlassWall =
        {
            ItemID.GrassWall,
            ItemID.PurpleStainedGlass,
            ItemID.YellowStainedGlass,
            ItemID.BlueStainedGlass,
            ItemID.GreenStainedGlass,
            ItemID.RedStainedGlass,
            ItemID.MulticoloredStainedGlass,
            ItemID.WaterfallWall,
            ItemID.LavafallWall,
            ItemID.HoneyfallWall,
            ItemID.SandFallWall,
            ItemID.SnowFallWall,
            ItemID.ConfettiWall,
            ItemID.ConfettiWallBlack,
            ItemID.AmethystGemsparkWall,
            ItemID.AmethystGemsparkWallOff,
            ItemID.TopazGemsparkWall,
            ItemID.TopazGemsparkWallOff,
            ItemID.SapphireGemsparkWall,
            ItemID.SapphireGemsparkWallOff,
            ItemID.EmeraldGemsparkWall,
            ItemID.EmeraldGemsparkWallOff,
            ItemID.RubyGemsparkWall,
            ItemID.RubyGemsparkWallOff,
            ItemID.DiamondGemsparkWall,
            ItemID.DiamondGemsparkWallOff,
            ItemID.AmberGemsparkWall,
            ItemID.AmberGemsparkWallOff,
        };

        /// <summary>
        /// フェンス背景壁
        /// </summary>
        public static int[] arrayItemFenceWall =
        {
            ItemID.WoodenFence,
            ItemID.RichMahoganyFence,
            ItemID.EbonwoodFence,
            ItemID.ShadewoodFence,
            ItemID.PearlwoodFence,
            ItemID.PalmWoodFence,
            ItemID.BorealWoodFence,
            ItemID.IronFence,
            ItemID.LeadFence,
        };

        /// <summary>
        /// その他クラフト背景壁
        /// </summary>
        public static int[] arrayItemOtherCraftWall =
        {
            ItemID.PlankedWall,
            ItemID.CactusWall,
            ItemID.MushroomWall,
            ItemID.PumpkinWall,
            ItemID.CogWall,
            ItemID.FleshBlockWall,
            ItemID.SlimeBlockWall,
            ItemID.RainbowBrickWall,
            ItemID.CandyCaneWall,
            ItemID.GreenCandyCaneWall,
            ItemID.BoneBlockWall,
            ItemID.MartianConduitWall,
            ItemID.StoneSlabWall,
            ItemID.LivingLeafWall,
            ItemID.CrystalBlockWall,
            ItemID.HayWall,
            ItemID.SillyBalloonPinkWall,
            ItemID.SillyBalloonPurpleWall,
            ItemID.SillyBalloonGreenWall,
        };

        /// <summary>
        /// 壁紙系背景壁
        /// </summary>
        public static int[] arrayItemWallpaperWall =
        {
            ItemID.BubbleWallpaper,
            ItemID.CopperPipeWallpaper,
            ItemID.DuckyWallpaper,
            ItemID.FancyGreyWallpaper,
            ItemID.IceFloeWallpaper,
            ItemID.MusicWallpaper,
            ItemID.PurpleRainWallpaper,
            ItemID.RainbowWallpaper,
            ItemID.SparkleStoneWallpaper,
            ItemID.StarlitHeavenWallpaper,
            ItemID.ChristmasTreeWallpaper,
            ItemID.CandyCaneWallpaper,
            ItemID.StarsWallpaper,
            ItemID.SnowflakeWallpaper,
            ItemID.BluegreenWallpaper,
            ItemID.OrnamentWallpaper,
            ItemID.FestiveWallpaper,
            ItemID.SquigglesWallpaper,
            ItemID.KrampusHornWallpaper,
            ItemID.GrinchFingerWallpaper,
        };

        /// <summary>
        /// 購入背景壁
        /// </summary>
        public static int[] arrayItemSellWall =
        {
            ItemID.ArcaneRuneWall,
            ItemID.Sail,
            ItemID.GlassWall,
            ItemID.FlowerWall,
            ItemID.JungleWall,
        };

        public static bool isProtected(int i, int j)
        {
            bool result = false;
            if (ModContent.GetInstance<ProtectToolsConfig>().isProtect)
            {
                int itemType = getKillDropItemType(Main.tile[i, j]);
                if (0 < itemType)
                {
                    result = !TileWallUI.killItems[itemType];
                }
            }
            return result;
        }

        public static int getKillDropItemType(Tile tile)
        {
            int result = 0;
            switch (tile.wall)
            {
                //石の壁
                case WallID.Stone:
                    result = ItemID.StoneWall;
                    break;
                //木の壁
                case WallID.Wood:
                    result = ItemID.WoodWall;
                    break;
                //レンガの壁（灰）
                case WallID.GrayBrick:
                    result = ItemID.GrayBrickWall;
                    break;
                //レンガの壁（赤）
                case WallID.RedBrick:
                    result = ItemID.RedBrickWall;
                    break;
                //レンガの壁（青）
                case WallID.BlueDungeonUnsafe:
                    result = ItemID.BlueBrickWall;
                    break;
                //レンガの壁（緑）
                case WallID.GreenDungeonUnsafe:
                    result = ItemID.GreenBrickWall;
                    break;
                //レンガの壁（桃）
                case WallID.PinkDungeonUnsafe:
                    result = ItemID.PinkBrickWall;
                    break;
                //レンガの壁（金）
                case WallID.GoldBrick:
                    result = ItemID.GoldBrickWall;
                    break;
                //レンガの壁（銀）
                case WallID.SilverBrick:
                    result = ItemID.SilverBrickWall;
                    break;
                //レンガの壁（銅）
                case WallID.CopperBrick:
                    result = ItemID.CopperBrickWall;
                    break;
                //黒曜石レンガの壁
                case WallID.ObsidianBrickUnsafe:
                    result = ItemID.ObsidianBrickWall;
                    break;
                //土の壁
                case WallID.Dirt:
                    result = ItemID.DirtWall;
                    break;
                //レンガの壁（青）
                case WallID.BlueDungeon:
                    result = ItemID.BlueBrickWall;
                    break;
                //レンガの壁（緑）
                case WallID.GreenDungeon:
                    result = ItemID.GreenBrickWall;
                    break;
                //レンガの壁（桃）
                case WallID.PinkDungeon:
                    result = ItemID.PinkBrickWall;
                    break;
                //黒曜石レンガの壁
                case WallID.ObsidianBrick:
                    result = ItemID.ObsidianBrickWall;
                    break;
                //ガラスの壁
                case WallID.Glass:
                    result = ItemID.GlassWall;
                    break;
                //パールストーンレンガの壁
                case WallID.PearlstoneBrick:
                    result = ItemID.PearlstoneBrickWall;
                    break;
                //光沢のあるレンガの壁
                case WallID.IridescentBrick:
                    result = ItemID.IridescentBrickWall;
                    break;
                //泥岩レンガの壁
                case WallID.MudstoneBrick:
                    result = ItemID.MudstoneBrickWall;
                    break;
                //コバルトレンガの壁
                case WallID.CobaltBrick:
                    result = ItemID.CobaltBrickWall;
                    break;
                //ミスリルレンガの壁
                case WallID.MythrilBrick:
                    result = ItemID.MythrilBrickWall;
                    break;
                //厚板の壁
                case WallID.Planked:
                    result = ItemID.PlankedWall;
                    break;
                //キャンディの壁
                case WallID.CandyCane:
                    result = ItemID.CandyCaneWall;
                    break;
                //キャンディの壁（緑）
                case WallID.GreenCandyCane:
                    result = ItemID.GreenCandyCaneWall;
                    break;
                //雪レンガの壁
                case WallID.SnowBrick:
                    result = ItemID.SnowBrickWall;
                    break;
                //アダマンタイト梁の壁
                case WallID.AdamantiteBeam:
                    result = ItemID.AdamantiteBeamWall;
                    break;
                //デモナイトレンガの壁
                case WallID.DemoniteBrick:
                    result = ItemID.DemoniteBrickWall;
                    break;
                //砂岩レンガの壁
                case WallID.SandstoneBrick:
                    result = ItemID.SandstoneBrickWall;
                    break;
                //エボンストーンレンガの壁
                case WallID.EbonstoneBrick:
                    result = ItemID.EbonstoneBrickWall;
                    break;
                //漆喰の壁（赤）
                case WallID.RedStucco:
                    result = ItemID.RedStuccoWall;
                    break;
                //漆喰の壁（黄）
                case WallID.YellowStucco:
                    result = ItemID.YellowStuccoWall;
                    break;
                //漆喰の壁（緑）
                case WallID.GreenStucco:
                    result = ItemID.GreenStuccoWall;
                    break;
                //漆喰の壁（灰）
                case WallID.Gray:
                    result = ItemID.GrayStuccoWall;
                    break;
                //エボンウッドの壁
                case WallID.Ebonwood:
                    result = ItemID.EbonwoodWall;
                    break;
                //マホガニーの壁
                case WallID.RichMaogany:
                    result = ItemID.RichMahoganyWall;
                    break;
                //パールウッドの壁
                case WallID.Pearlwood:
                    result = ItemID.PearlwoodWall;
                    break;
                //虹レンガの壁
                case WallID.RainbowBrick:
                    result = ItemID.RainbowBrickWall;
                    break;
                //錫レンガの壁
                case WallID.TinBrick:
                    result = ItemID.TinBrickWall;
                    break;
                //タングステンレンガの壁
                case WallID.TungstenBrick:
                    result = ItemID.TungstenBrickWall;
                    break;
                //プラチナレンガの壁
                case WallID.PlatinumBrick:
                    result = ItemID.PlatinumBrickWall;
                    break;
                //木の葉の壁
                case WallID.LivingLeaf:
                    result = ItemID.LivingLeafWall;
                    break;
                //草の壁
                case WallID.Grass:
                    result = ItemID.GrassWall;
                    break;
                //ジャングルの壁
                case WallID.Jungle:
                    result = ItemID.JungleWall;
                    break;
                //花の壁
                case WallID.Flower:
                    result = ItemID.FlowerWall;
                    break;
                //サボテンの壁
                case WallID.Cactus:
                    result = ItemID.CactusWall;
                    break;
                //雲の壁
                case WallID.Cloud:
                    result = ItemID.CloudWall;
                    break;
                //キノコの壁
                case WallID.Mushroom:
                    result = ItemID.MushroomWall;
                    break;
                //骨ブロックの壁
                case WallID.Bone:
                    result = ItemID.BoneBlockWall;
                    break;
                //スライムブロックの壁
                case WallID.Slime:
                    result = ItemID.SlimeBlockWall;
                    break;
                //肉ブロックの壁
                case WallID.Flesh:
                    result = ItemID.FleshBlockWall;
                    break;
                //リビングウッドウォール
                case WallID.LivingWood:
                    result = ItemID.LivingWoodWall;
                    break;
                //丸模様の壁
                case WallID.DiscWall:
                    result = ItemID.DiscWall;
                    break;
                //氷レンガの壁
                case WallID.IceBrick:
                    result = ItemID.IceBrickWall;
                    break;
                //シェイドウッドの壁
                case WallID.Shadewood:
                    result = ItemID.ShadewoodWall;
                    break;
                //蜂の巣の壁
                case WallID.HiveUnsafe:
                    result = ItemID.HiveWall;
                    break;
                //リザードレンガの壁
                case WallID.LihzahrdBrickUnsafe:
                    result = ItemID.LihzahrdBrickWall;
                    break;
                //ステンドグラス（紫）
                case WallID.PurpleStainedGlass:
                    result = ItemID.PurpleStainedGlass;
                    break;
                //ステンドグラス（黄）
                case WallID.YellowStainedGlass:
                    result = ItemID.YellowStainedGlass;
                    break;
                //ステンドグラス（青）
                case WallID.BlueStainedGlass:
                    result = ItemID.BlueStainedGlass;
                    break;
                //ステンドグラス（緑）
                case WallID.GreenStainedGlass:
                    result = ItemID.GreenStainedGlass;
                    break;
                //ステンドグラス（赤）
                case WallID.RedStainedGlass:
                    result = ItemID.RedStainedGlass;
                    break;
                //ステンドグラス（多色）
                case WallID.RainbowStainedGlass:
                    result = ItemID.MulticoloredStainedGlass;
                    break;
                //青平板の壁
                case WallID.BlueDungeonSlabUnsafe:
                    result = ItemID.BlueSlabWall;
                    break;
                //青タイルの壁
                case WallID.BlueDungeonTileUnsafe:
                    result = ItemID.BlueTiledWall;
                    break;
                //桃平板の壁
                case WallID.PinkDungeonSlabUnsafe:
                    result = ItemID.PinkSlabWall;
                    break;
                //桃タイルの壁
                case WallID.PinkDungeonTileUnsafe:
                    result = ItemID.PinkTiledWall;
                    break;
                //緑平板の壁
                case WallID.GreenDungeonSlabUnsafe:
                    result = ItemID.GreenSlabWall;
                    break;
                //緑タイルの壁
                case WallID.GreenDungeonTileUnsafe:
                    result = ItemID.GreenTiledWall;
                    break;
                //青平板の壁
                case WallID.BlueDungeonSlab:
                    result = ItemID.BlueSlabWall;
                    break;
                //青タイルの壁
                case WallID.BlueDungeonTile:
                    result = ItemID.BlueTiledWall;
                    break;
                //桃平板の壁
                case WallID.PinkDungeonSlab:
                    result = ItemID.PinkSlabWall;
                    break;
                //桃タイルの壁
                case WallID.PinkDungeonTile:
                    result = ItemID.PinkTiledWall;
                    break;
                //緑平板の壁
                case WallID.GreenDungeonSlab:
                    result = ItemID.GreenSlabWall;
                    break;
                //緑タイルの壁
                case WallID.GreenDungeonTile:
                    result = ItemID.GreenTiledWall;
                    break;
                //木のフェンス
                case WallID.WoodenFence:
                    result = ItemID.WoodenFence;
                    break;
                //鉛のフェンス
                case WallID.MetalFence:
                    result = ItemID.LeadFence;
                    break;
                //蜂の巣の壁
                case WallID.Hive:
                    result = ItemID.HiveWall;
                    break;
                //パラジウムの柱の壁
                case WallID.PalladiumColumn:
                    result = ItemID.PalladiumColumnWall;
                    break;
                //バブルガム・ブロックの壁
                case WallID.BubblegumBlock:
                    result = ItemID.BubblegumBlockWall;
                    break;
                //チタンストーンブロックの壁
                case WallID.TitanstoneBlock:
                    result = ItemID.TitanstoneBlockWall;
                    break;
                //リザードレンガの壁
                case WallID.LihzahrdBrick:
                    result = ItemID.LihzahrdBrickWall;
                    break;
                //カボチャの壁
                case WallID.Pumpkin:
                    result = ItemID.PumpkinWall;
                    break;
                //干し草の壁
                case WallID.Hay:
                    result = ItemID.HayWall;
                    break;
                //不気味な木の壁
                case WallID.SpookyWood:
                    result = ItemID.SpookyWoodWall;
                    break;
                //クリスマスツリーの壁紙
                case WallID.ChristmasTreeWallpaper:
                    result = ItemID.ChristmasTreeWallpaper;
                    break;
                //豪華な壁紙
                case WallID.OrnamentWallpaper:
                    result = ItemID.OrnamentWallpaper;
                    break;
                //キャンディステッキの壁紙
                case WallID.CandyCaneWallpaper:
                    result = ItemID.CandyCaneWallpaper;
                    break;
                //祝祭の壁紙
                case WallID.FestiveWallpaper:
                    result = ItemID.FestiveWallpaper;
                    break;
                //星の壁紙
                case WallID.StarsWallpaper:
                    result = ItemID.StarsWallpaper;
                    break;
                //波模様の壁紙
                case WallID.SquigglesWallpaper:
                    result = ItemID.SquigglesWallpaper;
                    break;
                //粉雪の壁紙
                case WallID.SnowflakeWallpaper:
                    result = ItemID.SnowflakeWallpaper;
                    break;
                //羊の角模様の壁紙
                case WallID.KrampusHornWallpaper:
                    result = ItemID.KrampusHornWallpaper;
                    break;
                //青緑の壁紙
                case WallID.BluegreenWallpaper:
                    result = ItemID.BluegreenWallpaper;
                    break;
                //グリンチフィンガーの壁紙
                case WallID.GrinchFingerWallpaper:
                    result = ItemID.GrinchFingerWallpaper;
                    break;
                //装飾的な灰色の壁紙
                case WallID.FancyGrayWallpaper:
                    result = ItemID.FancyGreyWallpaper;
                    break;
                //流氷の壁紙
                case WallID.IceFloeWallpaper:
                    result = ItemID.IceFloeWallpaper;
                    break;
                //音楽の壁紙
                case WallID.MusicWallpaper:
                    result = ItemID.MusicWallpaper;
                    break;
                //紫の雨壁紙
                case WallID.PurpleRainWallpaper:
                    result = ItemID.PurpleRainWallpaper;
                    break;
                //虹の壁紙
                case WallID.RainbowWallpaper:
                    result = ItemID.RainbowWallpaper;
                    break;
                //輝く石の壁紙
                case WallID.SparkleStoneWallpaper:
                    result = ItemID.SparkleStoneWallpaper;
                    break;
                //星明りの天国の壁紙
                case WallID.StarlitHeavenWallpaper:
                    result = ItemID.StarlitHeavenWallpaper;
                    break;
                //泡の壁紙
                case WallID.BubbleWallpaper:
                    result = ItemID.BubbleWallpaper;
                    break;
                //銅パイプの壁紙
                case WallID.CopperPipeWallpaper:
                    result = ItemID.CopperPipeWallpaper;
                    break;
                //かわいい壁紙
                case WallID.DuckyWallpaper:
                    result = ItemID.DuckyWallpaper;
                    break;
                //滝の壁
                case WallID.Waterfall:
                    result = ItemID.WaterfallWall;
                    break;
                //溶岩滝の壁
                case WallID.Lavafall:
                    result = ItemID.LavafallWall;
                    break;
                //エボンウッドのフェンス
                case WallID.EbonwoodFence:
                    result = ItemID.EbonwoodFence;
                    break;
                //マホガニーのフェンス
                case WallID.RichMahoganyFence:
                    result = ItemID.RichMahoganyFence;
                    break;
                //パールウッドのフェンス
                case WallID.PearlwoodFence:
                    result = ItemID.PearlwoodFence;
                    break;
                //シェイドウッドのフェンス
                case WallID.ShadewoodFence:
                    result = ItemID.ShadewoodFence;
                    break;
                //王朝風の壁（白）
                case WallID.WhiteDynasty:
                    result = ItemID.WhiteDynastyWall;
                    break;
                //王朝風の壁（青）
                case WallID.BlueDynasty:
                    result = ItemID.BlueDynastyWall;
                    break;
                //不可解な呪文の壁
                case WallID.ArcaneRunes:
                    result = ItemID.ArcaneRuneWall;
                    break;
                //鉄のフェンス
                case WallID.IronFence:
                    result = ItemID.IronFence;
                    break;
                //銅メッキの壁
                case WallID.CopperPlating:
                    result = ItemID.CopperPlatingWall;
                    break;
                //平石の壁
                case WallID.StoneSlab:
                    result = ItemID.StoneSlabWall;
                    break;
                //帆
                case WallID.Sail:
                    result = ItemID.Sail;
                    break;
                //ボーリアルウッドの壁
                case WallID.BorealWood:
                    result = ItemID.BorealWoodWall;
                    break;
                //ボーリアルウッドのフェンス
                case WallID.BorealWoodFence:
                    result = ItemID.BorealWoodFence;
                    break;
                //ヤシの木の壁
                case WallID.PalmWood:
                    result = ItemID.PalmWoodWall;
                    break;
                //ヤシの木のフェンス
                case WallID.PalmWoodFence:
                    result = ItemID.PalmWoodFence;
                    break;
                //発光壁（コハク）
                case WallID.AmberGemspark:
                    result = ItemID.AmberGemsparkWall;
                    break;
                //発光壁（アメジスト）
                case WallID.AmethystGemspark:
                    result = ItemID.AmethystGemsparkWall;
                    break;
                //発光壁（ダイヤ）
                case WallID.DiamondGemspark:
                    result = ItemID.DiamondGemsparkWall;
                    break;
                //発光壁（エメラルド）
                case WallID.EmeraldGemspark:
                    result = ItemID.EmeraldGemsparkWall;
                    break;
                //消えた発光壁（コハク）
                case WallID.AmberGemsparkOff:
                    result = ItemID.AmberGemsparkWallOff;
                    break;
                //消えた発光壁（アメジスト）
                case WallID.AmethystGemsparkOff:
                    result = ItemID.AmethystGemsparkWallOff;
                    break;
                //消えた発光壁（ダイヤ）
                case WallID.DiamondGemsparkOff:
                    result = ItemID.DiamondGemsparkWallOff;
                    break;
                //消えた発光壁（エメラルド）
                case WallID.EmeraldGemsparkOff:
                    result = ItemID.EmeraldGemsparkWallOff;
                    break;
                //消えた発光壁（ルビー）
                case WallID.RubyGemsparkOff:
                    result = ItemID.RubyGemsparkWallOff;
                    break;
                //消えた発光壁（サファイア）
                case WallID.SapphireGemsparkOff:
                    result = ItemID.SapphireGemsparkWallOff;
                    break;
                //消えた発光壁（トパーズ）
                case WallID.TopazGemsparkOff:
                    result = ItemID.TopazGemsparkWallOff;
                    break;
                //発光壁（ルビー）
                case WallID.RubyGemspark:
                    result = ItemID.RubyGemsparkWall;
                    break;
                //発光壁（サファイア）
                case WallID.SapphireGemspark:
                    result = ItemID.SapphireGemsparkWall;
                    break;
                //発光壁（トパーズ）
                case WallID.TopazGemspark:
                    result = ItemID.TopazGemsparkWall;
                    break;
                //錫メッキの壁
                case WallID.TinPlating:
                    result = ItemID.TinPlatingWall;
                    break;
                //紙吹雪の壁
                case WallID.Confetti:
                    result = ItemID.ConfettiWall;
                    break;
                //深夜の紙吹雪の壁
                case WallID.ConfettiBlack:
                    result = ItemID.ConfettiWallBlack;
                    break;
                //はちみつの壁
                case WallID.Honeyfall:
                    result = ItemID.HoneyfallWall;
                    break;
                //クロロファイトレンガの壁
                case WallID.ChlorophyteBrick:
                    result = ItemID.ChlorophyteBrickWall;
                    break;
                //クリムタンレンガの壁
                case WallID.CrimtaneBrick:
                    result = ItemID.CrimtaneBrickWall;
                    break;
                //シュルーマイトメッキの壁
                case WallID.ShroomitePlating:
                    result = ItemID.ShroomitePlatingWall;
                    break;
                //火星の導管壁
                case WallID.MartianConduit:
                    result = ItemID.MartianConduitWall;
                    break;
                //ヘルストーンレンガの壁
                case WallID.HellstoneBrick:
                    result = ItemID.HellstoneBrickWall;
                    break;
                //滑らかな大理石の壁
                case WallID.MarbleBlock:
                    result = ItemID.MarbleBlockWall;
                    break;
                //滑らかな御影石の壁
                case WallID.GraniteBlock:
                    result = ItemID.GraniteBlockWall;
                    break;
                //メテオライトレンガの壁
                case WallID.MeteoriteBrick:
                    result = ItemID.MeteoriteBrickWall;
                    break;
                //大理石の壁
                case WallID.Marble:
                    result = ItemID.MarbleWall;
                    break;
                //御影石の壁
                case WallID.Granite:
                    result = ItemID.GraniteWall;
                    break;
                //クリスタルブロックの壁
                case WallID.Crystal:
                    result = ItemID.CrystalBlockWall;
                    break;
                //ルミナイトレンガの壁
                case WallID.LunarBrickWall:
                    result = ItemID.LunarBrickWall;
                    break;
                //歯車の壁
                case WallID.CogWall:
                    result = ItemID.CogWall;
                    break;
                //砂滝の壁
                case WallID.SandFall:
                    result = ItemID.SandFallWall;
                    break;
                //降雪の壁
                case WallID.SnowFall:
                    result = ItemID.SnowFallWall;
                    break;
                //おめでたい風船の壁（桃）
                case WallID.SillyBalloonPinkWall:
                    result = ItemID.SillyBalloonPinkWall;
                    break;
                //おめでたい風船の壁（紫）
                case WallID.SillyBalloonPurpleWall:
                    result = ItemID.SillyBalloonPurpleWall;
                    break;
                //おめでたい風船の壁（緑）
                case WallID.SillyBalloonGreenWall:
                    result = ItemID.SillyBalloonGreenWall;
                    break;
                case WallID.None:
                    break;
                case WallID.DirtUnsafe:
                    break;
                case WallID.EbonstoneUnsafe:
                    break;
                case WallID.HellstoneBrickUnsafe:
                    break;
                case WallID.MudUnsafe:
                    break;
                case WallID.PearlstoneBrickUnsafe:
                    break;
                case WallID.SnowWallUnsafe:
                    break;
                case WallID.AmethystUnsafe:
                    break;
                case WallID.TopazUnsafe:
                    break;
                case WallID.SapphireUnsafe:
                    break;
                case WallID.EmeraldUnsafe:
                    break;
                case WallID.RubyUnsafe:
                    break;
                case WallID.DiamondUnsafe:
                    break;
                case WallID.CaveUnsafe:
                    break;
                case WallID.Cave2Unsafe:
                    break;
                case WallID.Cave3Unsafe:
                    break;
                case WallID.Cave4Unsafe:
                    break;
                case WallID.Cave5Unsafe:
                    break;
                case WallID.Cave6Unsafe:
                    break;
                case WallID.Cave7Unsafe:
                    break;
                case WallID.SpiderUnsafe:
                    break;
                case WallID.GrassUnsafe:
                    break;
                case WallID.JungleUnsafe:
                    break;
                case WallID.FlowerUnsafe:
                    break;
                case WallID.CorruptGrassUnsafe:
                    break;
                case WallID.HallowedGrassUnsafe:
                    break;
                case WallID.IceUnsafe:
                    break;
                case WallID.ObsidianBackUnsafe:
                    break;
                case WallID.MushroomUnsafe:
                    break;
                case WallID.CrimsonGrassUnsafe:
                    break;
                case WallID.CrimstoneUnsafe:
                    break;
                case WallID.CaveWall:
                    break;
                case WallID.CaveWall2:
                    break;
                case WallID.MarbleUnsafe:
                    break;
                case WallID.GraniteUnsafe:
                    break;
                case WallID.Cave8Unsafe:
                    break;
                case WallID.Sandstone:
                    break;
                case WallID.CorruptionUnsafe1:
                    break;
                case WallID.CorruptionUnsafe2:
                    break;
                case WallID.CorruptionUnsafe3:
                    break;
                case WallID.CorruptionUnsafe4:
                    break;
                case WallID.CrimsonUnsafe1:
                    break;
                case WallID.CrimsonUnsafe2:
                    break;
                case WallID.CrimsonUnsafe3:
                    break;
                case WallID.CrimsonUnsafe4:
                    break;
                case WallID.DirtUnsafe1:
                    break;
                case WallID.DirtUnsafe2:
                    break;
                case WallID.DirtUnsafe3:
                    break;
                case WallID.DirtUnsafe4:
                    break;
                case WallID.HallowUnsafe1:
                    break;
                case WallID.HallowUnsafe2:
                    break;
                case WallID.HallowUnsafe3:
                    break;
                case WallID.HallowUnsafe4:
                    break;
                case WallID.JungleUnsafe1:
                    break;
                case WallID.JungleUnsafe2:
                    break;
                case WallID.JungleUnsafe3:
                    break;
                case WallID.JungleUnsafe4:
                    break;
                case WallID.LavaUnsafe1:
                    break;
                case WallID.LavaUnsafe2:
                    break;
                case WallID.LavaUnsafe3:
                    break;
                case WallID.LavaUnsafe4:
                    break;
                case WallID.RocksUnsafe1:
                    break;
                case WallID.RocksUnsafe2:
                    break;
                case WallID.RocksUnsafe3:
                    break;
                case WallID.RocksUnsafe4:
                    break;
                case WallID.HardenedSand:
                    break;
                case WallID.CorruptHardenedSand:
                    break;
                case WallID.CrimsonHardenedSand:
                    break;
                case WallID.HallowHardenedSand:
                    break;
                case WallID.CorruptSandstone:
                    break;
                case WallID.CrimsonSandstone:
                    break;
                case WallID.HallowSandstone:
                    break;
                case WallID.DesertFossil:
                    break;
                case WallID.Count:
                    break;
            }
            return result;
        }
    }
}
