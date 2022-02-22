using System;
using Rocket.Core.Plugins;
using Rocket.API.Collections;
using System.Xml.Serialization;
using SDG.Unturned;
using UnityEngine;

namespace BadJujuWorkshopManager
{
    public class Plugin : RocketPlugin<Config>
    {

        public uint newids;

       
        public class Mod
        {
            [XmlAttribute]
            public  ulong Id;
            [XmlAttribute]
            public string Description;
            [XmlAttribute]
            public string time;

           

            public Mod(ulong Id, string Description, string time)
            {
                this.Id = Id;
                this.Description = Description;
                this.time = time;
            }
          
    public  Mod() { }

            
        }
        public class Map
        {
            [XmlAttribute]
            public string name;
            [XmlAttribute]
            public string time;



            public Map(string name, string time)
            {
                this.name = name;
             
                this.time = time;
            }

            public Map() { }


        }




        public override TranslationList DefaultTranslations => new TranslationList
        {
          
        };

        public static Plugin Instance;
     
        public ulong newid;
   
        protected override void Load()
        {
           
            Console.WriteLine("Plugin was load succesfully", Color.green);
            Console.WriteLine("Plugin was created by BadJuju", Color.green);
            Console.WriteLine("If yoy have some qeustions please write in discord BadJuju#8608", Color.green);

            DateTime data = DateTime.Now;
            DayOfWeek datas = data.DayOfWeek;
            foreach (Map map in Configuration.Instance.Maps)
            {
                if (map.time.ToLower() == "monday" && datas == DayOfWeek.Monday)
                {
                    Provider.map = map.name;
                }
                else if (map.time.ToLower() == "tuesday" && datas == DayOfWeek.Tuesday)
                {
                    Provider.map = map.name;
                }
                else if (map.time.ToLower() == "wednesday" && datas == DayOfWeek.Wednesday)
                {
                    Provider.map = map.name;
                }
                else if (map.time.ToLower() == "thursday" && datas == DayOfWeek.Thursday)
                {
                    Provider.map = map.name;
                }
                else if (map.time.ToLower() == "friday" && datas == DayOfWeek.Friday)
                {
                    Provider.map = map.name;
                }
                else if (map.time.ToLower() == "saturday" && datas == DayOfWeek.Saturday)
                {
                    Provider.map = map.name;
                }
                else if (map.time.ToLower() == "sunday" && datas == DayOfWeek.Sunday)
                {
                    Provider.map = map.name;
                }
            }
                foreach (Mod mod in Configuration.Instance.Mods)
            {
                if (mod.time.ToLower() == "regular")
                {
                    WorkshopDownloadConfig.getOrLoad().File_IDs.Add(mod.Id);
                }
          else if(mod.time.ToLower() == "monday" && datas == DayOfWeek.Monday)
                {
                    WorkshopDownloadConfig.getOrLoad().File_IDs.Add(mod.Id);
                }
                else if (mod.time.ToLower() == "tuesday" && datas == DayOfWeek.Tuesday)
                {
                    WorkshopDownloadConfig.getOrLoad().File_IDs.Add(mod.Id);
                }
                else if (mod.time.ToLower() == "wednesday" && datas == DayOfWeek.Wednesday)
                {
                    WorkshopDownloadConfig.getOrLoad().File_IDs.Add(mod.Id);
                }
                else if (mod.time.ToLower() == "wednesday" && datas == DayOfWeek.Thursday)
                {
                    WorkshopDownloadConfig.getOrLoad().File_IDs.Add(mod.Id);
                }
                else if (mod.time.ToLower() == "friday" && datas == DayOfWeek.Friday)
                {
                    WorkshopDownloadConfig.getOrLoad().File_IDs.Add(mod.Id);
                   
                }
                else if (mod.time.ToLower() == "saturday" && datas == DayOfWeek.Saturday)
                {
                    WorkshopDownloadConfig.getOrLoad().File_IDs.Add(mod.Id);
                }
                else if (mod.time.ToLower() == "sunday" && datas == DayOfWeek.Sunday)
                {
                    WorkshopDownloadConfig.getOrLoad().File_IDs.Add(mod.Id);
                }
               
            }


            Instance = this;
            

        }

        protected override void Unload()
        {
            Console.WriteLine("Plugin was unload succesfully", Color.green);
            foreach (Mod mod in Configuration.Instance.Mods)
            {
                WorkshopDownloadConfig.getOrLoad().File_IDs.Remove(mod.Id);
            }
        }

       
    }
}
