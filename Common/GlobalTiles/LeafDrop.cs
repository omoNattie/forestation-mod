using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Forestation.Content.Items.Droppables;
using Terraria.DataStructures;

namespace Forestation.Common.GlobalTiles
{
    public class DropLeaf : GlobalTile
    {
        public override void KillTile(int i, int j, int type, ref bool fail, ref bool effectOnly, ref bool noItem)
        {
            if (!noItem && type == TileID.Trees)
            {
                if (Main.rand.NextBool(50))
                {
                    Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 16, 16, ModContent.ItemType<Leaf>());
                }
            }
        }
    }
}