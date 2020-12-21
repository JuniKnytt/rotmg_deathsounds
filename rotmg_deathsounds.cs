using Terraria.ModLoader;

namespace rotmg_deathsounds
{
	public class rotmg_deathsounds : Mod
	{
        public rotmg_deathsounds()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };

        }
        /*
        public override void Load()
        {
            Config.Load();
        }
        */
    }
}