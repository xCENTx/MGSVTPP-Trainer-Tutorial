using System;
using System.Drawing;
using System.Windows.Forms;
using Memory;

namespace MetalGearTutorial
{
    public partial class Form1 : Form
    {
        Mem m = new Mem();
        public const string PROCESSNAME = "mgsvtpp.exe";
        public const string AMMO_ADDRESS = "mgsvtpp.exe+02BE5F70,0x224";
        bool MGSVRunning;

        public Form1()
        {
            InitializeComponent();
        }

        private void ProcessTimer_Tick(object sender, EventArgs e)
        {
            int PID = m.GetProcIdFromName(PROCESSNAME);
            if (PID > 0)
            {
                m.OpenProcess(PID);
                MGSVRunning = true;
                ProcessLabel.Text = "PROCESS FOUND";
                ProcessLabel.ForeColor = Color.FromArgb(0, 169, 0);
                AmmoLabel.Text = m.ReadInt(AMMO_ADDRESS).ToString();
                if (FreezeAmmo_checkbox.Checked)
                {
                    m.FreezeValue(AMMO_ADDRESS, "int", "30");
                }
                else 
                { 
                    m.UnfreezeValue(AMMO_ADDRESS);
                }
                return;
            }
            MGSVRunning = false;
            ProcessLabel.Text = "PROCESS NOT FOUND";
            ProcessLabel.ForeColor = Color.FromArgb(169, 0, 0);
        }

        private void SendAmmo_Button_Click(object sender, EventArgs e)
        {
            if (!MGSVRunning)
            {
                return;
            }

            if (AmmoTextBox.Text != "")
            {
                var VALUE = AmmoTextBox.Text;
                m.WriteMemory(AMMO_ADDRESS, "int", VALUE.ToString());
            }
        }
    }
}
