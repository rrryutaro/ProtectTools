using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ProtectTools
{
    public static class TileUtils
    {
        /// <summary>
        /// ブロック系アイテム
        /// </summary>
        public static int[] arrayItemBlock =
        {
            ItemID.DirtBlock,
            ItemID.StoneBlock,
            ItemID.EbonstoneBlock,
            ItemID.ClayBlock,
            ItemID.SandBlock,
            ItemID.Obsidian,
            ItemID.AshBlock,
            ItemID.MudBlock,
            ItemID.EbonsandBlock,
            ItemID.PearlsandBlock,
            ItemID.PearlstoneBlock,
            ItemID.MudstoneBlock,
            ItemID.SiltBlock,
            ItemID.ActiveStoneBlock,
            ItemID.InactiveStoneBlock,
            ItemID.CandyCaneBlock,
            ItemID.GreenCandyCaneBlock,
            ItemID.SnowBlock,
            ItemID.IceBlock,
            ItemID.PurpleIceBlock,
            ItemID.PinkIceBlock,
            ItemID.SlimeBlock,
            ItemID.BoneBlock,
            ItemID.FleshBlock,
            ItemID.FrozenSlimeBlock,
            ItemID.AsphaltBlock,
            ItemID.RedIceBlock,
            ItemID.SunplateBlock,
            ItemID.CrimstoneBlock,
            ItemID.SlushBlock,
            ItemID.HoneyBlock,
            ItemID.CrispyHoneyBlock,
            ItemID.CrimsandBlock,
            ItemID.BubblegumBlock,
            ItemID.TitanstoneBlock,
            ItemID.Hay,
            ItemID.SmokeBlock,
            ItemID.MarbleBlock,
            ItemID.Marble,
            ItemID.Granite,
            ItemID.GraniteBlock,
            ItemID.PinkSlimeBlock,
            ItemID.Bubble,
            ItemID.CrystalBlock,
            ItemID.Sandstone,
            ItemID.HardenedSand,
            ItemID.CorruptHardenedSand,
            ItemID.CrimsonHardenedSand,
            ItemID.CorruptSandstone,
            ItemID.CrimsonSandstone,
            ItemID.HallowHardenedSand,
            ItemID.HallowSandstone,
            ItemID.DesertFossil,
            ItemID.FossilOre,
            ItemID.LunarBlockSolar,
            ItemID.LunarBlockVortex,
            ItemID.LunarBlockNebula,
            ItemID.LunarBlockStardust,
            ItemID.TeamBlockRed,
            ItemID.TeamBlockGreen,
            ItemID.TeamBlockBlue,
            ItemID.TeamBlockYellow,
            ItemID.TeamBlockPink,
            ItemID.TeamBlockWhite,
            ItemID.AmethystGemsparkBlock,
            ItemID.TopazGemsparkBlock,
            ItemID.SapphireGemsparkBlock,
            ItemID.EmeraldGemsparkBlock,
            ItemID.RubyGemsparkBlock,
            ItemID.DiamondGemsparkBlock,
            ItemID.AmberGemsparkBlock,
            ItemID.CoralstoneBlock,
            ItemID.WaterfallBlock,
            ItemID.LavafallBlock,
            ItemID.ConfettiBlock,
            ItemID.ConfettiBlockBlack,
            ItemID.LivingFireBlock,
            ItemID.LivingCursedFireBlock,
            ItemID.LivingDemonFireBlock,
            ItemID.LivingFrostFireBlock,
            ItemID.LivingIchorBlock,
            ItemID.LivingUltrabrightFireBlock,
            ItemID.HoneyfallBlock,
            ItemID.SandFallBlock,
            ItemID.SnowFallBlock,
            ItemID.SnowCloudBlock,
            ItemID.StoneSlab,
            ItemID.SandstoneSlab,
            ItemID.CopperPlating,
            ItemID.TinPlating,
            ItemID.ShroomitePlating,
            ItemID.MartianConduitPlating,
            ItemID.RedDynastyShingles,
            ItemID.BlueDynastyShingles,
            ItemID.AdamantiteBeam,
            ItemID.PalladiumColumn,
            ItemID.RedStucco,
            ItemID.YellowStucco,
            ItemID.GreenStucco,
            ItemID.GrayStucco,
            ItemID.Cloud,
            ItemID.RainCloud,
            ItemID.Glass,
            ItemID.Cactus,
            ItemID.Coral,
            ItemID.PineTreeBlock,
            ItemID.Cog,
        };

        /// <summary>
        /// 鉱石系アイテム
        /// </summary>
        public static int[] arrayItemOre =
        {
            ItemID.IronOre,
            ItemID.CopperOre,
            ItemID.GoldOre,
            ItemID.SilverOre,
            ItemID.DemoniteOre,
            ItemID.Meteorite,
            ItemID.Hellstone,
            ItemID.CobaltOre,
            ItemID.MythrilOre,
            ItemID.AdamantiteOre,
            ItemID.TinOre,
            ItemID.LeadOre,
            ItemID.TungstenOre,
            ItemID.PlatinumOre,
            ItemID.CrimtaneOre,
            ItemID.ChlorophyteOre,
            ItemID.PalladiumOre,
            ItemID.OrichalcumOre,
            ItemID.TitaniumOre,
            ItemID.LunarOre,
        };

        /// <summary>
        /// 木材系アイテム
        /// </summary>
        public static int[] arrayItemWood =
        {
            ItemID.Wood,
            ItemID.WoodenBeam,
            ItemID.Ebonwood,
            ItemID.RichMahogany,
            ItemID.Pearlwood,
            ItemID.Shadewood,
            ItemID.SpookyWood,
            ItemID.DynastyWood,
            ItemID.BorealWood,
            ItemID.PalmWood,
        };

        /// <summary>
        /// レンガ系アイテム
        /// </summary>
        public static int[] arrayItemBrick =
        {
            ItemID.GrayBrick,
            ItemID.RedBrick,
            ItemID.BlueBrick,
            ItemID.GreenBrick,
            ItemID.PinkBrick,
            ItemID.GoldBrick,
            ItemID.SilverBrick,
            ItemID.CopperBrick,
            ItemID.ObsidianBrick,
            ItemID.HellstoneBrick,
            ItemID.PearlstoneBrick,
            ItemID.IridescentBrick,
            ItemID.CobaltBrick,
            ItemID.MythrilBrick,
            ItemID.DemoniteBrick,
            ItemID.SnowBrick,
            ItemID.SandstoneBrick,
            ItemID.EbonstoneBrick,
            ItemID.RainbowBrick,
            ItemID.TinBrick,
            ItemID.TungstenBrick,
            ItemID.PlatinumBrick,
            ItemID.IceBrick,
            ItemID.LihzahrdBrick,
            ItemID.ChlorophyteBrick,
            ItemID.CrimtaneBrick,
            ItemID.MeteoriteBrick,
            ItemID.LunarBrick
        };

        /// <summary>
        /// 宝石系アイテム
        /// </summary>
        public static int[] arrayItemJewelry =
        {
            ItemID.Sapphire,
            ItemID.Ruby,
            ItemID.Emerald,
            ItemID.Topaz,
            ItemID.Amethyst,
            ItemID.Diamond,
            ItemID.CrystalShard,
        };

        public static bool[] killItems = Enumerable.Repeat<bool>(true, ItemLoader.ItemCount).ToArray();

        public static bool isProtected(int i, int j)
        {
            bool result = false;
            int itemType = TileUtils.getKillDropItemType(Main.tile[i, j]);
            if (0 < itemType)
            {
                result = !TileUtils.killItems[itemType];
            }
            return result;
        }

        public static int getKillDropItemType(Tile tile)
        {
            int result = 0;
            switch (tile.type)
            {
                //土のブロック
                case TileID.Dirt:
                    result = ItemID.DirtBlock;
                    break;
                //石のブロック
                case TileID.Stone:
                    result = ItemID.StoneBlock;
                    break;
                //土のブロック
                case TileID.Grass:
                    result = ItemID.DirtBlock;
                    break;
                //鉄鉱石
                case TileID.Iron:
                    result = ItemID.IronOre;
                    break;
                //銅鉱石
                case TileID.Copper:
                    result = ItemID.CopperOre;
                    break;
                //金鉱石
                case TileID.Gold:
                    result = ItemID.GoldOre;
                    break;
                //銀鉱石
                case TileID.Silver:
                    result = ItemID.SilverOre;
                    break;
                //デモナイト鉱石
                case TileID.Demonite:
                    result = ItemID.DemoniteOre;
                    break;
                //土のブロック
                case TileID.CorruptGrass:
                    result = ItemID.DirtBlock;
                    break;
                //エボンストーンのブロック
                case TileID.Ebonstone:
                    result = ItemID.EbonstoneBlock;
                    break;
                //木
                case TileID.WoodBlock:
                    result = ItemID.Wood;
                    break;
                //プレゼント
                case TileID.Presents:
                    result = ItemID.Present;
                    break;
                //メテオライト鉱石
                case TileID.Meteorite:
                    result = ItemID.Meteorite;
                    break;
                //レンガ（灰）
                case TileID.GrayBrick:
                    result = ItemID.GrayBrick;
                    break;
                //レンガ（赤）
                case TileID.RedBrick:
                    result = ItemID.RedBrick;
                    break;
                //粘土のブロック
                case TileID.ClayBlock:
                    result = ItemID.ClayBlock;
                    break;
                //レンガ（青）
                case TileID.BlueDungeonBrick:
                    result = ItemID.BlueBrick;
                    break;
                //レンガ（緑）
                case TileID.GreenDungeonBrick:
                    result = ItemID.GreenBrick;
                    break;
                //レンガ（桃）
                case TileID.PinkDungeonBrick:
                    result = ItemID.PinkBrick;
                    break;
                //レンガ（金）
                case TileID.GoldBrick:
                    result = ItemID.GoldBrick;
                    break;
                //レンガ（銀）
                case TileID.SilverBrick:
                    result = ItemID.SilverBrick;
                    break;
                //レンガ（銅）
                case TileID.CopperBrick:
                    result = ItemID.CopperBrick;
                    break;
                //トゲ
                case TileID.Spikes:
                    result = ItemID.Spike;
                    break;
                //水の蝋燭
                case TileID.WaterCandle:
                    result = ItemID.WaterCandle;
                    break;
                //本
                case TileID.Books:
                    result = ItemID.Book;
                    break;
                //クモの巣
                case TileID.Cobweb:
                    result = ItemID.Cobweb;
                    break;
                //砂のブロック
                case TileID.Sand:
                    result = ItemID.SandBlock;
                    break;
                //ガラス
                case TileID.Glass:
                    result = ItemID.Glass;
                    break;
                //黒曜石
                case TileID.Obsidian:
                    result = ItemID.Obsidian;
                    break;
                //灰のブロック
                case TileID.Ash:
                    result = ItemID.AshBlock;
                    break;
                //ヘルストーン鉱石
                case TileID.Hellstone:
                    result = ItemID.Hellstone;
                    break;
                //泥のブロック
                case TileID.Mud:
                    result = ItemID.MudBlock;
                    break;
                //泥のブロック
                case TileID.JungleGrass:
                    result = ItemID.MudBlock;
                    break;
                //サファイア
                case TileID.Sapphire:
                    result = ItemID.Sapphire;
                    break;
                //ルビー
                case TileID.Ruby:
                    result = ItemID.Ruby;
                    break;
                //エメラルド
                case TileID.Emerald:
                    result = ItemID.Emerald;
                    break;
                //トパーズ
                case TileID.Topaz:
                    result = ItemID.Topaz;
                    break;
                //アメジスト
                case TileID.Amethyst:
                    result = ItemID.Amethyst;
                    break;
                //ダイヤモンド
                case TileID.Diamond:
                    result = ItemID.Diamond;
                    break;
                //泥のブロック
                case TileID.MushroomGrass:
                    result = ItemID.MudBlock;
                    break;
                //黒曜石のレンガ
                case TileID.ObsidianBrick:
                    result = ItemID.ObsidianBrick;
                    break;
                //ヘルストーンのレンガ
                case TileID.HellstoneBrick:
                    result = ItemID.HellstoneBrick;
                    break;
                //鉢
                case TileID.ClayPot:
                    result = ItemID.ClayPot;
                    break;
                //サボテン
                case TileID.Cactus:
                    result = ItemID.Cactus;
                    break;
                //サンゴ
                case TileID.Coral:
                    result = ItemID.Coral;
                    break;
                //コバルト鉱石
                case TileID.Cobalt:
                    result = ItemID.CobaltOre;
                    break;
                //ミスリル鉱石
                case TileID.Mythril:
                    result = ItemID.MythrilOre;
                    break;
                //土のブロック
                case TileID.HallowedGrass:
                    result = ItemID.DirtBlock;
                    break;
                //アダマンタイト鉱石
                case TileID.Adamantite:
                    result = ItemID.AdamantiteOre;
                    break;
                //穢れた砂のブロック
                case TileID.Ebonsand:
                    result = ItemID.EbonsandBlock;
                    break;
                //パールサンドのブロック
                case TileID.Pearlsand:
                    result = ItemID.PearlsandBlock;
                    break;
                //パールストーンのブロック
                case TileID.Pearlstone:
                    result = ItemID.PearlstoneBlock;
                    break;
                //パールストーンのレンガ
                case TileID.PearlstoneBrick:
                    result = ItemID.PearlstoneBrick;
                    break;
                //光沢のあるレンガ
                case TileID.IridescentBrick:
                    result = ItemID.IridescentBrick;
                    break;
                //泥岩のブロック
                case TileID.Mudstone:
                    result = ItemID.MudstoneBlock;
                    break;
                //コバルトのレンガ
                case TileID.CobaltBrick:
                    result = ItemID.CobaltBrick;
                    break;
                //ミスリルのレンガ
                case TileID.MythrilBrick:
                    result = ItemID.MythrilBrick;
                    break;
                //沈泥のブロック
                case TileID.Silt:
                    result = ItemID.SiltBlock;
                    break;
                //木の梁
                case TileID.WoodenBeam:
                    result = ItemID.WoodenBeam;
                    break;
                //クリスタルの欠片
                case TileID.Crystals:
                    result = ItemID.CrystalShard;
                    break;
                //石ブロック（ON）
                case TileID.ActiveStoneBlock:
                    result = ItemID.ActiveStoneBlock;
                    break;
                //石ブロック（OFF）
                case TileID.InactiveStoneBlock:
                    result = ItemID.InactiveStoneBlock;
                    break;
                //スイッチ
                case TileID.Switches:
                    result = ItemID.Switch;
                    break;
                //デモナイトのレンガ
                case TileID.DemoniteBrick:
                    result = ItemID.DemoniteBrick;
                    break;
                //爆発物
                case TileID.Explosives:
                    result = ItemID.Explosives;
                    break;
                //キャンディのブロック
                case TileID.CandyCaneBlock:
                    result = ItemID.CandyCaneBlock;
                    break;
                //キャンディのブロック（緑）
                case TileID.GreenCandyCaneBlock:
                    result = ItemID.GreenCandyCaneBlock;
                    break;
                //雪のブロック
                case TileID.SnowBlock:
                    result = ItemID.SnowBlock;
                    break;
                //雪のレンガ
                case TileID.SnowBrick:
                    result = ItemID.SnowBrick;
                    break;
                //アダマンタイトの梁
                case TileID.AdamantiteBeam:
                    result = ItemID.AdamantiteBeam;
                    break;
                //砂岩のレンガ
                case TileID.SandstoneBrick:
                    result = ItemID.SandstoneBrick;
                    break;
                //エボンストーンのレンガ
                case TileID.EbonstoneBrick:
                    result = ItemID.EbonstoneBrick;
                    break;
                //漆喰（赤）
                case TileID.RedStucco:
                    result = ItemID.RedStucco;
                    break;
                //漆喰（黄）
                case TileID.YellowStucco:
                    result = ItemID.YellowStucco;
                    break;
                //漆喰（緑）
                case TileID.GreenStucco:
                    result = ItemID.GreenStucco;
                    break;
                //漆喰（灰）
                case TileID.GrayStucco:
                    result = ItemID.GrayStucco;
                    break;
                //エボンウッド
                case TileID.Ebonwood:
                    result = ItemID.Ebonwood;
                    break;
                //マホガニー
                case TileID.RichMahogany:
                    result = ItemID.RichMahogany;
                    break;
                //パールウッド
                case TileID.Pearlwood:
                    result = ItemID.Pearlwood;
                    break;
                //虹のレンガ
                case TileID.RainbowBrick:
                    result = ItemID.RainbowBrick;
                    break;
                //氷ブロック
                case TileID.IceBlock:
                    result = ItemID.IceBlock;
                    break;
                //氷ブロック（紫）
                case TileID.CorruptIce:
                    result = ItemID.PurpleIceBlock;
                    break;
                //氷ブロック（桃）
                case TileID.HallowedIce:
                    result = ItemID.PinkIceBlock;
                    break;
                //錫鉱石
                case TileID.Tin:
                    result = ItemID.TinOre;
                    break;
                //鉛鉱石
                case TileID.Lead:
                    result = ItemID.LeadOre;
                    break;
                //タングステン鉱石
                case TileID.Tungsten:
                    result = ItemID.TungstenOre;
                    break;
                //プラチナ鉱石
                case TileID.Platinum:
                    result = ItemID.PlatinumOre;
                    break;
                //パインツリーブロック
                case TileID.PineTree:
                    result = ItemID.PineTreeBlock;
                    break;
                //プラチナの蝋燭
                case TileID.PlatinumCandle:
                    result = ItemID.PlatinumCandle;
                    break;
                //錫のレンガ
                case TileID.TinBrick:
                    result = ItemID.TinBrick;
                    break;
                //タングステンのレンガ
                case TileID.TungstenBrick:
                    result = ItemID.TungstenBrick;
                    break;
                //プラチナのレンガ
                case TileID.PlatinumBrick:
                    result = ItemID.PlatinumBrick;
                    break;
                //サボテン
                case TileID.CactusBlock:
                    result = ItemID.Cactus;
                    break;
                //雲
                case TileID.Cloud:
                    result = ItemID.Cloud;
                    break;
                //光るキノコ
                case TileID.MushroomBlock:
                    result = ItemID.GlowingMushroom;
                    break;
                //木
                case TileID.LivingWood:
                    result = ItemID.Wood;
                    break;
                //スライムブロック
                case TileID.SlimeBlock:
                    result = ItemID.SlimeBlock;
                    break;
                //骨のブロック
                case TileID.BoneBlock:
                    result = ItemID.BoneBlock;
                    break;
                //肉のブロック
                case TileID.FleshBlock:
                    result = ItemID.FleshBlock;
                    break;
                //雨雲
                case TileID.RainCloud:
                    result = ItemID.RainCloud;
                    break;
                //凍ったスライムのブロック
                case TileID.FrozenSlimeBlock:
                    result = ItemID.FrozenSlimeBlock;
                    break;
                //アスファルトのブロック
                case TileID.Asphalt:
                    result = ItemID.AsphaltBlock;
                    break;
                //氷ブロック（赤）
                case TileID.FleshIce:
                    result = ItemID.RedIceBlock;
                    break;
                //太陽のブロック
                case TileID.Sunplate:
                    result = ItemID.SunplateBlock;
                    break;
                //紅石のブロック
                case TileID.Crimstone:
                    result = ItemID.CrimstoneBlock;
                    break;
                //クリムタン鉱石
                case TileID.Crimtane:
                    result = ItemID.CrimtaneOre;
                    break;
                //氷のレンガ
                case TileID.IceBrick:
                    result = ItemID.IceBrick;
                    break;
                //シェイドウッド
                case TileID.Shadewood:
                    result = ItemID.Shadewood;
                    break;
                //地雷
                case TileID.LandMine:
                    result = ItemID.LandMine;
                    break;
                //クロロファイト鉱石
                case TileID.Chlorophyte:
                    result = ItemID.ChlorophyteOre;
                    break;
                //ロープ
                case TileID.Rope:
                    result = ItemID.Rope;
                    break;
                //鉄の鎖
                case TileID.Chain:
                    result = ItemID.Chain;
                    break;
                //パラジウム鉱石
                case TileID.Palladium:
                    result = ItemID.PalladiumOre;
                    break;
                //オリハルコン鉱石
                case TileID.Orichalcum:
                    result = ItemID.OrichalcumOre;
                    break;
                //チタン鉱石
                case TileID.Titanium:
                    result = ItemID.TitaniumOre;
                    break;
                //水雪ブロック
                case TileID.Slush:
                    result = ItemID.SlushBlock;
                    break;
                //リザードのレンガ
                case TileID.LihzahrdBrick:
                    result = ItemID.LihzahrdBrick;
                    break;
                //蜂蜜ブロック
                case TileID.HoneyBlock:
                    result = ItemID.HoneyBlock;
                    break;
                //焼けた蜂蜜ブロック
                case TileID.CrispyHoneyBlock:
                    result = ItemID.CrispyHoneyBlock;
                    break;
                //木のトゲ
                case TileID.WoodenSpikes:
                    result = ItemID.WoodenSpike;
                    break;
                //紅砂のブロック
                case TileID.Crimsand:
                    result = ItemID.CrimsandBlock;
                    break;
                //パラジウムの柱
                case TileID.PalladiumColumn:
                    result = ItemID.PalladiumColumn;
                    break;
                //バブルガム・ブロック
                case TileID.BubblegumBlock:
                    result = ItemID.BubblegumBlock;
                    break;
                //チタンストーンブロック
                case TileID.Titanstone:
                    result = ItemID.TitanstoneBlock;
                    break;
                //カボチャ
                case TileID.PumpkinBlock:
                    result = ItemID.Pumpkin;
                    break;
                //干し草
                case TileID.HayBlock:
                    result = ItemID.Hay;
                    break;
                //不気味な木
                case TileID.SpookyWood:
                    result = ItemID.SpookyWood;
                    break;
                //発光ブロック（アメジスト）
                case TileID.AmethystGemsparkOff:
                    result = ItemID.AmethystGemsparkBlock;
                    break;
                //発光ブロック（トパーズ）
                case TileID.TopazGemsparkOff:
                    result = ItemID.TopazGemsparkBlock;
                    break;
                //発光ブロック（サファイヤ）
                case TileID.SapphireGemsparkOff:
                    result = ItemID.SapphireGemsparkBlock;
                    break;
                //発光ブロック（エメラルド）
                case TileID.EmeraldGemsparkOff:
                    result = ItemID.EmeraldGemsparkBlock;
                    break;
                //発光ブロック（ルビー）
                case TileID.RubyGemsparkOff:
                    result = ItemID.RubyGemsparkBlock;
                    break;
                //発光ブロック（ダイヤ）
                case TileID.DiamondGemsparkOff:
                    result = ItemID.DiamondGemsparkBlock;
                    break;
                //発光ブロック（コハク）
                case TileID.AmberGemsparkOff:
                    result = ItemID.AmberGemsparkBlock;
                    break;
                //発光ブロック（アメジスト）
                case TileID.AmethystGemspark:
                    result = ItemID.AmethystGemsparkBlock;
                    break;
                //発光ブロック（トパーズ）
                case TileID.TopazGemspark:
                    result = ItemID.TopazGemsparkBlock;
                    break;
                //発光ブロック（サファイヤ）
                case TileID.SapphireGemspark:
                    result = ItemID.SapphireGemsparkBlock;
                    break;
                //発光ブロック（エメラルド）
                case TileID.EmeraldGemspark:
                    result = ItemID.EmeraldGemsparkBlock;
                    break;
                //発光ブロック（ルビー）
                case TileID.RubyGemspark:
                    result = ItemID.RubyGemsparkBlock;
                    break;
                //発光ブロック（ダイヤ）
                case TileID.DiamondGemspark:
                    result = ItemID.DiamondGemsparkBlock;
                    break;
                //発光ブロック（コハク）
                case TileID.AmberGemspark:
                    result = ItemID.AmberGemsparkBlock;
                    break;
                //歯車
                case TileID.Cog:
                    result = ItemID.Cog;
                    break;
                //平石
                case TileID.StoneSlab:
                    result = ItemID.StoneSlab;
                    break;
                //平砂石
                case TileID.SandStoneSlab:
                    result = ItemID.SandstoneSlab;
                    break;
                //銅メッキ
                case TileID.CopperPlating:
                    result = ItemID.CopperPlating;
                    break;
                //王朝風の木
                case TileID.DynastyWood:
                    result = ItemID.DynastyWood;
                    break;
                //王朝風の板（赤）
                case TileID.RedDynastyShingles:
                    result = ItemID.RedDynastyShingles;
                    break;
                //王朝風の板（青）
                case TileID.BlueDynastyShingles:
                    result = ItemID.BlueDynastyShingles;
                    break;
                //サンゴ石のブロック
                case TileID.Coralstone:
                    result = ItemID.CoralstoneBlock;
                    break;
                //ボーリアルウッド
                case TileID.BorealWood:
                    result = ItemID.BorealWood;
                    break;
                //ヤシの木
                case TileID.PalmWood:
                    result = ItemID.PalmWood;
                    break;
                //錫メッキ
                case TileID.TinPlating:
                    result = ItemID.TinPlating;
                    break;
                //滝のブロック
                case TileID.Waterfall:
                    result = ItemID.WaterfallBlock;
                    break;
                //溶岩滝のブロック
                case TileID.Lavafall:
                    result = ItemID.LavafallBlock;
                    break;
                //紙吹雪ブロック
                case TileID.Confetti:
                    result = ItemID.ConfettiBlock;
                    break;
                //深夜の紙吹雪のブロック
                case TileID.ConfettiBlack:
                    result = ItemID.ConfettiBlockBlack;
                    break;
                //カッパーコイン
                case TileID.CopperCoinPile:
                    result = ItemID.CopperCoin;
                    break;
                //シルバーコイン
                case TileID.SilverCoinPile:
                    result = ItemID.SilverCoin;
                    break;
                //ゴールドコイン
                case TileID.GoldCoinPile:
                    result = ItemID.GoldCoin;
                    break;
                //プラチナコイン
                case TileID.PlatinumCoinPile:
                    result = ItemID.PlatinumCoin;
                    break;
                //燃えてるブロック
                case TileID.LivingFire:
                    result = ItemID.LivingFireBlock;
                    break;
                //うごめく呪われた火のブロック
                case TileID.LivingCursedFire:
                    result = ItemID.LivingCursedFireBlock;
                    break;
                //うごめく邪悪な火のブロック
                case TileID.LivingDemonFire:
                    result = ItemID.LivingDemonFireBlock;
                    break;
                //うごめく凍てついた火のブロック
                case TileID.LivingFrostFire:
                    result = ItemID.LivingFrostFireBlock;
                    break;
                //うごめく霊液のブロック
                case TileID.LivingIchor:
                    result = ItemID.LivingIchorBlock;
                    break;
                //うごめく光り輝いた火のブロック
                case TileID.LivingUltrabrightFire:
                    result = ItemID.LivingUltrabrightFireBlock;
                    break;
                //はちみつのブロック
                case TileID.Honeyfall:
                    result = ItemID.HoneyfallBlock;
                    break;
                //クロロファイトレンガ
                case TileID.ChlorophyteBrick:
                    result = ItemID.ChlorophyteBrick;
                    break;
                //クリムタンレンガ
                case TileID.CrimtaneBrick:
                    result = ItemID.CrimtaneBrick;
                    break;
                //シュルーマイトメッキ
                case TileID.ShroomitePlating:
                    result = ItemID.ShroomitePlating;
                    break;
                //火星の導管外装
                case TileID.MartianConduitPlating:
                    result = ItemID.MartianConduitPlating;
                    break;
                //煙のブロック
                case TileID.ChimneySmoke:
                    result = ItemID.SmokeBlock;
                    break;
                //ツタのロープ
                case TileID.VineRope:
                    result = ItemID.VineRope;
                    break;
                //滑らかな大理石ブロック
                case TileID.MarbleBlock:
                    result = ItemID.MarbleBlock;
                    break;
                //シルクのロープ
                case TileID.SilkRope:
                    result = ItemID.SilkRope;
                    break;
                //クモの巣のロープ
                case TileID.WebRope:
                    result = ItemID.WebRope;
                    break;
                //大理石のブロック
                case TileID.Marble:
                    result = ItemID.Marble;
                    break;
                //御影石のブロック
                case TileID.Granite:
                    result = ItemID.Granite;
                    break;
                //滑らかな御影石のブロック
                case TileID.GraniteBlock:
                    result = ItemID.GraniteBlock;
                    break;
                //メテオライトのレンガ
                case TileID.MeteoriteBrick:
                    result = ItemID.MeteoriteBrick;
                    break;
                //ピンクスライムブロック
                case TileID.PinkSlimeBlock:
                    result = ItemID.PinkSlimeBlock;
                    break;
                //平和の蝋燭
                case TileID.PeaceCandle:
                    result = ItemID.PeaceCandle;
                    break;
                //泡
                case TileID.Bubble:
                    result = ItemID.Bubble;
                    break;
                //マホガニー
                case TileID.LivingMahogany:
                    result = ItemID.RichMahogany;
                    break;
                //クリスタルブロック
                case TileID.CrystalBlock:
                    result = ItemID.CrystalBlock;
                    break;
                //砂岩のブロック
                case TileID.Sandstone:
                    result = ItemID.Sandstone;
                    break;
                //硬化した砂のブロック
                case TileID.HardenedSand:
                    result = ItemID.HardenedSand;
                    break;
                //穢れた硬化砂ブロック
                case TileID.CorruptHardenedSand:
                    result = ItemID.CorruptHardenedSand;
                    break;
                //紅の硬化砂ブロック
                case TileID.CrimsonHardenedSand:
                    result = ItemID.CrimsonHardenedSand;
                    break;
                //エボンサンドストーンのブロック
                case TileID.CorruptSandstone:
                    result = ItemID.CorruptSandstone;
                    break;
                //クリムサンドストーンのブロック
                case TileID.CrimsonSandstone:
                    result = ItemID.CrimsonSandstone;
                    break;
                //硬化したパールサンドブロック
                case TileID.HallowHardenedSand:
                    result = ItemID.HallowHardenedSand;
                    break;
                //パールサンドストーンブロック
                case TileID.HallowSandstone:
                    result = ItemID.HallowSandstone;
                    break;
                //砂漠の化石ブロック
                case TileID.DesertFossil:
                    result = ItemID.DesertFossil;
                    break;
                //頑丈な化石
                case TileID.FossilOre:
                    result = ItemID.FossilOre;
                    break;
                //ルミナイト鉱石
                case TileID.LunarOre:
                    result = ItemID.LunarOre;
                    break;
                //ルミナイトのレンガ
                case TileID.LunarBrick:
                    result = ItemID.LunarBrick;
                    break;
                //太陽の断片ブロック
                case TileID.LunarBlockSolar:
                    result = ItemID.LunarBlockSolar;
                    break;
                //銀河の断片ブロック
                case TileID.LunarBlockVortex:
                    result = ItemID.LunarBlockVortex;
                    break;
                //星雲の断片ブロック
                case TileID.LunarBlockNebula:
                    result = ItemID.LunarBlockNebula;
                    break;
                //星屑の断片ブロック
                case TileID.LunarBlockStardust:
                    result = ItemID.LunarBlockStardust;
                    break;
                //コンベアベルト（時計回り）
                case TileID.ConveyorBeltLeft:
                    result = ItemID.ConveyorBeltLeft;
                    break;
                //コンベアベルト（反時計回り）
                case TileID.ConveyorBeltRight:
                    result = ItemID.ConveyorBeltRight;
                    break;
                //ジャンクションボックス
                case TileID.WirePipe:
                    result = ItemID.WirePipe;
                    break;
                //赤チームのレンガ
                case TileID.TeamBlockRed:
                    result = ItemID.TeamBlockRed;
                    break;
                //赤チームの足場
                case TileID.TeamBlockRedPlatform:
                    result = ItemID.TeamBlockRedPlatform;
                    break;
                //ワイヤー電球
                case TileID.WireBulb:
                    result = ItemID.WireBulb;
                    break;
                //緑チームのレンガ
                case TileID.TeamBlockGreen:
                    result = ItemID.TeamBlockGreen;
                    break;
                //青チームのレンガ
                case TileID.TeamBlockBlue:
                    result = ItemID.TeamBlockBlue;
                    break;
                //黄チームのレンガ
                case TileID.TeamBlockYellow:
                    result = ItemID.TeamBlockYellow;
                    break;
                //桃チームのレンガ
                case TileID.TeamBlockPink:
                    result = ItemID.TeamBlockPink;
                    break;
                //白チームのレンガ
                case TileID.TeamBlockWhite:
                    result = ItemID.TeamBlockWhite;
                    break;
                //緑チームの足場
                case TileID.TeamBlockGreenPlatform:
                    result = ItemID.TeamBlockGreenPlatform;
                    break;
                //青チームの足場
                case TileID.TeamBlockBluePlatform:
                    result = ItemID.TeamBlockBluePlatform;
                    break;
                //黄チームの足場
                case TileID.TeamBlockYellowPlatform:
                    result = ItemID.TeamBlockYellowPlatform;
                    break;
                //桃チームの足場
                case TileID.TeamBlockPinkPlatform:
                    result = ItemID.TeamBlockPinkPlatform;
                    break;
                //白チームの足場
                case TileID.TeamBlockWhitePlatform:
                    result = ItemID.TeamBlockWhitePlatform;
                    break;
                //青緑色の圧力パッド
                case TileID.ProjectilePressurePad:
                    result = ItemID.ProjectilePressurePad;
                    break;
                //ピクセルボックス
                case TileID.PixelBox:
                    result = ItemID.PixelBox;
                    break;
                //おめでたい風船（桃）
                case TileID.SillyBalloonPink:
                    result = ItemID.SillyBalloonPink;
                    break;
                //おめでたい風船（紫）
                case TileID.SillyBalloonPurple:
                    result = ItemID.SillyBalloonPurple;
                    break;
                //おめでたい風船（緑）
                case TileID.SillyBalloonGreen:
                    result = ItemID.SillyBalloonGreen;
                    break;
                //青のストリーマー
                case TileID.SillyStreamerBlue:
                    result = ItemID.SillyStreamerBlue;
                    break;
                //緑のストリーマー
                case TileID.SillyStreamerGreen:
                    result = ItemID.SillyStreamerGreen;
                    break;
                //ピンクのストリーマー
                case TileID.SillyStreamerPink:
                    result = ItemID.SillyStreamerPink;
                    break;
                //砂滝
                case TileID.SandFallBlock:
                    result = ItemID.SandFallBlock;
                    break;
                //降雪
                case TileID.SnowFallBlock:
                    result = ItemID.SnowFallBlock;
                    break;
                //雪の雲
                case TileID.SnowCloud:
                    result = ItemID.SnowCloudBlock;
                    break;
                case TileID.Plants:
                    break;
                case TileID.Torches:
                    break;
                case TileID.Trees:
                    break;
                case TileID.ClosedDoor:
                    break;
                case TileID.OpenDoor:
                    break;
                case TileID.Heart:
                    break;
                case TileID.Bottles:
                    break;
                case TileID.Tables:
                    break;
                case TileID.Chairs:
                    break;
                case TileID.Anvils:
                    break;
                case TileID.Furnaces:
                    break;
                case TileID.WorkBenches:
                    break;
                case TileID.Platforms:
                    break;
                case TileID.Saplings:
                    break;
                case TileID.Containers:
                    break;
                case TileID.CorruptPlants:
                    break;
                case TileID.DemonAltar:
                    break;
                case TileID.Sunflower:
                    break;
                case TileID.Pots:
                    break;
                case TileID.PiggyBank:
                    break;
                case TileID.ShadowOrbs:
                    break;
                case TileID.CorruptThorns:
                    break;
                case TileID.Candles:
                    break;
                case TileID.Chandeliers:
                    break;
                case TileID.Jackolanterns:
                    break;
                case TileID.HangingLanterns:
                    break;
                case TileID.Vines:
                    break;
                case TileID.Signs:
                    break;
                case TileID.JunglePlants:
                    break;
                case TileID.JungleVines:
                    break;
                case TileID.JungleThorns:
                    break;
                case TileID.MushroomPlants:
                    break;
                case TileID.MushroomTrees:
                    break;
                case TileID.Plants2:
                    break;
                case TileID.JunglePlants2:
                    break;
                case TileID.Hellforge:
                    break;
                case TileID.Beds:
                    break;
                case TileID.ImmatureHerbs:
                    break;
                case TileID.MatureHerbs:
                    break;
                case TileID.BloomingHerbs:
                    break;
                case TileID.Tombstones:
                    break;
                case TileID.Loom:
                    break;
                case TileID.Pianos:
                    break;
                case TileID.Dressers:
                    break;
                case TileID.Benches:
                    break;
                case TileID.Bathtubs:
                    break;
                case TileID.Banners:
                    break;
                case TileID.Lampposts:
                    break;
                case TileID.Lamps:
                    break;
                case TileID.Kegs:
                    break;
                case TileID.ChineseLanterns:
                    break;
                case TileID.CookingPots:
                    break;
                case TileID.Safes:
                    break;
                case TileID.SkullLanterns:
                    break;
                case TileID.TrashCan:
                    break;
                case TileID.Candelabras:
                    break;
                case TileID.Bookcases:
                    break;
                case TileID.Thrones:
                    break;
                case TileID.Bowls:
                    break;
                case TileID.GrandfatherClocks:
                    break;
                case TileID.Statues:
                    break;
                case TileID.Sawmill:
                    break;
                case TileID.HallowedPlants:
                    break;
                case TileID.HallowedPlants2:
                    break;
                case TileID.TinkerersWorkbench:
                    break;
                case TileID.HallowedVines:
                    break;
                case TileID.CrystalBall:
                    break;
                case TileID.DiscoBall:
                    break;
                case TileID.MagicalIceBlock:
                    break;
                case TileID.Mannequin:
                    break;
                case TileID.Lever:
                    break;
                case TileID.AdamantiteForge:
                    break;
                case TileID.MythrilAnvil:
                    break;
                case TileID.PressurePlates:
                    break;
                case TileID.Traps:
                    break;
                case TileID.Boulder:
                    break;
                case TileID.MusicBoxes:
                    break;
                case TileID.InletPump:
                    break;
                case TileID.OutletPump:
                    break;
                case TileID.Timers:
                    break;
                case TileID.HolidayLights:
                    break;
                case TileID.BreakableIce:
                    break;
                case TileID.Stalactite:
                    break;
                case TileID.ChristmasTree:
                    break;
                case TileID.Sinks:
                    break;
                case TileID.PlatinumCandelabra:
                    break;
                case TileID.ExposedGems:
                    break;
                case TileID.GreenMoss:
                    break;
                case TileID.BrownMoss:
                    break;
                case TileID.RedMoss:
                    break;
                case TileID.BlueMoss:
                    break;
                case TileID.PurpleMoss:
                    break;
                case TileID.LongMoss:
                    break;
                case TileID.SmallPiles:
                    break;
                case TileID.LargePiles:
                    break;
                case TileID.LargePiles2:
                    break;
                case TileID.LeafBlock:
                    break;
                case TileID.FleshGrass:
                    break;
                case TileID.FleshWeeds:
                    break;
                case TileID.CrimsonVines:
                    break;
                case TileID.WaterFountain:
                    break;
                case TileID.Cannon:
                    break;
                case TileID.SnowballLauncher:
                    break;
                case TileID.Campfire:
                    break;
                case TileID.Firework:
                    break;
                case TileID.Blendomatic:
                    break;
                case TileID.MeatGrinder:
                    break;
                case TileID.Extractinator:
                    break;
                case TileID.Solidifier:
                    break;
                case TileID.Hive:
                    break;
                case TileID.DyePlants:
                    break;
                case TileID.DyeVat:
                    break;
                case TileID.Larva:
                    break;
                case TileID.PlantDetritus:
                    break;
                case TileID.Teleporter:
                    break;
                case TileID.LifeFruit:
                    break;
                case TileID.LihzahrdAltar:
                    break;
                case TileID.PlanteraBulb:
                    break;
                case TileID.MetalBars:
                    break;
                case TileID.Painting3X3:
                    break;
                case TileID.Painting4X3:
                    break;
                case TileID.Painting6X4:
                    break;
                case TileID.ImbuingStation:
                    break;
                case TileID.BubbleMachine:
                    break;
                case TileID.Painting2X3:
                    break;
                case TileID.Painting3X2:
                    break;
                case TileID.Autohammer:
                    break;
                case TileID.Pumpkins:
                    break;
                case TileID.Womannequin:
                    break;
                case TileID.FireflyinaBottle:
                    break;
                case TileID.LightningBuginaBottle:
                    break;
                case TileID.BunnyCage:
                    break;
                case TileID.SquirrelCage:
                    break;
                case TileID.MallardDuckCage:
                    break;
                case TileID.DuckCage:
                    break;
                case TileID.BirdCage:
                    break;
                case TileID.BlueJay:
                    break;
                case TileID.CardinalCage:
                    break;
                case TileID.FishBowl:
                    break;
                case TileID.HeavyWorkBench:
                    break;
                case TileID.SnailCage:
                    break;
                case TileID.GlowingSnailCage:
                    break;
                case TileID.AmmoBox:
                    break;
                case TileID.MonarchButterflyJar:
                    break;
                case TileID.PurpleEmperorButterflyJar:
                    break;
                case TileID.RedAdmiralButterflyJar:
                    break;
                case TileID.UlyssesButterflyJar:
                    break;
                case TileID.SulphurButterflyJar:
                    break;
                case TileID.TreeNymphButterflyJar:
                    break;
                case TileID.ZebraSwallowtailButterflyJar:
                    break;
                case TileID.JuliaButterflyJar:
                    break;
                case TileID.ScorpionCage:
                    break;
                case TileID.BlackScorpionCage:
                    break;
                case TileID.FrogCage:
                    break;
                case TileID.MouseCage:
                    break;
                case TileID.BoneWelder:
                    break;
                case TileID.FleshCloningVat:
                    break;
                case TileID.GlassKiln:
                    break;
                case TileID.LihzahrdFurnace:
                    break;
                case TileID.LivingLoom:
                    break;
                case TileID.SkyMill:
                    break;
                case TileID.IceMachine:
                    break;
                case TileID.SteampunkBoiler:
                    break;
                case TileID.HoneyDispenser:
                    break;
                case TileID.PenguinCage:
                    break;
                case TileID.WormCage:
                    break;
                case TileID.MinecartTrack:
                    break;
                case TileID.BlueJellyfishBowl:
                    break;
                case TileID.GreenJellyfishBowl:
                    break;
                case TileID.PinkJellyfishBowl:
                    break;
                case TileID.ShipInABottle:
                    break;
                case TileID.SeaweedPlanter:
                    break;
                case TileID.PalmTree:
                    break;
                case TileID.BeachPiles:
                    break;
                case TileID.WeaponsRack:
                    break;
                case TileID.FireworksBox:
                    break;
                case TileID.AlphabetStatues:
                    break;
                case TileID.FireworkFountain:
                    break;
                case TileID.GrasshopperCage:
                    break;
                case TileID.MushroomStatue:
                    break;
                case TileID.CrimtaneThorns:
                    break;
                case TileID.BewitchingTable:
                    break;
                case TileID.AlchemyTable:
                    break;
                case TileID.Sundial:
                    break;
                case TileID.GoldBirdCage:
                    break;
                case TileID.GoldBunnyCage:
                    break;
                case TileID.GoldButterflyCage:
                    break;
                case TileID.GoldFrogCage:
                    break;
                case TileID.GoldGrasshopperCage:
                    break;
                case TileID.GoldMouseCage:
                    break;
                case TileID.GoldWormCage:
                    break;
                case TileID.WaterDrip:
                    break;
                case TileID.LavaDrip:
                    break;
                case TileID.HoneyDrip:
                    break;
                case TileID.FishingCrate:
                    break;
                case TileID.SharpeningStation:
                    break;
                case TileID.TargetDummy:
                    break;
                case TileID.PlanterBox:
                    break;
                case TileID.LavaMoss:
                    break;
                case TileID.VineFlowers:
                    break;
                case TileID.LivingMahoganyLeaves:
                    break;
                case TileID.TrapdoorOpen:
                    break;
                case TileID.TrapdoorClosed:
                    break;
                case TileID.TallGateClosed:
                    break;
                case TileID.TallGateOpen:
                    break;
                case TileID.LavaLamp:
                    break;
                case TileID.CageEnchantedNightcrawler:
                    break;
                case TileID.CageBuggy:
                    break;
                case TileID.CageGrubby:
                    break;
                case TileID.CageSluggy:
                    break;
                case TileID.ItemFrame:
                    break;
                case TileID.Fireplace:
                    break;
                case TileID.Chimney:
                    break;
                case TileID.LunarMonolith:
                    break;
                case TileID.Detonator:
                    break;
                case TileID.LunarCraftingStation:
                    break;
                case TileID.SquirrelOrangeCage:
                    break;
                case TileID.SquirrelGoldCage:
                    break;
                case TileID.LogicGateLamp:
                    break;
                case TileID.LogicGate:
                    break;
                case TileID.LogicSensor:
                    break;
                case TileID.AnnouncementBox:
                    break;
                case TileID.WeightedPressurePlate:
                    break;
                case TileID.GemLocks:
                    break;
                case TileID.FakeContainers:
                    break;
                case TileID.GeyserTrap:
                    break;
                case TileID.BeeHive:
                    break;
                case TileID.SillyBalloonMachine:
                    break;
                case TileID.SillyBalloonTile:
                    break;
                case TileID.Pigronata:
                    break;
                case TileID.PartyMonolith:
                    break;
                case TileID.PartyBundleOfBalloonTile:
                    break;
                case TileID.PartyPresent:
                    break;
                case TileID.SandDrip:
                    break;
                case TileID.DjinnLamp:
                    break;
                case TileID.DefendersForge:
                    break;
                case TileID.WarTable:
                    break;
                case TileID.WarTableBanner:
                    break;
                case TileID.ElderCrystalStand:
                    break;
                case TileID.Containers2:
                    break;
                case TileID.FakeContainers2:
                    break;
                case TileID.Tables2:
                    break;
                case TileID.Count:
                    break;
            }
            return result;
        }
    }
}
