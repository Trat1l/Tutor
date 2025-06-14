using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using Tutor.Content.System;

namespace Tutor.Content.Scenes.AwakeningScene
{
    public class AwakeningSceneSpeed : ModSceneEffect
    {
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Content/Sounds/Music/AwakeningSpeed");
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;

        public override bool IsSceneEffectActive(Player player)
        {
            bool b1 = AwakeningSystem.StartAwakening;
            return b1;
        }
    }
}
