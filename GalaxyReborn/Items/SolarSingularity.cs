using Terraria.ID;
using Terraria.ModLoader;

namespace GalaxyReborn.Items
{
	public class SolarSingularity : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("SolarSingularity"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Singularity of the Solar Pillar.");
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
            recipe.AddIngredient(3458, 1);
            recipe.AddIngredient(3460, 1);
            recipe.AddTile(412);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}