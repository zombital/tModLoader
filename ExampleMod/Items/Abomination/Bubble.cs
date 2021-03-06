using Terraria;
using Terraria.ModLoader;

namespace ExampleMod.Items.Abomination
{
	public class Bubble : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bubble");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.rare = 8;
			item.value = Item.sellPrice(0, 0, 50, 0);
		}
	}
}