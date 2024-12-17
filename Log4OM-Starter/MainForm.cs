using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using AutoUpdaterDotNET;
using System.Threading;

namespace Log4OM_Starter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Config Cfg = new Config();

        private void Log4OM_PathButton_Click(object sender, EventArgs e)
        {
            SelectPath(log4OM_Path, path => Cfg.Log4OmPath = path);
            CheckLog4OM_Path();

        }

        private void CheckLog4OM_Path()
        {
            if (!Directory.Exists(log4OM_Path.Text) && !string.IsNullOrEmpty(log4OM_Path.Text))
            {
                MessageBox.Show("The selected path does not exists!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                log4OM_Path.Text = string.Empty;
                Cfg.Log4OmPath = string.Empty;
            }

            else if (!string.IsNullOrEmpty(log4OM_Path.Text))
            {
                Cfg.Log4OmProcessPath = Path.Combine(Cfg.Log4OmPath, "L4ONG.exe");
                Cfg.Log4OmPath = log4OM_Path.Text;

                if (!File.Exists(Cfg.Log4OmProcessPath))
                {
                    MessageBox.Show("Are you sure this is the correct folder? L4ONG.exe NOT FOUND!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    log4OM_Path.Text = string.Empty;
                    Cfg.Log4OmPath = string.Empty;
                    Cfg.Log4OmProcessPath = string.Empty;
                }
            }
        }

        private void CheckBackup_Path()
        {
            if (!Directory.Exists(BackupPath.Text) && !string.IsNullOrEmpty(BackupPath.Text))
            {
                MessageBox.Show("The selected path does not exists!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BackupPath.Text = string.Empty;
                Cfg.BackupPath = string.Empty;
            }
        }

        private void CheckSqlLite_Path()
        {
            if (!Directory.Exists(sqlLitePath.Text) && !string.IsNullOrEmpty(sqlLitePath.Text))
            {
                MessageBox.Show("The selected path does not exists!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sqlLitePath.Text = string.Empty;
                Cfg.sqlLitePath = string.Empty;
            }
        }

        private void log4OM_Path_Leave(object sender, EventArgs e)
        {
            CheckLog4OM_Path();
        }

        private void Backup_PathButton_Click(object sender, EventArgs e)
        {
            SelectPath(BackupPath, path => Cfg.BackupPath = path);
            CheckBackup_Path();

        }

        private void BackupPath_Leave(object sender, EventArgs e)
        {
            CheckBackup_Path();
        }

        private void checkSqlLitePath_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSqlLitePath.Checked)
            {
                sqlLitePath.Enabled = false;
                sqlLitePathButton.Enabled = false;
                sqlLitePath.Text = string.Empty;
                Cfg.sqlLitePath = string.Empty;
                Cfg.sqlLiteSamePathAllPcs = true;
            }
            else
            {
                sqlLitePath.Enabled = true;
                sqlLitePathButton.Enabled = true;
                sqlLitePath.Text = string.Empty;
                Cfg.sqlLitePath = string.Empty;
                Cfg.sqlLiteSamePathAllPcs = false;
            }
        }

        private void sqlLitePathButton_Click(object sender, EventArgs e)
        {
            SelectPath(sqlLitePath, path => Cfg.sqlLitePath = path);
            CheckSqlLite_Path();

        }

        private void sqlLitePath_Leave(object sender, EventArgs e)
        {
            CheckSqlLite_Path();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Cfg = new Config().Init();
            versionLabel.Text = string.Concat("ver. ",
                Assembly.GetExecutingAssembly().GetName().Version.ToString());

            if (this.Cfg != null)
            {
                saveConfigCheck.Checked = true;

                log4OM_Path.Text = Cfg.Log4OmPath;
                BackupPath.Text = Cfg.BackupPath;
                sqlLitePath.Text = Cfg.sqlLitePath;
                checkSqlLitePath.Checked = Cfg.sqlLiteSamePathAllPcs;
            }
            else
            {
                this.Cfg = new Config();
            }
        }

        private void SaveConfig()
        {
            if (saveConfigCheck.Checked)
            {
                this.Cfg.Save();
            }
            else
            {
                this.Cfg.DeleteConfigIfExists();
            }
        }

        private void OnThisPc_Click(object sender, EventArgs e)
        {
            if (!isConfigReady())
            {
                MessageBox.Show("Please complete the configuration!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsProcessRunning())
            {
                MessageBox.Show("Log4OM is already running. Please close it before start it again!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Process.Start(Cfg.Log4OmProcessPath);
            SaveConfig();
            Application.Exit();
        }

        private void OnAnotherPC_Click(object sender, EventArgs e)
        {
            if (!isConfigReady())
            {
                MessageBox.Show("Please complete the configuration!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsProcessRunning())
            {
                MessageBox.Show("Log4OM is already running. Please close it before start it again!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var log4omConfigFile = Path.Combine(Cfg.Log4OmPath, "config", "user", "config.json");

            var sqlLitePath = string.Empty;

            //Copy last config file from backup

            var jsonFiles = Directory.GetFiles(Cfg.BackupPath, "*.json");
            var sqliteFiles = Directory.GetFiles(Cfg.BackupPath, "*.sqlite");

            if (jsonFiles.Length > 0)
            {

                var latestFile = jsonFiles
                    .Select(file => new FileInfo(file))
                    .OrderByDescending(f => f.LastWriteTime)
                    .First();


                var configbackupFileData = File.ReadAllText(latestFile.FullName);

                JObject jsonObject = JObject.Parse(configbackupFileData);

                if (!Cfg.sqlLiteSamePathAllPcs)
                {
                    sqlLitePath = Path.Combine(Cfg.sqlLitePath, "db.sqlite");
                    jsonObject["UserConfigs"]
                        .First()
                        .SelectToken("DbConfiguration.Path")
                        .Replace(sqlLitePath);
                }
                else
                {
                    sqlLitePath = jsonObject["UserConfigs"]
                        .First()
                        .SelectToken("DbConfiguration.Path").ToString();
                }

                jsonObject["UserConfigs"]
                        .First()
                        .SelectToken("BackupFolder")
                        .Replace(string.Concat(Cfg.BackupPath, "\\"));

                jsonObject["UserConfigs"]
                        .First()
                        .SelectToken("KeyerLastMacroFile")
                        .Replace(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Roaming", "Log4OM2", "macro", "defaultMacro.txt"));

                File.WriteAllText(log4omConfigFile, jsonObject.ToString(Formatting.Indented));

            }

            if (sqliteFiles.Length > 0)
            {
                var latestFile = sqliteFiles
                    .Select(file => new FileInfo(file))
                    .OrderByDescending(f => f.LastWriteTime)
                    .First();

                //File.Delete(sqlLitePath + ".l4om-starter-backup");
                File.Replace(latestFile.FullName, sqlLitePath, sqlLitePath + ".l4om-starter-backup");
            }

            Process.Start(Cfg.Log4OmProcessPath);
            SaveConfig();
            Application.Exit();
        }

        private bool isConfigReady()
        {
            if (string.IsNullOrEmpty(Cfg.BackupPath) ||
                string.IsNullOrEmpty(Cfg.Log4OmPath) ||
                (string.IsNullOrEmpty(Cfg.sqlLitePath) && Cfg.sqlLiteSamePathAllPcs == false))
            {
                return false;
            }
            return true;
        }


        private void SelectPath(TextBox targetTextBox, Action<string> updateConfigAction)
        {
            var fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                targetTextBox.Text = fb.SelectedPath;
                updateConfigAction(fb.SelectedPath);
            }
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoUpdater.Synchronous = true;
            AutoUpdater.ReportErrors = true;

            var currentDirectory = new DirectoryInfo(Application.StartupPath);
            if (currentDirectory.Parent != null)
            {
                AutoUpdater.InstallationPath = currentDirectory.Parent.FullName;
            }
            AutoUpdater.Start("https://raw.githubusercontent.com/NukeDev/Log4OM-Utils/refs/heads/main/Log4OM-Starter/Updates.xml");
        }

        public static bool IsProcessRunning(string processName = "L4ONG")
        {
            
            Process[] processes = Process.GetProcessesByName(processName);

            return processes.Length > 0;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            Process.Start("https://qrz.com/db/iu5trx");
        }
    }

    
}
