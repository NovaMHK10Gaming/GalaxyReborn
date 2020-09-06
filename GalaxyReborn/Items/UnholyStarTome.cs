using Terraria.ID;
using Terraria.ModLoader;

namespace GalaxyReborn.Items
{
	public class UnholyStarTome : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("UnholyStarTome"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Fires a fast unholy star.");
		}

		public override void SetDefaults() 
		{
			item.damage = 33;
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
			item.shoot = 92;
			item.shootSpeed = 15;
			
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod,"StarTome",  1);
            recipe.AddIngredient(mod, "CorruptFallenStar", 5);
            recipe.AddTile(101);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}