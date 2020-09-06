using Terraria.ID;
using Terraria.ModLoader;

namespace GalaxyReborn.Items
{
	public class VortexSprayer : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("VortexSprayer"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Spray them down.");
		}

		public override void SetDefaults() 
		{
			item.damage = 230;
			item.ranged = true;
			item.noMelee = true;
			item.useAmmo = AmmoID.Bullet;
			item.width = 40;
			item.height = 50;
			item.useTime = 1;
			item.useAnimation = 1;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = 2;
			item.autoReuse = true;
			item.shoot = 618;
			item.shootSpeed = 15;
			
		}

		public override void AddRecipes() 

		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(3475, 1);
            recipe.AddIngredient(1553, 1);
            recipe.AddIngredient(3540, 1);
	    recipe.AddIngredient(mod, "VortexSingularity", 5);
	    recipe.AddIngredient(mod, "LuminiteSingularity", 1);
            recipe.AddTile(412);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}