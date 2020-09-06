using Terraria.ID;
using Terraria.ModLoader;

namespace GalaxyReborn.Items
{
	public class PureStarTome : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("PureStarTome"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Fires a slow moving star.");
		}

		public override void SetDefaults() 
		{
			item.damage = 100;
			item.magic = true;
			item.noMelee = true;
			item.mana = 4;
			item.width = 40;
			item.height = 50;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = 2;
			item.UseSound = SoundID.Item9;
			item.autoReuse = true;
			item.shoot = 503;
			item.shootSpeed = 20;
			
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(3261, 10);
            recipe.AddIngredient(mod, "HolyStarTome", 5);
            recipe.AddTile(101);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}