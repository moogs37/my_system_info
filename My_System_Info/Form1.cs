using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Management.Instrumentation;



namespace My_System_Info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "My System Info v 0.1";
            SerialNumber.Text = "Serial Number: " + GetHDDSerialNumber("C");
            HDDSize.Text = "HDD Size: " + getHDDSize("C");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public string GetHDDSerialNumber(string drive)
        {
            //Assuming OS drive is on C, if not we would need this...
            //if (drive == "" || drive == null)
            //{
            //    drive = "C";
            //}
            ManagementObject disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + drive + ":\"");
            disk.Get();
            return disk["VolumeSerialNumber"].ToString();
        }
        public string getHDDSize(string drive)
        {
            ManagementObject disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + drive + ":\"");
            disk.Get();
            return Convert.ToString(disk["Size"]);
        }
    }
}
