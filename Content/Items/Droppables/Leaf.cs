using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace Forestation.Content.Items.Droppables
{
    public class Leaf : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Just a simple leaf.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.maxStack = 99;
        }
    }    
}
