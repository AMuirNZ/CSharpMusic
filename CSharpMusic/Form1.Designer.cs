namespace CSharpMusic
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGVOwner = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGVCD = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DGVCDTrack = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtCDName = new System.Windows.Forms.TextBox();
            this.txtCDArtist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGenre2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbgenre = new System.Windows.Forms.ListBox();
            this.txtCDGenre = new System.Windows.Forms.TextBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.txtCDName2 = new System.Windows.Forms.Label();
            this.grdgrd = new System.Windows.Forms.Label();
            this.txtTrackID = new System.Windows.Forms.TextBox();
            this.txtTrackDuration = new System.Windows.Forms.Label();
            this.txtTrackID1 = new System.Windows.Forms.Label();
            this.txtTrackName = new System.Windows.Forms.Label();
            this.txtOwnerID = new System.Windows.Forms.TextBox();
            this.txtCDID = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOwner)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCD)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCDTrack)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(515, 207);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVOwner);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(507, 181);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Owner";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGVOwner
            // 
            this.DGVOwner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVOwner.Location = new System.Drawing.Point(3, 3);
            this.DGVOwner.Name = "DGVOwner";
            this.DGVOwner.Size = new System.Drawing.Size(501, 175);
            this.DGVOwner.TabIndex = 0;
            this.DGVOwner.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVOwner_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVCD);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(507, 181);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CD";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGVCD
            // 
            this.DGVCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCD.Location = new System.Drawing.Point(3, 3);
            this.DGVCD.Name = "DGVCD";
            this.DGVCD.Size = new System.Drawing.Size(501, 175);
            this.DGVCD.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DGVCDTrack);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(507, 181);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DGVCDTrack
            // 
            this.DGVCDTrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCDTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCDTrack.Location = new System.Drawing.Point(3, 3);
            this.DGVCDTrack.Name = "DGVCDTrack";
            this.DGVCDTrack.Size = new System.Drawing.Size(501, 175);
            this.DGVCDTrack.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 359);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 359);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 20);
            this.textBox2.TabIndex = 3;
            // 
            // txtCDName
            // 
            this.txtCDName.Location = new System.Drawing.Point(16, 323);
            this.txtCDName.Name = "txtCDName";
            this.txtCDName.Size = new System.Drawing.Size(223, 20);
            this.txtCDName.TabIndex = 4;
            // 
            // txtCDArtist
            // 
            this.txtCDArtist.Location = new System.Drawing.Point(261, 323);
            this.txtCDArtist.Name = "txtCDArtist";
            this.txtCDArtist.Size = new System.Drawing.Size(100, 20);
            this.txtCDArtist.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name";
            // 
            // txtGenre2
            // 
            this.txtGenre2.AutoSize = true;
            this.txtGenre2.Location = new System.Drawing.Point(415, 306);
            this.txtGenre2.Name = "txtGenre2";
            this.txtGenre2.Size = new System.Drawing.Size(36, 13);
            this.txtGenre2.TabIndex = 10;
            this.txtGenre2.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Last Name";
            // 
            // lbgenre
            // 
            this.lbgenre.FormattingEnabled = true;
            this.lbgenre.Location = new System.Drawing.Point(500, 279);
            this.lbgenre.Name = "lbgenre";
            this.lbgenre.Size = new System.Drawing.Size(120, 95);
            this.lbgenre.TabIndex = 14;
            this.lbgenre.SelectedIndexChanged += new System.EventHandler(this.lbGenre_SelectedIndexChanged);
            // 
            // txtCDGenre
            // 
            this.txtCDGenre.Location = new System.Drawing.Point(394, 323);
            this.txtCDGenre.Multiline = true;
            this.txtCDGenre.Name = "txtCDGenre";
            this.txtCDGenre.Size = new System.Drawing.Size(100, 20);
            this.txtCDGenre.TabIndex = 15;
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(16, 279);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(100, 20);
            this.txtFN.TabIndex = 16;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(134, 279);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(100, 20);
            this.txtLN.TabIndex = 17;
            // 
            // txtCDName2
            // 
            this.txtCDName2.AutoSize = true;
            this.txtCDName2.Location = new System.Drawing.Point(16, 307);
            this.txtCDName2.Name = "txtCDName2";
            this.txtCDName2.Size = new System.Drawing.Size(53, 13);
            this.txtCDName2.TabIndex = 19;
            this.txtCDName2.Text = "CD Name";
            // 
            // grdgrd
            // 
            this.grdgrd.AutoSize = true;
            this.grdgrd.Location = new System.Drawing.Point(272, 306);
            this.grdgrd.Name = "grdgrd";
            this.grdgrd.Size = new System.Drawing.Size(30, 13);
            this.grdgrd.TabIndex = 20;
            this.grdgrd.Text = "Artist";
            // 
            // txtTrackID
            // 
            this.txtTrackID.Location = new System.Drawing.Point(394, 359);
            this.txtTrackID.Name = "txtTrackID";
            this.txtTrackID.Size = new System.Drawing.Size(100, 20);
            this.txtTrackID.TabIndex = 21;
            // 
            // txtTrackDuration
            // 
            this.txtTrackDuration.AutoSize = true;
            this.txtTrackDuration.Location = new System.Drawing.Point(258, 343);
            this.txtTrackDuration.Name = "txtTrackDuration";
            this.txtTrackDuration.Size = new System.Drawing.Size(78, 13);
            this.txtTrackDuration.TabIndex = 22;
            this.txtTrackDuration.Text = "Track Duration";
            // 
            // txtTrackID1
            // 
            this.txtTrackID1.AutoSize = true;
            this.txtTrackID1.Location = new System.Drawing.Point(391, 343);
            this.txtTrackID1.Name = "txtTrackID1";
            this.txtTrackID1.Size = new System.Drawing.Size(46, 13);
            this.txtTrackID1.TabIndex = 23;
            this.txtTrackID1.Text = "TrackID";
            // 
            // txtTrackName
            // 
            this.txtTrackName.AutoSize = true;
            this.txtTrackName.Location = new System.Drawing.Point(16, 343);
            this.txtTrackName.Name = "txtTrackName";
            this.txtTrackName.Size = new System.Drawing.Size(66, 13);
            this.txtTrackName.TabIndex = 24;
            this.txtTrackName.Text = "Track Name";
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Location = new System.Drawing.Point(569, 95);
            this.txtOwnerID.Multiline = true;
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.Size = new System.Drawing.Size(51, 20);
            this.txtOwnerID.TabIndex = 25;
            // 
            // txtCDID
            // 
            this.txtCDID.Location = new System.Drawing.Point(569, 132);
            this.txtCDID.Multiline = true;
            this.txtCDID.Name = "txtCDID";
            this.txtCDID.Size = new System.Drawing.Size(51, 20);
            this.txtCDID.TabIndex = 26;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(569, 167);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(51, 20);
            this.textBox5.TabIndex = 27;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(9, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 23);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Delete Track";
            this.button2.UseVisualStyleBackColor = true;
            //this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(107, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Update All";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 23);
            this.button4.TabIndex = 32;
            this.button4.Text = "Delete Owner";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(107, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 33;
            this.button5.Text = "Delete CD";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Location = new System.Drawing.Point(341, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 62);
            this.panel1.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtCDID);
            this.Controls.Add(this.txtOwnerID);
            this.Controls.Add(this.txtTrackName);
            this.Controls.Add(this.txtTrackID1);
            this.Controls.Add(this.txtTrackDuration);
            this.Controls.Add(this.txtTrackID);
            this.Controls.Add(this.grdgrd);
            this.Controls.Add(this.txtCDName2);
            this.Controls.Add(this.txtLN);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.txtCDGenre);
            this.Controls.Add(this.lbgenre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGenre2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCDArtist);
            this.Controls.Add(this.txtCDName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVOwner)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCD)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCDTrack)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DGVOwner;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtCDName;
        private System.Windows.Forms.TextBox txtCDArtist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtGenre2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbgenre;
        private System.Windows.Forms.TextBox txtCDGenre;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.DataGridView DGVCD;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView DGVCDTrack;
        private System.Windows.Forms.Label txtCDName2;
        private System.Windows.Forms.Label grdgrd;
        private System.Windows.Forms.TextBox txtTrackID;
        private System.Windows.Forms.Label txtTrackDuration;
        private System.Windows.Forms.Label txtTrackID1;
        private System.Windows.Forms.Label txtTrackName;
        private System.Windows.Forms.TextBox txtOwnerID;
        private System.Windows.Forms.TextBox txtCDID;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
    }
}

