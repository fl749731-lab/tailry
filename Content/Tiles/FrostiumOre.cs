using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace xiwang.Content.Tiles
{
    public class FrostiumOre : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileValue[Type] = 410;
            Main.tileMergeDirt[Type] = true;

            AddMapEntry(new Color(100, 200, 255), CreateMapEntryName());
            DustType = DustID.Ice;
            ItemDrop = ModContent.ItemType<Items.FrostiumOre>();
            HitSound = SoundID.Tink;
            MineResist = 4f;
            MinPick = 65;
        }
    }
}
