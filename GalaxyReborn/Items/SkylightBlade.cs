using Terraria.ID;
using Terraria.ModLoader;

namespace GalaxyReborn.Items
{
	public class SkylightBlade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("SkylightBlade"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Infused with small amounts of Space.");
		}

		public override void SetDefaults() 
		{
			item.damage = 17;
			item.melee = true;
			item.width = 40;
			item.height = 50;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item9;
			item.autoReuse = true;
			item.shoot = 440;
			item.shootSpeed = 10;
			
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Feather ,20);
            recipe.AddIngredient(mod, "StarlightBlade");
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}