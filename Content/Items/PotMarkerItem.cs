using Terraria;
using Terraria.ModLoader;
using TerrariaCellsPersonal.Content.Tiles;

namespace TerrariaCellsPersonal.Content.Items 
{
	public class PotMarkerItem : ModItem 
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<PotMarkerTile>());
		}
	}
}
