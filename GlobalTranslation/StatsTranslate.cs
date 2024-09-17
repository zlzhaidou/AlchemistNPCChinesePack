using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Terraria.ModLoader;
using Terraria.UI.Chat;

namespace AlchemistNPCChinesePack.GlobalTranslation
{
    public class StatsTranslate : ModSystem
    {
        public override void Load()
        {
            On_ChatManager.ParseMessage += Translate;            
        }
        public override void Unload()
        {
            On_ChatManager.ParseMessage -= Translate;
        }       
        private static List<TextSnippet> Translate(On_ChatManager.orig_ParseMessage orig, string text, Color baseColor)
        {
            //操作员商店UI
            text = Regex.Replace(text, "Vanilla Materials/Boss Drops", "原版boss掉落物&材料商店");
            text = Regex.Replace(text, "Modded Materials/Boss Drops", "模组boss掉落物&材料商店");
            text = Regex.Replace(text, "Vanilla Treasure Bags", "原版宝藏袋商店");
            text = Regex.Replace(text, "Modded Treasure Bags #1", "模组宝藏袋商店 #1");
            text = Regex.Replace(text, "Modded Treasure Bags #2", "模组宝藏袋商店 #2");
            text = Regex.Replace(text, "Modded Treasure Bags #3", "模组宝藏袋商店 #3");
            //建筑师商店UI
            text = Regex.Replace(text, "Filler Blocks", "第一商店 (填充方块)");
            text = Regex.Replace(text, "Building Blocks", "第二商店 (建筑方块)");
            text = Regex.Replace(text, "Basic Furniture", "第三商店 (基础家具)");
            text = Regex.Replace(text, "Advanced Furniture", "第四商店 (高级家具)");
            text = Regex.Replace(text, "Torches", "第五商店 (火把专卖)");
            text = Regex.Replace(text, "Candles", "第六商店 (蜡烛专卖)");
            text = Regex.Replace(text, "Lamps", "第七商店 (台灯专卖)");
            text = Regex.Replace(text, "Lanterns", "第八商店 (灯笼专卖)");
            text = Regex.Replace(text, "Chandeliers", "第九商店 (吊灯专卖)");
            text = Regex.Replace(text, "Candelabras", "第十商店 (烛台专卖)");
            //年轻药剂师UI
            text = Regex.Replace(text, "Combinations", "药剂包");
            text = Regex.Replace(text, "Flasks", "烧瓶");
            //药剂师商店UI
            text = Regex.Replace(text, "Vanilla", "第一商店 (原版)");
            text = Regex.Replace(text, "Mod/Calamity", "第二商店 (炼金/灾厄)");
            text = Regex.Replace(text, "Thorium/RG/MoR", "第三商店 (瑟银/RG)");
            text = Regex.Replace(text, "MorePotions", "第四商店 (更多药剂)");
            text = Regex.Replace(text, "UnuBattleRods/Tacklebox/Tremor", "第五商店 (震颤/钓杆/钓具箱)");
            text = Regex.Replace(text, "Wildlife/Sacred/Spirit/Cristilium/ExpSentr", "第六商店 (动物世界/圣域/魂灵/水晶之地/ExpSentr)");
            //哔哔小子显示问题
            text = Regex.Replace(text, " Terraria.ModLoader.StatModifier% / ", " ");
            text = Regex.Replace(text, " Terraria.ModLoader.StatModifier%", " ");
            //蕾蒂希娅套装防御力显示
            text = Regex.Replace(text, "defense", "防御力");
            //失乐园伤害类型
            text = Regex.Replace(text, "pale", "失色");
            //共生体描述
            text = Regex.Replace(text,  "damage reduction", "伤害减免");
            text = Regex.Replace(text, "life regeneration", "生命再生速度");
            text = Regex.Replace(text, "critical strike chance", "暴击率");
            text = Regex.Replace(text, "damage", "伤害");
            text = Regex.Replace(text, "attack speed", "攻击速度");
            return orig.Invoke(text, baseColor);
        }       
    }
}
