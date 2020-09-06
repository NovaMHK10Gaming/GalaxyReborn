using Terraria.ID;
using Terraria.ModLoader;

namespace GalaxyReborn.Items
{
	public class ChlorophyteBolt : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("ChlorophyteBolt"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Shoots a spore cloud that ignores walls.");
		}

		public override void SetDefaults() 
		{
			item.damage = 70;
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
			item.UseSound = SoundID.Item21;
			item.autoReuse = true;
			item.shoot = 228;
			item.shootSpeed = 20;
			
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "HolyStarTome", 1);
            recipe.AddIngredient(1006, 12);
            recipe.AddTile(134);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}