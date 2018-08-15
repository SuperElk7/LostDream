using Terraria.ModLoader;

namespace LostDream
{
	class LostDream : Mod
	{
		public LostDream()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
