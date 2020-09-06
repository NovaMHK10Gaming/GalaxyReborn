using Terraria.ID;
using Terraria.ModLoader;

namespace GalaxyReborn.Items
{
	public class TrueHellflameBlade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("TrueHellflameBlade"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("The sword of the hero of hell.");
		}

		public override void SetDefaults() 
		{
			item.damage = 97;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = 45;
			item.shootSpeed = 5;
			item.shoot = 85;
			item.shootSpeed = 10;
			
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "HellflameBlade");
            recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
            recipe.AddTile(134);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}