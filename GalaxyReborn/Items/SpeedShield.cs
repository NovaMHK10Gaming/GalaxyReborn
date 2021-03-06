using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace GalaxyReborn.Items
{
	public class SpeedShield : ModItem
	{
		public override void SetStaticDefaults () 
		{
			// DisplayName.SetDefault("SpeedShield"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Increases speed by 50% and you have no knockback.");
		}

		public override void SetDefaults() 
		{
            item.width = 24;
            item.height = 28;
            item.value = 0;
            item.rare = 1;
            item.accessory = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(75, 5);
            recipe.AddIngredient(57, 1);
            recipe.AddTile(18);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.moveSpeed += 50;
			player.noKnockback = true;
		}
	}
}