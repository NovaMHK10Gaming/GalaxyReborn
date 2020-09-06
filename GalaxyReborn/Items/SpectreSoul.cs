using Terraria.ID;
using Terraria.ModLoader;

namespace GalaxyReborn.Items
{
	public class SpectreSoul : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("SpectreSoul"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Summons a homing spectre beam.");
		}

		public override void SetDefaults() 
		{
			item.damage = 125;
			item.magic = true;
			item.noMelee = true;
			item.mana = 6;
			item.width = 40;
			item.height = 50;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = 2;
			item.UseSound = SoundID.Item9;
			item.autoReuse = true;
			item.shoot = 297;
			item.shootSpeed = 25;
			
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(1466,  1);
            recipe.AddIngredient(3261, 10);
            recipe.AddTile(101);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}