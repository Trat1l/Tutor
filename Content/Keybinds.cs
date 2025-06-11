using Terraria.ModLoader;

namespace Tutor.Content
{
    public class Keybinds : ModSystem
    {
        public static ModKeybind AwakeningHotKey { get; private set; }

        public override void Load()
        {
            // Register keybinds            
            AwakeningHotKey = KeybindLoader.RegisterKeybind(Mod, "ActivateAwekening", "Q");
        }

        public override void Unload()
        {
            AwakeningHotKey = null;
        }
    }
}