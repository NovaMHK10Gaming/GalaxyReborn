using Terraria.ID;
using Terraria.ModLoader;

namespace GalaxyReborn.Items
{
	public class Phantom : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Phantom"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Slow but powerful.");
		}

		public override void SetDefaults() 
		{
			item.damage = 350;
			item.ranged = true;
			item.noMelee = true;
			item.useAmmo = AmmoID.Arrow;
			item.width = 40;
			item.height = 50;
			item.useTime = 50;
			item.useAnimation = 50;
			item.useStyle = 5;
			item.knockBack = 10;
			item.value = 100000;
			item.rare = 2;
			item.autoReuse = true;
			item.shoot = 51;
			item.shootSpeed = 30;
			
		}

		public override void AddRecipes() 

		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "VortexSingularity", 2);
            recipe.AddIngredient(3540, 1);
            recipe.AddTile(18);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}