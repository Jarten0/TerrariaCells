using System;
using Terraria;
using Terraria.ID;
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
