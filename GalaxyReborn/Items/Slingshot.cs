using Terraria.ID;
using Terraria.ModLoader;

namespace GalaxyReborn.Items
{
	public class Slingshot : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Slingshot"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Haha slingshot go brrr.");
		}

		public override void SetDefaults() 
		{
			item.damage = 8;
			item.ranged = true;
			item.noMelee = true;
			item.useAmmo = AmmoID.Arrow;
			item.width = 40;
			item.height = 50;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = 2;
			item.autoReuse = true;
			item.shoot = 51;
			item.shootSpeed = 15;
			
		}

		public override void AddRecipes() 

		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(3, 3);
            recipe.AddIngredient(9, 10);
            recipe.AddIngredient(283, 5);
            recipe.AddTile(412);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}