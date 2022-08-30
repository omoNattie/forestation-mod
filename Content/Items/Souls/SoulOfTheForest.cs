using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;

namespace Forestation.Content.Items.Souls
{
    public class SoulOfTheForest : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul of the Forest");
            Tooltip.SetDefault("The remnants of the spirits that used to strive.");
            
            Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(5, 4));
            ItemID.Sets.AnimatesAsSoul[Item.type] = true;
            ItemID.Sets.ItemIconPulse[Item.type] = true;
            ItemID.Sets.ItemNoGravity[Item.type] = true;
            
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25;
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            
            Item.maxStack = 99;
            Item.value = Item.buyPrice(gold: 3);
            
            Item.rare = ItemRarityID.Pink;
        }

        public override void PostUpdate()
        {
            Color green = new Color(0, 255, 0);
            Lighting.AddLight(Item.Center, green.ToVector3() * 0.55f * Main.essScale);
        }
    }
}