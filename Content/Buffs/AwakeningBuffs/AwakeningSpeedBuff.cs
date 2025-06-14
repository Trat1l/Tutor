using System.Security;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Tutor.Content.System;

namespace Tutor.Content.Buffs.AwakeningBuffs
{
    public class AwakeningSpeedBuff : ModBuff
    {
        public double i = 1;
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            if ((AwakeningSystem.checkTimer >= 3480 && AwakeningSystem.checkTimer <= 5160) || (AwakeningSystem.checkTimer >= 8760 && AwakeningSystem.checkTimer <= 10500))
            {
                player.moveSpeed += (float)(player.moveSpeed * i);
                if (i < 3)
                {
                    i = i + 0.01;
                }
            }
            else
            {
                player.moveSpeed += (float)(player.moveSpeed * i);
                if (i < 2 ) {
                    i = i + 0.001;
                }
                if (i > 2)
                {
                    i = i - 0.01;
                }
            }
        }
    }
}
