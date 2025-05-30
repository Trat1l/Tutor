using Tutor.Content.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Tutor.Content.Items
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class Swaton : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.Tutor.hjson' file.
		public override void SetDefaults()
		{
			Item.DefaultToWhip(ModContent.ProjectileType<ExampleWhipProjectile>(), 35, 3, 4);
			Item.value = Item.buyPrice(silver: 99);
			Item.rare = ItemRarityID.Yellow;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.BeeWax, 8);
			recipe.AddIngredient(ItemID.Stinger, 5);
			recipe.AddIngredient(ItemID.Chain, 2); 
			recipe.AddTile(TileID.HoneyDispenser);
			recipe.Register();
		}
	}
}