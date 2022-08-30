using Terraria;
using Terraria.ModLoader;

namespace Forestation
{
    public class Player : ModPlayer
    {
        public override void OnEnterWorld(Terraria.Player player)
        {
            Main.NewText("This mod was made by someone with no experience whatsoever, please make sure to report bugs to the github!", 0, 255, 0);
        }
    }
}