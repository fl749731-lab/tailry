using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.IO;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace xiwang
{
	// Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
    public class xiwang : Mod
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int shiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (shiniesIndex != -1)
            {
                tasks.Insert(shiniesIndex + 1, new PassLegacy("Frostium Ore", (progress, configuration) =>
                {
                    progress.Message = "Frostium Ore";
                    int attempts = (int)((Main.maxTilesX * Main.maxTilesY) * 0.00008);
                    for (int k = 0; k < attempts; k++)
                    {
                        int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                        int y = WorldGen.genRand.Next((int)WorldGen.rockLayerLow, Main.maxTilesY - 200);
                        Tile tile = Framing.GetTileSafely(x, y);
                        if (tile.TileType == TileID.SnowBlock || tile.TileType == TileID.IceBlock)
                        {
                            WorldGen.TileRunner(x, y, WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(3, 6), ModContent.TileType<Content.Tiles.FrostiumOre>());
                        }
                    }
                }));
            }
        }
    }
}
