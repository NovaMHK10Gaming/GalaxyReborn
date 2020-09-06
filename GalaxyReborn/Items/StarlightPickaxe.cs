using Terraria.ID;
using Terraria.ModLoader;

namespace GalaxyReborn.Items
{
	public class StarlightPickaxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("StarlightPickaxe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Swing with stars.");
		}

		public override void SetDefaults() 
		{
			item.damage = 5;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item9;
			item.autoReuse = true;
			item.pick = 40;
			
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CopperPickaxe);
            recipe.AddIngredient(ItemID.FallenStar, 5);
            recipe.AddTile(18);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}