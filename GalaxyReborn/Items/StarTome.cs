using Terraria.ID;
using Terraria.ModLoader;

namespace GalaxyReborn.Items
{
	public class StarTome : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("StarTome"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Fires a slow moving star.");
		}

		public override void SetDefaults() 
		{
			item.damage = 23;
			item.magic = true;
			item.noMelee = true;
			item.mana = 4;
			item.width = 40;
			item.height = 50;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = 2;
			item.UseSound = SoundID.Item9;
			item.autoReuse = true;
			item.shoot = 12;
			item.shootSpeed = 5;
			
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