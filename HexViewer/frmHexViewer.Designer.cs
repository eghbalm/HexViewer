namespace HexViewer
{
    partial class frmHexViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBin = new System.Windows.Forms.TextBox();
            this.tbAddr = new System.Windows.Forms.TextBox();
            this.vsbScroll = new System.Windows.Forms.VScrollBar();
            this.tbHex = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbBin);
            this.panel1.Controls.Add(this.tbAddr);
            this.panel1.Controls.Add(this.vsbScroll);
            this.panel1.Controls.Add(this.tbHex);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 518);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(154, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Address";
            // 
            // tbBin
            // 
            this.tbBin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbBin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbBin.Location = new System.Drawing.Point(647, 27);
            this.tbBin.Multiline = true;
            this.tbBin.Name = "tbBin";
            this.tbBin.ReadOnly = true;
            this.tbBin.Size = new System.Drawing.Size(232, 473);
            this.tbBin.TabIndex = 6;
            // 
            // tbAddr
            // 
            this.tbAddr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbAddr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAddr.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbAddr.Location = new System.Drawing.Point(10, 27);
            this.tbAddr.Multiline = true;
            this.tbAddr.Name = "tbAddr";
            this.tbAddr.ReadOnly = true;
            this.tbAddr.Size = new System.Drawing.Size(134, 473);
            this.tbAddr.TabIndex = 5;
            // 
            // vsbScroll
            // 
            this.vsbScroll.Enabled = false;
            this.vsbScroll.LargeChange = 1;
            this.vsbScroll.Location = new System.Drawing.Point(882, 27);
            this.vsbScroll.Maximum = 0;
            this.vsbScroll.Name = "vsbScroll";
            this.vsbScroll.Size = new System.Drawing.Size(17, 473);
            this.vsbScroll.TabIndex = 4;
            this.vsbScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // tbHex
            // 
            this.tbHex.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbHex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHex.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbHex.Location = new System.Drawing.Point(150, 27);
            this.tbHex.Multiline = true;
            this.tbHex.Name = "tbHex";
            this.tbHex.ReadOnly = true;
            this.tbHex.Size = new System.Drawing.Size(495, 473);
            this.tbHex.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(18, 543);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(84, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // frmHexViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 579);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.panel1);
            this.Name = "frmHexViewer";
            this.Text = "frmHexViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBin;
        private System.Windows.Forms.TextBox tbAddr;
        private System.Windows.Forms.VScrollBar vsbScroll;
        private System.Windows.Forms.TextBox tbHex;
        private System.Windows.Forms.Button btnOpen;
    }
}

