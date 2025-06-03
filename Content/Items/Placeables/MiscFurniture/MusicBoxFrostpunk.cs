using Terraria.ModLoader;
using Terraria.ID;
using Tutor.Content.Tiles.MiscFurniture;
using Terraria.Audio;

namespace Tutor.Content.Items.Placeables.MiscFurniture
{
    public class MusicBoxFrostpunk : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Music Box (Astral Blight)");
            Item.ResearchUnlockCount = 1;
            MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, "Content/Sounds/Music/Fedyachastuski"), ModContent.ItemType<MusicBoxFrostpunk>(), ModContent.TileType<MusicBoxFrostpunkTile>());
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<MusicBoxFrostpunkTile>();
            Item.width = 24;
            Item.height = 24;
            Item.rare = ItemRarityID.Yellow;
            Item.value = 100000;
            Item.accessory = true;
        }
    }
}