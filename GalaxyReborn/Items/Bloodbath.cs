using Terraria.ID;
using Terraria.ModLoader;

namespace GalaxyReborn.Items
{
	public class Bloodbath : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Bloodbath"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Shower them in ichor.");
		}

		public override void SetDefaults() 
		{
			item.damage = 65;
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
			item.shoot = 280;
			item.shootSpeed = 7;
			
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.NightsEdge);
            recipe.AddIngredient(ItemID.Ichor, 20);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}