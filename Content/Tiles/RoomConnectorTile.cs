using Terraria;
using Terraria.ModLoader;

namespace TerrariaCellsPersonal.Content.Tiles 
{
	public class RoomConnectorTile : ModTile
	{
		public override void SetStaticDefaults() {
			Main.tileSolid[Type] = false;
		}
	}	
}
