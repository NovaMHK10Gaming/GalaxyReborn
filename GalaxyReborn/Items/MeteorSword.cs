using Terraria.ID;
using Terraria.ModLoader;

namespace GalaxyReborn.Items
{
	public class MeteorSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("MeteorSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Rains meteors from the sky.");
		}

		public override void SetDefaults() 
		{
			item.damage = 33;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = 424;
			item.shootSpeed = 10;
			
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(989, 1);
            recipe.AddIngredient(117, 30);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}