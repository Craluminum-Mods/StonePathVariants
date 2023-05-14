using Vintagestory.API.Common;
[assembly: ModInfo("Stone Path Variants")]

namespace StonePathVariants
{
    public class Core : ModSystem
    {
        public override void Start(ICoreAPI api)
        {
            base.Start(api);
            api.RegisterBlockClass("StonePathVariants_BlockStonePath", typeof(BlockStonePath));
            api.RegisterBlockClass("StonePathVariants_BlockStonePathSlab", typeof(BlockStonePathSlab));
            api.RegisterBlockClass("StonePathVariants_BlockStonePathStairs", typeof(BlockStonePathStairs));
            api.World.Logger.Event("started 'Stone Path Variants' mod");
        }
    }
}