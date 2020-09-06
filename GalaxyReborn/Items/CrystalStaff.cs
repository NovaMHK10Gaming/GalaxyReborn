using Terraria.ID;
using Terraria.ModLoader;

namespace GalaxyReborn.Items
{
	public class CrystalStaff : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("CrystalStaff"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Shoots a Crystal.");
		}

		public override void SetDefaults() 
		{
			item.damage = 25;
			item.magic = true;
			item.noMelee = true;
			item.mana = 4;
			item.width = 40;
			item.height = 50;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = 2;
			item.UseSound = SoundID.Item9;
			item.autoReuse = true;
			item.shoot = 94;
			item.shootSpeed = 10;
			
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(744, 1);
            recipe.AddIngredient(75, 8);
            recipe.AddTile(101);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}