using Terraria.ID;
using Terraria.ModLoader;

namespace GalaxyReborn.Items
{
	public class HolyFallenStar : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("HolyFallenStar"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Stars infused with Hallow.");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 40;
			item.maxStack = 999;
			item.value = 1000;
			item.rare = 10;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(75, 5);
            recipe.AddIngredient(1225, 1);
            recipe.AddTile(18);
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
		}
	}
}