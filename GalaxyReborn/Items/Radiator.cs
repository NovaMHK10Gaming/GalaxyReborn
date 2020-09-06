using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace GalaxyReborn.Items
{
	public class Radiator : ModItem
	{
		public override void SetStaticDefaults () 
		{
			// DisplayName.SetDefault("Radiator"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Decreases life by 50 but greatly increases life regen.");
		}

		public override void SetDefaults() 
		{
            item.width = 24;
            item.height = 28;
            item.value = 0;
            item.rare = 10;
            item.accessory = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(1613, 1);
            recipe.AddIngredient(mod,"SpeedyShackle", 1);
			recipe.AddIngredient(29, 20);
			recipe.AddIngredient(1291, 20);
			recipe.AddIngredient(1225, 40);
			recipe.AddIngredient(1006, 40);
			recipe.AddIngredient(3467, 15);
            recipe.AddTile(114);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.statLifeMax2 -= 50;
			player.lifeRegen += 20;
		}
	}
}