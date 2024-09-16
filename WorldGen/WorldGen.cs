using System.Collections.Generic;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace TerrariaCellsPersonal.WorldGen {
	class WorldGen : ModSystem {
		public override void ModifyWorldGenTasks(List<GenPass> tasks, ref double totalWeight) {

			// Disable vanilla world gen tasks.
			foreach (var task in tasks) {
				// TODO: I'm not sure if anything non-obvious breaks by skipping the Reset task.
				if (task.Name != "Reset") {
				   task.Disable();
				}
			}

			tasks.Add(new GenerateRoomsPass());
		}
	}
}
