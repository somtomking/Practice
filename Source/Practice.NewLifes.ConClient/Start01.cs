using NewLife.Xml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.NewLifes.ConClient
{
    class Start01
    {
        static void Main(string[] args)
        {

            Config._.ConfigFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.xml");
            
            
            Config cfg = Config.Current;
            cfg.Id = 1;
            cfg.IsOk = true;
            cfg.Name = "test";
            cfg.Now = DateTime.Now;
            cfg.Save();

            NewLife.Common.SysConfig.Current.
        }
    }

    public class Config : XmlConfig<Config>
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public bool IsOk { get; set; }
        public DateTime Now { get; set; }
    }
}
