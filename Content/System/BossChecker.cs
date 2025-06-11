using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;


namespace Tutor.Content.System
{
    public class BossChecker : ModSystem
    {
        private static int[] bossIDs = new int[]
        {
            NPCID.KingSlime,
            NPCID.EyeofCthulhu,
            NPCID.EaterofWorldsHead,
            NPCID.BrainofCthulhu,
            NPCID.QueenBee,
            NPCID.SkeletronHead,
            NPCID.WallofFlesh,
            NPCID.Spazmatism,
            NPCID.Retinazer,
            NPCID.TheDestroyerBody,
            NPCID.Plantera,
            NPCID.Golem
        };

        public static bool IsAnyBossSummoned()
        {
            foreach (int bossType in bossIDs)
            {
                if (NPC.AnyNPCs(bossType))
                    return true;
            }
            return false;
        }
    }
}
