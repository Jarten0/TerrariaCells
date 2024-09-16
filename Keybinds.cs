using Terraria.GameInput;
using Terraria.ModLoader;

namespace TerrariaCellsPersonal;

public class Keybinds : ModSystem
{
    public static ModKeybind doorInteract { get; private set;}
    
    public override void Load()
    {
        doorInteract = KeybindLoader.RegisterKeybind(Mod, "Door Interact", "W");
    }
}