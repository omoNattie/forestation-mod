using Terraria.ID;
using Terraria.ModLoader;
using Forestation.Content.Projectiles.Weapons.Magic;
using Terraria.GameContent.Creative;

namespace Forestation.Content.Items.Weapons.Magic
{
    internal class SecretsOfTheForest : ModItem
    {
        public override void SetStaticDefaults() 
        {
            DisplayName.SetDefault("Secrets of the Forest");
            Tooltip.SetDefault("A squirrel's dream.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 51;
            Item.height = 51;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTurn = true;

            Item.DamageType = DamageClass.Magic;
            Item.noMelee = true;
            Item.mana = 5;
            Item.damage = 10;
            Item.knockBack = 2f;
            Item.autoReuse = true;
            Item.crit = 7;

            Item.useTime = 40;
            Item.useAnimation = 40;

            Item.UseSound = SoundID.Item43;

            Item.shoot = ModContent.ProjectileType<SecretsOfTheForestProj>(); 
            Item.shootSpeed = 2f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Acorn, 20)
                .AddIngredient(ItemID.Book, 10)
                .AddRecipeGroup(RecipeGroupID.Wood, 100)
                .AddTile(TileID.Bookcases)
                .Register();    
        }
    }
}