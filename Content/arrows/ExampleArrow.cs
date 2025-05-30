using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tutor.Content.Projectiles;

namespace Tutor.Content.arrows
{
	// This example is similar to the Wooden Arrow item
	public class ExampleArrow : ModItem
	{
		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 99;
		}

		public override void SetDefaults() {
			Item.width = 14;
			Item.height = 36;
			Item.damage = 14; // Keep in mind that the arrow's final damage is combined with the bow weapon damage.
			Item.DamageType = DamageClass.Ranged;

			Item.maxStack = Item.CommonMaxStack;
			Item.consumable = true;
			Item.knockBack = 1.5f;
			Item.value = Item.sellPrice(silver: 16);
			Item.shoot = ModContent.ProjectileType<Projectiles.ExampleArrowProjectile>(); // The projectile that weapons fire when using this item as ammunition.
			Item.shootSpeed = 3f; // The speed of the projectile.
			Item.ammo = AmmoID.Arrow; // The ammo class this ammo belongs to.
		}

        // For a more detailed explanation of recipe creation, please go to Content/ExampleRecipes.cs.
        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.JestersArrow, 1);
            recipe.AddIngredient(ItemID.FlamingArrow, 1);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.Register();
        }
	}
}
