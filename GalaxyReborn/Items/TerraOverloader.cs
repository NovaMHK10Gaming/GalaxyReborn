using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace GalaxyReborn.Items
{
	public class TerraOverloader : ModItem
	{
		public override void SetStaticDefaults () 
		{
			// DisplayName.SetDefault("TerraOverloader"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Increases speed by 75%, life by 200, life regeneration by 5, and you are immune to most debuffs, knockback, and fire blocks.");
		}

		public override void SetDefaults() 
		{
            item.width = 24;
            item.height = 28;
            item.value = 0;
            item.rare = 10;
			item.defense = 6;
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
			player.moveSpeed += 75;
			player.noKnockback = true;
			player.statLifeMax2 += 200;
			player.lifeRegen += 5;
			player.buffImmune[24] = true;
			player.buffImmune[67] = true;
			player.buffImmune[30] = true;
			player.buffImmune[23] = true;
			player.buffImmune[32] = true;
			player.buffImmune[36] = true;
			player.buffImmune[22] = true;
			player.buffImmune[33] = true;
			player.buffImmune[20] = true;
			player.buffImmune[46] = true;
			player.buffImmune[31] = true;
			player.buffImmune[35] = true;
		}
	}
}