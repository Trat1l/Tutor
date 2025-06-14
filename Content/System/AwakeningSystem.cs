using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using Tutor.Content.Buffs.AwakeningBuffs;
using Terraria.Audio;
using Terraria.ID;
using Tutor.Content.Scenes.AwakeningScene;
namespace Tutor.Content.System
{
    public class AwakeningSystem : ModSystem
    {
        public bool IsAwakening = false;
        public static int checkTimer = 0;
        public static bool StartAwakening = false;
        public int AwakeningChange = 0;
        public int AwakeningTime = 10500; // продолжительность пробуждения в тиках
        AdvancedPopupRequest advancedPopupRequest = new AdvancedPopupRequest
        {
            Color = Color.Yellow,
            Text = "Пробуждение!", // добавить выборочную клавишу
            DurationInFrames = 120,
            Velocity = new Vector2(1, 1)
        };

        public override void Load()
        {
            // Инициализация при загрузке мода
            checkTimer = 0;
           
        }

        public override void PostUpdateEverything()
        {
            if (BossChecker.IsAnyBossSummoned() == true && IsAwakening == false) // определяет есть ли босс и нет ли у игрока пробуждения
            {
                checkTimer++;
                if (checkTimer >= 60)
                {
                    AwakeningChange = Main.rand.Next(1, 4);
                    checkTimer = 0;
                    if (AwakeningChange == 3)
                    {
                        IsAwakening = true;
                        PopupText.NewText(advancedPopupRequest, Main.LocalPlayer.position);
                    }
                }
            }
            
            if (IsAwakening == true)
            {
                if (Main.LocalPlayer.velocity.Y == 0 && Main.LocalPlayer.velocity.X == 0)
                {
                    if (Keybinds.AwakeningHotKey.JustPressed && IsAwakening == true && StartAwakening == false)
                    {
                        StartAwakening = true;
                        Main.LocalPlayer.AddBuff(ModContent.BuffType<AwakeningSpeed>(), AwakeningTime);
                        
                    }
                }    
                if (StartAwakening == true) {
                    checkTimer++;
                }
                if (!Main.LocalPlayer.HasBuff(ModContent.BuffType<AwakeningSpeed>()) && checkTimer >= AwakeningTime && IsAwakening == true || Main.LocalPlayer.dead == true || BossChecker.IsAnyBossSummoned() == false)
                {
                    Main.LocalPlayer.ClearBuff(ModContent.BuffType<AwakeningSpeed>());
                    IsAwakening = false;
                    StartAwakening = false;
                    checkTimer = 0;
                }
            }
        }
    }
}



