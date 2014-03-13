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
            HDDSize.Text = "HDD Size: " + getHDDSize("C") + " GiB";
            freeSpace.Text = "HDD Free Space: " + getHDDFreeSpace("C") + " GiB";
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
            double driveSize;
            double bytesToGig = 1073741824;
            double gigHDDSize;
            ManagementObject disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + drive + ":\"");
            disk.Get();
            driveSize = Convert.ToDouble(disk["Size"]);         //Converting to gig and to 2 decimals...
            gigHDDSize = driveSize / bytesToGig;
            gigHDDSize = System.Math.Round(gigHDDSize, 2);
            return Convert.ToString(gigHDDSize);
        }

        public double getHDDFreeSpace(string drive)
        {
            double freeSpace, gigFreeSpace;
            double bytesToGig = 1073741824;
            ManagementObject disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + drive + ":\"");
            disk.Get();
            freeSpace = Convert.ToDouble(disk["FreeSpace"]);
            gigFreeSpace = freeSpace / bytesToGig;
            gigFreeSpace = System.Math.Round(gigFreeSpace, 2);
            return Convert.ToDouble(gigFreeSpace);
        }
    }
}
