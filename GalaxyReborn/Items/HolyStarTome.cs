using Terraria.ID;
using Terraria.ModLoader;

namespace GalaxyReborn.Items
{
	public class HolyStarTome : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("HolyStarTome"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Fires a star from the sky.");
		}

		public override void SetDefaults() 
		{
			item.damage = 53;
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
			item.shoot = 9;
			item.shootSpeed = 15;
			
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(165, 1);
            recipe.AddIngredient(75, 5);
            recipe.AddTile(101);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}