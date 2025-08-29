using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Map;
using Terraria.ModLoader;

namespace FargowiltasCrossmod.Core.Common
{
    public class LocalizationFix : ModSystem
    {
        public override void Load()
        {
            Lang._mapLegendCache[MapHelper.TileToLookup(TileID.BloodMoonMonolith, 0)] = Lang.GetItemName(ItemID.BloodMoonMonolith);
        }

        public override void Unload()
        {
            Lang._mapLegendCache[MapHelper.TileToLookup(TileID.BloodMoonMonolith, 0)] = LocalizedText.Empty;
        }
    }
}
