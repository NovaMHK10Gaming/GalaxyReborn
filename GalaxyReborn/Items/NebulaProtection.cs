using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace GalaxyReborn.Items
{
	public class NebulaProtection : ModItem
	{
		public override void SetStaticDefaults () 
		{
			// DisplayName.SetDefault("NebulaProtection"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Grants immunity to obstructed.");
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
            recipe.AddIngredient(3457, 5);
            recipe.AddTile(114);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.buffImmune[163] = true;
		}
	}
}