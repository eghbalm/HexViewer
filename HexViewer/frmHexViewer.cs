////////////////////////////////////////////////////////////////////////////////////////////////////
//HexViewer Created By Eghbal Mohammadi With VisualStudio 2010
//Email:eghbalm1362@gmail.com
//Date:4/6/2017
//Ver:0.0.2
////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HexViewer
{
    public partial class frmHexViewer : Form
    {
        string fileName;
        const int hexLen = 16, pagelen = 20;
        Font fnt = new Font("tahoma", 14);
        byte[] Ended;
        string[] addr;
        int EndedInt = 0;
        int lenBuffer = 0;

        public frmHexViewer()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string getNormalCount(string str)
        {
            string str1 = "";

            if (str.Length > 2)
            {
                str1 = str.Substring(str.Length - 2, 2);
            }
            else
            {
                str1 = str;
            }
            if (str1.Length == 1)
            {
                str1 = "0" + str1;
            }
            return str1;
        }
        private string getNormalAddress(string str)
        {
            string str1 = "";
            int len = str.Length;
            str1 = str;
            for (int i = len; i < 10; i++)
            {
                str1 = "0" + str1;
            }
            return str1;
        }

        string hexstr(int num)
        {
            string bh = "";
            switch (num)
            {
                case 0: bh = bh + "0"; break;
                case 1: bh = bh + "1"; break;
                case 2: bh = bh + "2"; break;
                case 3: bh = bh + "3"; break;
                case 4: bh = bh + "4"; break;
                case 5: bh = bh + "5"; break;
                case 6: bh = bh + "6"; break;
                case 7: bh = bh + "7"; break;
                case 8: bh = bh + "8"; break;
                case 9: bh = bh + "9"; break;
                case 10: bh = bh + "A"; break;
                case 11: bh = bh + "B"; break;
                case 12: bh = bh + "C"; break;
                case 13: bh = bh + "D"; break;
                case 14: bh = bh + "E"; break;
                case 15: bh = bh + "F"; break;
            }
            return bh;
        }
        string hexcr(int a)
        {
            string result = "";
            if (a < 15)
            {
                result = "0" + hexstr(a) + Convert.ToChar(32);
            }
            else
            {
                int rest = a % 16;
                int Div = a / 16;
                result = hexstr(Div) + hexstr(rest) + Convert.ToChar(32);
            }
            return result;
        }
        string geHex(int firstNum, int lastNum, byte[] Buffer)
        {
            string bin = "";
            for (int i = firstNum; i < lastNum; i++)
            {
                bin = bin + hexcr(Buffer[i]);
            }
            return bin;
        }
        string geBin(int firstNum, int lastNum, byte[] Buffer)
        {
            string bin = "";
            for (int i = firstNum; i < lastNum; i++)
            {
                if (Buffer[i] == 0 || (Buffer[i] > 0 && Buffer[i] < 33) || (Buffer[i] > 126 && Buffer[i] < 255))
                {
                    if (Buffer[i] != 32)
                    {
                        bin = bin + string.Format("{0,-2}", ".");
                    }
                    else
                    {
                        bin = bin + string.Format("{0,-2}", " ");
                    }

                }
                else
                {
                    bin = bin + string.Format("{0,-1}", Convert.ToChar(Buffer[i]));
                }
            }
            return bin;
        }
        private void OpenFiles(string fn)
        {
            lenBuffer = 0;
            EndedInt = 0;
            if (addr != null)
            {
                addr = null;
            }
            fileName = fn;
            this.Text = "Buffer Dump";
            tbAddr.Text = "";
            tbBin.Text = "";
            tbHex.Text = "";
            FileInfo fi = new FileInfo(fileName);
            EndedInt = (int)fi.Length % hexLen;
            lenBuffer = (int)fi.Length / hexLen;
            if (EndedInt > 0)
            {
                if (Ended != null)
                {
                    Ended = null;
                }
                Ended = new byte[EndedInt];
            }

            vsbScroll.Minimum = 0;
            vsbScroll.Value = 0;
            if (lenBuffer > 20)
            {
                vsbScroll.Enabled = true;
                vsbScroll.Maximum = lenBuffer - 18;
            }
            else
            {
                vsbScroll.Enabled = false;
            }
            addr = new string[lenBuffer + 1];
            for (int k = 0; k < addr.Length; k++)
            {
                addr[k] = (k * hexLen).ToString();
            }
            if (lenBuffer > pagelen)
            {
                scrollFile(0, pagelen);
            }
            else
            {
                scrollFile(0, lenBuffer);

            }
            fi = null;
        }

        private bool scrollFile(int ind, int itr)
        {
            int idx = 0;
            string strhex = "";
            string strbin = "";
            string straddr = "";
            FileStream fs = null;
            try
            {
                fs = File.Open(fileName, FileMode.Open);
            }
            catch (Exception)
            {
                try
                {
                    fs.Close();
                }
                catch { }
                MessageBox.Show("Can Not Open This File. This File Access Denied", "Error");
                return false;
            }

            if (ind < lenBuffer - pagelen)
            {
                for (int i = 0; i < itr; i++)
                {
                    fs.Seek((i * hexLen) + (hexLen * ind), SeekOrigin.Begin);
                    byte[] bt = new byte[hexLen];
                    if (fs.Read(bt, 0, bt.Length) > 0)
                    {
                        strhex = strhex + geHex(0, bt.Length, bt) + Environment.NewLine;
                        strbin = strbin + geBin(0, bt.Length, bt) + Environment.NewLine;
                        straddr = straddr + getNormalAddress(addr[(ind) + idx]) + Environment.NewLine;
                        idx++;
                    }
                    bt = null;
                }
            }
            else
            {
                for (int i = 0; i < lenBuffer - ind; i++)
                {
                    fs.Seek((i * hexLen) + (hexLen * ind), SeekOrigin.Begin);
                    byte[] bt = new byte[hexLen];
                    if (fs.Read(bt, 0, bt.Length) > 0)
                    {
                        strhex = strhex + geHex(0, bt.Length, bt) + Environment.NewLine;
                        strbin = strbin + geBin(0, bt.Length, bt) + Environment.NewLine;
                        straddr = straddr + getNormalAddress(addr[(ind) + idx]) + Environment.NewLine;
                        idx++;
                    }
                    bt = null;
                }
                if (EndedInt > 0)
                {

                    fs.Seek((lenBuffer * hexLen), SeekOrigin.Begin);
                    byte[] bat = new byte[EndedInt];
                    if (fs.Read(bat, 0, bat.Length) > 0)
                    {
                        strhex = strhex + geHex(0, bat.Length, bat);
                        strbin = strbin + geBin(0, bat.Length, bat);
                        straddr = straddr + getNormalAddress(addr[addr.Length - 1]);
                        idx++;
                    }
                    bat = null;
                }
            }
            tbHex.Text = strhex;
            tbBin.Text = strbin;
            tbAddr.Text = straddr;
            fs.Close();
            return true;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            scrollFile(vsbScroll.Value, pagelen);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (File.GetAttributes(ofd.FileName) != FileAttributes.Hidden)
                {
                    fileName = ofd.FileName;
                    OpenFiles(fileName);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbHex.Font = fnt;
            tbBin.Font = fnt;
            tbAddr.Font = fnt;
            label1.Font = fnt;
            label1.Text = "Adress";
            label2.Font = new Font("Arial", 14);
            label2.Text = "0   1   2   3   4   5   6   7   8   9   A   B   C   D   E   F";
        }
    }
}
