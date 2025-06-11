using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;


namespace Tutor.Content.Items.Weapons.Typeless
{
    public class Telecaster : ModItem
    {
        public override void SetDefaults()
        {
            Item.value = Item.buyPrice(gold: 30);
            Item.rare = ItemRarityID.LightRed;
            Item.UseSound = SoundID.Item47;
            Item.useAnimation = 20;
            Item.useTime = 6000;
            Item.healLife = 150;
            Item.useStyle = ItemUseStyleID.Shoot;
        }
        public override Vector2? HoldoutOffset() => new Vector2(-20, 0);
        //короче я заебался сделаешь через проджект тайл
    }
}