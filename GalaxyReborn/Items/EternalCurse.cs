using Terraria.ID;
using Terraria.ModLoader;

namespace GalaxyReborn.Items
{
	public class EternalCurse : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("EternalCurse"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Curse them with eternal flames.");
		}

		public override void SetDefaults() 
		{
			item.damage = 65;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = 95;
			item.shootSpeed = 20;
			
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.NightsEdge);
            recipe.AddIngredient(ItemID.CursedFlame, 20);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}