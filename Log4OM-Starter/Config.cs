using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log4OM_Starter
{
    public class Config
    {
        public string Log4OmPath { get; set; }
        public string BackupPath { get; set; }
        public string Log4OmProcessPath { get; set; }
        public bool sqlLiteSamePathAllPcs { get; set; }
        public string sqlLitePath { get; set; }

        private static string ConfigFileName = ".l4om-starter";
        private static string ConfigPath = Path.Combine(Environment.CurrentDirectory, ConfigFileName);
        

        public Config Init()
        {
            Config cfg = new Config();

            if (File.Exists(ConfigPath))
            {
                try
                {
                    var cfgData = File.ReadAllText(ConfigPath);
                    cfg = JsonConvert.DeserializeObject<Config>(cfgData);

                    return cfg;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return null;
        }

        public void Save()
        {
            try
            {
                File.WriteAllText(ConfigPath, JsonConvert.SerializeObject(this, Formatting.Indented));
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.InnerException.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteConfigIfExists()
        {
            try
            {
                File.Delete(ConfigPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
