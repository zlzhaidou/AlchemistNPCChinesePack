using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions; 
using Terraria;
using Terraria.ModLoader;

namespace LunarVeilChinesePack.GlobalTranslation
{
	public class ItemTooltips : GlobalItem
	{
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			foreach (TooltipLine tooltipLine in tooltips)
			{
				StringBuilder sb = new StringBuilder(tooltipLine.Text);
				//sb.Replace("", "");
				sb.Replace("Can be ", "-专属内容-");

			}
		}

		/*public override void HoldItem(Item item, Player player)
		{
			if (item.type == ModContent.ItemType<BlankCard>())
			{
				string text = "                                     [c/FF00FF:-塔罗牌获取-]\n0.愚者: 击杀死灵傀儡法师会转化此塔罗牌\nI.魔术师: 击杀提姆或符文巫师会转化此塔罗牌\nVI.恋人: 生命值低于一半时找护士治疗会转化此塔罗牌\nIX.隐者: 找哥布林工匠重铸物品会转化此塔罗牌\nXV.恶魔: 击杀血肉之墙会转化此塔罗牌\nXVI.塔: 用物块建造有低概率转化此塔罗牌\nXVII.星星: 击杀全息史莱姆会转化此塔罗牌\nXVIII.月亮: 在夜晚的天空有低概率转化此塔罗牌\nXIX.太阳: 击杀英勇史莱姆会转化此塔罗牌\nXXI.世界: 没有激活的Boss时有低概率转化此塔罗牌\n";

				//"                                     [c/FF00FF:-Obtaining Cards-]\n0.Fool:Killing Antony, the Novice Necromancer will transform the card\nI.Magician:Killing Tim or rune wizard will transform the card\nVI.Lovers: Healing from nurse while having less than 50% life will transform it\nIX.Hermit:Doing a reforge from goblin tinkerer will transform it\nXVI.Devil:Killing Wall of Flesh will transform it\nXVI.Tower:Building stuff with tiles have a small chance to transform it\nXVII.Stars:Killing holographic slime will transform it\nXVIII.Moon:Visiting sky at night have a small chance to transform it\nXIX.Sun:Killing heroic slime will transform it\nXXI.World: Making a trip while no boss is active have small chance to transform it\n")
			}

		}*/
	}
}