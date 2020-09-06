using Terraria.ID;
using Terraria.ModLoader;

namespace GalaxyReborn.Items
{
	public class Solise : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Solise"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Radiation will make them burn.");
		}

		public override void SetDefaults() 
		{
			item.damage = 225;
			item.melee = true;
			item.width = 40;
			item.height = 50;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = 10;
			item.UseSound = SoundID.Item7;
			item.autoReuse = true;
			item.shoot = 523;
			item.shootSpeed = 10;
			
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(3063, 1);
            recipe.AddIngredient(3543, 1);
            recipe.AddIngredient(3473, 1);
            recipe.AddIngredient(mod, "SolarSingularity", 5);
            recipe.AddIngredient(mod, "LuminiteSingularity");
            recipe.AddTile(412);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}