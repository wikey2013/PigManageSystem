using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Configuration;

namespace PigManagerSystem.Unity
{
    public class ConfigHelp
    {
        public static string GetDataFileString()
        {
            string filePath = ConfigurationManager.AppSettings["dataFile"].ToString();
            return filePath;
        }

        public static void SetDataFileString(string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings["dataFile"]!=null)
            {
                config.AppSettings.Settings["dataFile"].Value = value;
            }
            else
            {
                config.AppSettings.Settings.Add("dataFile",value);
            }
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
