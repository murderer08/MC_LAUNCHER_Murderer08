using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.Serialization.Json;


namespace MCLauncher
{
    public partial class Form1 : Form
    {
        string mcraftfile = "";
        string javaBin = "";
        const int ALLOWED_MEMORY = 1024;
        private static string MAGICAL_INTEL_OPTION = "-XX:HeapDumpPath=ThisTricksIntelDriversForPerformance_javaw.exe_minecraft.exe.heapdump";

        string gameDir = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            Register();
        }

        private void btn_offline_Click(object sender, EventArgs e)
        {
            RunOfflineMode();
        }

        private void txt_login_TextChanged(object sender, EventArgs e)
        {
            CheckLogin();
        }


        void Register()
        {
            Process.Start("http://mg-servers.ru/cb-registration/registers");
        }
        void CheckLogin()
        {
            if (txt_login.Text.Length <= 5)
            {
                btn_login.Enabled = false;
                btn_offline.Enabled = false;
                txt_login.BackColor = Color.LightSalmon;
            }
            else
            {
                btn_login.Enabled = true;
                btn_offline.Enabled = true;
                txt_login.BackColor = Color.White;
            }
        }

        void RunOfflineMode()
        {
            List<string> args = new List<string>();
            args.Add(javaBin);
            args.Add(MAGICAL_INTEL_OPTION);
            args.Add("-Xmx" + ALLOWED_MEMORY + 'M');
            if (System.IO.File.Exists(mcraftfile))
                Process.Start(mcraftfile);
        }


        string GenerateBat()
        {
            return "";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

        }
    }

    class MCJson
    {
        public string id;
        public string family;
        public string time;
        public string releaseTime;
        public string type;
        public string minecraftArguments;
        public string mainClass;
        public string minimumLauncherVersion;
        public string tlauncherVersion;
        public List<MCLib> libraries;
    }

    class MCLib
    {
        public string name;
        MCDownload downloads;
    }

    class MCDownload
    {
        MCArtifact artifact;
    }

    class MCArtifact
    {
        public string url;
        public string sha1;
        public long size;
    }
}
