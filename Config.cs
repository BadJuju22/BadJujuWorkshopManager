using Rocket.API;
using System.Collections.Generic;

namespace BadJujuWorkshopManager
{
    public class Config : IRocketPluginConfiguration
    {
      
        public List<Plugin.Mod> Mods;
        public List<Plugin.Map> Maps;
    
        public void LoadDefaults()
        {
           
            Mods = new List<Plugin.Mod>
            {
                new Plugin.Mod(2572171840, "мод на машины", "Monday"),
                 new Plugin.Mod(1166562219, "мод на машиныHD", "Regular"),
            };
            Maps = new List<Plugin.Map>
            {
                new Plugin.Map("Russia", "Wednesday"),
                new Plugin.Map("Washington", "Monday"),
            };
        }
    }
}
