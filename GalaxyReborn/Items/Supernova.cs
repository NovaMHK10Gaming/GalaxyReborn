using Terraria.ID;
using Terraria.ModLoader;

namespace GalaxyReborn.Items
{
	public class Supernova : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Supernova"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This one artifact has the entire power of the galaxy.");
		}

		public override void SetDefaults() 
		{
			item.damage = 230;
			item.magic = true;
			item.noMelee = true;
			item.mana = 4;
			item.width = 40;
			item.height = 50;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = 2;
			item.UseSound = SoundID.Item9;
			item.autoReuse = true;
			item.shoot = 617;
			item.shootSpeed = 8;
			
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(3476, 1);
            recipe.AddIngredient(3570, 1);
            recipe.AddIngredient(3542, 1);
	    recipe.AddIngredient(mod, "NebulaSingularity", 5);
	    recipe.AddIngredient(mod, "LuminiteSingularity", 1);
            recipe.AddTile(412);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}