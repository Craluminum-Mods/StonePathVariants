using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.MathTools;
using Vintagestory.GameContent;

namespace StonePathVariants
{
    public class BlockStonePathStairs : BlockStairs
    {
        public override string GetHeldItemName(ItemStack stack)
        {
            return GetName();
        }

        public override string GetPlacedBlockName(IWorldAccessor world, BlockPos pos)
        {
            return GetName();
        }

        public string GetName()
        {
            var rock = Variant["rock"];
            var part = Lang.Get("rock-" + rock);
            var translated = Lang.GetMatching("game:block-stonepathstairs-up-*");
            return translated + " (" + part + ")";
        }
    }
}