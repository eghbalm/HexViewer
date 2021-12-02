using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Management;

namespace DiskTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            List<String> result;
            var query = new WqlObjectQuery("SELECT * FROM Win32_DiskDrive");
            using (var searcher = new ManagementObjectSearcher(query))
            {
                result = searcher.Get()
                                 .OfType<ManagementObject>()
                                 .Select(o => o.Properties["DeviceID"].Value.ToString()+"  =  "+o.Properties["Caption"].Value.ToString())
                                 .ToList();
            }
            foreach (var item in result)
            {
                comboBox1.Items.Add(item);
            }
            comboBox1.Sorted = true;
            comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
