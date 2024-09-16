using Terraria.ModLoader.Config;

namespace TerrariaCellsPersonal
{
    public class TerrariaCellsConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        public static TerrariaCellsConfig Instance;

        public bool DisableZoom;
    }
}