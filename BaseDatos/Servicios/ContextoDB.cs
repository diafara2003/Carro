
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BaseDatos.Servicios
{
  public  class ContextoDB
    {

        public string conexion { get; set; }
       
        
        public ContextoDB() 
        {
            this.conexion = GetAppSetting("conexion");

        }


         static string GetAppSetting(string settingKey)
        {
            var myJsonString = File.ReadAllText("Config.json");
            var myJObject = JObject.Parse(myJsonString);
            return myJObject.SelectToken(settingKey).Value<string>();
            // return Environment.GetEnvironmentVariable(settingKey);
        }

    }
}
