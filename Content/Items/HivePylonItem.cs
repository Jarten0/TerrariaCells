using Terraria.Enums;
using Terraria.ModLoader;
using TerrariaCellsPersonal.Content.Tiles;

namespace TerrariaCellsPersonal.Content.Items;

public class HivePylonItem : ModItem
{
    public override void SetDefaults() {
        Item.DefaultToPlaceableTile(ModContent.TileType<HivePylonTile>());
    }
}