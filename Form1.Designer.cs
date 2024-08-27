namespace ELE_APP_FF_2024
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
            this.components = new System.ComponentModel.Container();
            this.listGfxType = new System.Windows.Forms.ListBox();
            this.StateList = new System.Windows.Forms.ListBox();
            this.rdAllianceN = new System.Windows.Forms.RadioButton();
            this.raAllianceP = new System.Windows.Forms.RadioButton();
            this.dgvStateTally = new System.Windows.Forms.DataGridView();
            this.slNo = new System.Windows.Forms.TextBox();
            this.StateEname = new System.Windows.Forms.TextBox();
            this.PartyNo = new System.Windows.Forms.TextBox();
            this.TotalStateSeats = new System.Windows.Forms.TextBox();
            this.StateNameBangla = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.cmbVizHost = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tbParty1 = new System.Windows.Forms.TextBox();
            this.tbParty2 = new System.Windows.Forms.TextBox();
            this.tbParty3 = new System.Windows.Forms.TextBox();
            this.tbParty4 = new System.Windows.Forms.TextBox();
            this.tbParty5 = new System.Windows.Forms.TextBox();
            this.tbSeats5 = new System.Windows.Forms.TextBox();
            this.tbSeats4 = new System.Windows.Forms.TextBox();
            this.tbSeats3 = new System.Windows.Forms.TextBox();
            this.tbSeats2 = new System.Windows.Forms.TextBox();
            this.tbSeats1 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblScene = new System.Windows.Forms.Label();
            this.tbSlot = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkbox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStateTally)).BeginInit();
            this.SuspendLayout();
            // 
            // listGfxType
            // 
            this.listGfxType.BackColor = System.Drawing.Color.DarkTurquoise;
            this.listGfxType.FormattingEnabled = true;
            this.listGfxType.Items.AddRange(new object[] {
            "DVE",
            "WALL"});
            this.listGfxType.Location = new System.Drawing.Point(11, 68);
            this.listGfxType.Name = "listGfxType";
            this.listGfxType.Size = new System.Drawing.Size(120, 95);
            this.listGfxType.TabIndex = 0;
            this.listGfxType.SelectedIndexChanged += new System.EventHandler(this.listGfxType_SelectedIndexChanged);
            // 
            // StateList
            // 
            this.StateList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.StateList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateList.FormattingEnabled = true;
            this.StateList.ItemHeight = 18;
            this.StateList.Items.AddRange(new object[] {
            "StateList"});
            this.StateList.Location = new System.Drawing.Point(137, 68);
            this.StateList.Name = "StateList";
            this.StateList.Size = new System.Drawing.Size(412, 382);
            this.StateList.TabIndex = 1;
            this.StateList.SelectedIndexChanged += new System.EventHandler(this.StateList_SelectedIndexChanged);
            // 
            // rdAllianceN
            // 
            this.rdAllianceN.AutoSize = true;
            this.rdAllianceN.BackColor = System.Drawing.Color.Yellow;
            this.rdAllianceN.Location = new System.Drawing.Point(11, 212);
            this.rdAllianceN.Name = "rdAllianceN";
            this.rdAllianceN.Size = new System.Drawing.Size(115, 17);
            this.rdAllianceN.TabIndex = 2;
            this.rdAllianceN.TabStop = true;
            this.rdAllianceN.Text = "AllianceNumberGfx";
            this.rdAllianceN.UseVisualStyleBackColor = false;
            // 
            // raAllianceP
            // 
            this.raAllianceP.AutoSize = true;
            this.raAllianceP.BackColor = System.Drawing.Color.Yellow;
            this.raAllianceP.Location = new System.Drawing.Point(11, 257);
            this.raAllianceP.Name = "raAllianceP";
            this.raAllianceP.Size = new System.Drawing.Size(93, 17);
            this.raAllianceP.TabIndex = 3;
            this.raAllianceP.TabStop = true;
            this.raAllianceP.Text = "AlliancePieGfx";
            this.raAllianceP.UseVisualStyleBackColor = false;
            this.raAllianceP.CheckedChanged += new System.EventHandler(this.raAllianceP_CheckedChanged);
            // 
            // dgvStateTally
            // 
            this.dgvStateTally.BackgroundColor = System.Drawing.Color.White;
            this.dgvStateTally.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStateTally.Location = new System.Drawing.Point(570, 300);
            this.dgvStateTally.Name = "dgvStateTally";
            this.dgvStateTally.Size = new System.Drawing.Size(421, 150);
            this.dgvStateTally.TabIndex = 4;
            // 
            // slNo
            // 
            this.slNo.BackColor = System.Drawing.Color.OliveDrab;
            this.slNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slNo.ForeColor = System.Drawing.Color.Gold;
            this.slNo.Location = new System.Drawing.Point(23, 31);
            this.slNo.Name = "slNo";
            this.slNo.Size = new System.Drawing.Size(59, 24);
            this.slNo.TabIndex = 5;
            this.slNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StateEname
            // 
            this.StateEname.BackColor = System.Drawing.Color.OliveDrab;
            this.StateEname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateEname.ForeColor = System.Drawing.Color.Gold;
            this.StateEname.Location = new System.Drawing.Point(99, 31);
            this.StateEname.Name = "StateEname";
            this.StateEname.Size = new System.Drawing.Size(128, 24);
            this.StateEname.TabIndex = 6;
            this.StateEname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PartyNo
            // 
            this.PartyNo.BackColor = System.Drawing.Color.OliveDrab;
            this.PartyNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartyNo.ForeColor = System.Drawing.Color.Gold;
            this.PartyNo.Location = new System.Drawing.Point(248, 31);
            this.PartyNo.Name = "PartyNo";
            this.PartyNo.Size = new System.Drawing.Size(59, 24);
            this.PartyNo.TabIndex = 7;
            this.PartyNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalStateSeats
            // 
            this.TotalStateSeats.BackColor = System.Drawing.Color.OliveDrab;
            this.TotalStateSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalStateSeats.ForeColor = System.Drawing.Color.Gold;
            this.TotalStateSeats.Location = new System.Drawing.Point(329, 31);
            this.TotalStateSeats.Name = "TotalStateSeats";
            this.TotalStateSeats.Size = new System.Drawing.Size(59, 24);
            this.TotalStateSeats.TabIndex = 8;
            this.TotalStateSeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StateNameBangla
            // 
            this.StateNameBangla.BackColor = System.Drawing.Color.OliveDrab;
            this.StateNameBangla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateNameBangla.ForeColor = System.Drawing.Color.Gold;
            this.StateNameBangla.Location = new System.Drawing.Point(418, 31);
            this.StateNameBangla.Name = "StateNameBangla";
            this.StateNameBangla.Size = new System.Drawing.Size(150, 24);
            this.StateNameBangla.TabIndex = 9;
            this.StateNameBangla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbIP
            // 
            this.tbIP.BackColor = System.Drawing.Color.OliveDrab;
            this.tbIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIP.ForeColor = System.Drawing.Color.Gold;
            this.tbIP.Location = new System.Drawing.Point(675, 31);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(128, 24);
            this.tbIP.TabIndex = 10;
            this.tbIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbVizHost
            // 
            this.cmbVizHost.BackColor = System.Drawing.Color.OliveDrab;
            this.cmbVizHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVizHost.ForeColor = System.Drawing.Color.Gold;
            this.cmbVizHost.FormattingEnabled = true;
            this.cmbVizHost.Location = new System.Drawing.Point(809, 31);
            this.cmbVizHost.Name = "cmbVizHost";
            this.cmbVizHost.Size = new System.Drawing.Size(182, 26);
            this.cmbVizHost.TabIndex = 11;
            this.cmbVizHost.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.DarkOrange;
            this.textBox7.ForeColor = System.Drawing.Color.Red;
            this.textBox7.Location = new System.Drawing.Point(498, 79);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(0, 20);
            this.textBox7.TabIndex = 12;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbParty1
            // 
            this.tbParty1.BackColor = System.Drawing.Color.DarkOrange;
            this.tbParty1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbParty1.ForeColor = System.Drawing.Color.DarkBlue;
            this.tbParty1.Location = new System.Drawing.Point(575, 68);
            this.tbParty1.Name = "tbParty1";
            this.tbParty1.ReadOnly = true;
            this.tbParty1.Size = new System.Drawing.Size(76, 29);
            this.tbParty1.TabIndex = 13;
            this.tbParty1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbParty1.WordWrap = false;
            // 
            // tbParty2
            // 
            this.tbParty2.BackColor = System.Drawing.Color.DarkOrange;
            this.tbParty2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbParty2.ForeColor = System.Drawing.Color.DarkBlue;
            this.tbParty2.Location = new System.Drawing.Point(575, 105);
            this.tbParty2.Name = "tbParty2";
            this.tbParty2.ReadOnly = true;
            this.tbParty2.Size = new System.Drawing.Size(76, 29);
            this.tbParty2.TabIndex = 14;
            this.tbParty2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbParty3
            // 
            this.tbParty3.BackColor = System.Drawing.Color.DarkOrange;
            this.tbParty3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbParty3.ForeColor = System.Drawing.Color.DarkBlue;
            this.tbParty3.Location = new System.Drawing.Point(575, 140);
            this.tbParty3.Name = "tbParty3";
            this.tbParty3.ReadOnly = true;
            this.tbParty3.Size = new System.Drawing.Size(76, 29);
            this.tbParty3.TabIndex = 15;
            this.tbParty3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbParty4
            // 
            this.tbParty4.BackColor = System.Drawing.Color.DarkOrange;
            this.tbParty4.Enabled = false;
            this.tbParty4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbParty4.ForeColor = System.Drawing.Color.DarkBlue;
            this.tbParty4.Location = new System.Drawing.Point(575, 184);
            this.tbParty4.Name = "tbParty4";
            this.tbParty4.ReadOnly = true;
            this.tbParty4.Size = new System.Drawing.Size(76, 29);
            this.tbParty4.TabIndex = 16;
            this.tbParty4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbParty4.WordWrap = false;
            // 
            // tbParty5
            // 
            this.tbParty5.BackColor = System.Drawing.Color.DarkOrange;
            this.tbParty5.Enabled = false;
            this.tbParty5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbParty5.ForeColor = System.Drawing.Color.DarkBlue;
            this.tbParty5.Location = new System.Drawing.Point(575, 225);
            this.tbParty5.Name = "tbParty5";
            this.tbParty5.ReadOnly = true;
            this.tbParty5.Size = new System.Drawing.Size(76, 29);
            this.tbParty5.TabIndex = 17;
            this.tbParty5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSeats5
            // 
            this.tbSeats5.BackColor = System.Drawing.Color.Gold;
            this.tbSeats5.Enabled = false;
            this.tbSeats5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSeats5.ForeColor = System.Drawing.Color.Black;
            this.tbSeats5.Location = new System.Drawing.Point(675, 225);
            this.tbSeats5.Name = "tbSeats5";
            this.tbSeats5.ReadOnly = true;
            this.tbSeats5.Size = new System.Drawing.Size(76, 29);
            this.tbSeats5.TabIndex = 23;
            this.tbSeats5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSeats4
            // 
            this.tbSeats4.BackColor = System.Drawing.Color.Gold;
            this.tbSeats4.Enabled = false;
            this.tbSeats4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSeats4.ForeColor = System.Drawing.Color.Black;
            this.tbSeats4.Location = new System.Drawing.Point(675, 184);
            this.tbSeats4.Name = "tbSeats4";
            this.tbSeats4.ReadOnly = true;
            this.tbSeats4.Size = new System.Drawing.Size(76, 29);
            this.tbSeats4.TabIndex = 22;
            this.tbSeats4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSeats4.WordWrap = false;
            // 
            // tbSeats3
            // 
            this.tbSeats3.BackColor = System.Drawing.Color.Gold;
            this.tbSeats3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSeats3.ForeColor = System.Drawing.Color.Black;
            this.tbSeats3.Location = new System.Drawing.Point(675, 140);
            this.tbSeats3.Name = "tbSeats3";
            this.tbSeats3.ReadOnly = true;
            this.tbSeats3.Size = new System.Drawing.Size(76, 29);
            this.tbSeats3.TabIndex = 21;
            this.tbSeats3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSeats2
            // 
            this.tbSeats2.BackColor = System.Drawing.Color.Gold;
            this.tbSeats2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSeats2.ForeColor = System.Drawing.Color.Black;
            this.tbSeats2.Location = new System.Drawing.Point(675, 105);
            this.tbSeats2.Name = "tbSeats2";
            this.tbSeats2.ReadOnly = true;
            this.tbSeats2.Size = new System.Drawing.Size(76, 29);
            this.tbSeats2.TabIndex = 20;
            this.tbSeats2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSeats1
            // 
            this.tbSeats1.BackColor = System.Drawing.Color.Gold;
            this.tbSeats1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSeats1.ForeColor = System.Drawing.Color.Black;
            this.tbSeats1.Location = new System.Drawing.Point(675, 68);
            this.tbSeats1.Name = "tbSeats1";
            this.tbSeats1.ReadOnly = true;
            this.tbSeats1.Size = new System.Drawing.Size(76, 29);
            this.tbSeats1.TabIndex = 19;
            this.tbSeats1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.Color.Gold;
            this.textBox18.Enabled = false;
            this.textBox18.ForeColor = System.Drawing.Color.Black;
            this.textBox18.Location = new System.Drawing.Point(675, 79);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(0, 20);
            this.textBox18.TabIndex = 18;
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(924, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 49);
            this.button1.TabIndex = 24;
            this.button1.Text = "ON AIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblScene
            // 
            this.lblScene.AutoSize = true;
            this.lblScene.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScene.Location = new System.Drawing.Point(28, 528);
            this.lblScene.Name = "lblScene";
            this.lblScene.Size = new System.Drawing.Size(66, 24);
            this.lblScene.TabIndex = 25;
            this.lblScene.Text = "label1";
            // 
            // tbSlot
            // 
            this.tbSlot.BackColor = System.Drawing.Color.OliveDrab;
            this.tbSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSlot.ForeColor = System.Drawing.Color.Gold;
            this.tbSlot.Location = new System.Drawing.Point(592, 31);
            this.tbSlot.Name = "tbSlot";
            this.tbSlot.Size = new System.Drawing.Size(59, 24);
            this.tbSlot.TabIndex = 26;
            this.tbSlot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkbox1
            // 
            this.checkbox1.AutoSize = true;
            this.checkbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox1.Location = new System.Drawing.Point(24, 475);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(93, 29);
            this.checkbox1.TabIndex = 27;
            this.checkbox1.Text = "LOOP";
            this.checkbox1.UseVisualStyleBackColor = true;
            this.checkbox1.CheckedChanged += new System.EventHandler(this.checkbox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1120, 561);
            this.Controls.Add(this.checkbox1);
            this.Controls.Add(this.tbSlot);
            this.Controls.Add(this.lblScene);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbSeats5);
            this.Controls.Add(this.tbSeats4);
            this.Controls.Add(this.tbSeats3);
            this.Controls.Add(this.tbSeats2);
            this.Controls.Add(this.tbSeats1);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.tbParty5);
            this.Controls.Add(this.tbParty4);
            this.Controls.Add(this.tbParty3);
            this.Controls.Add(this.tbParty2);
            this.Controls.Add(this.tbParty1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.cmbVizHost);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.StateNameBangla);
            this.Controls.Add(this.TotalStateSeats);
            this.Controls.Add(this.PartyNo);
            this.Controls.Add(this.StateEname);
            this.Controls.Add(this.slNo);
            this.Controls.Add(this.dgvStateTally);
            this.Controls.Add(this.raAllianceP);
            this.Controls.Add(this.rdAllianceN);
            this.Controls.Add(this.StateList);
            this.Controls.Add(this.listGfxType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStateTally)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listGfxType;
        private System.Windows.Forms.ListBox StateList;
        private System.Windows.Forms.RadioButton rdAllianceN;
        private System.Windows.Forms.RadioButton raAllianceP;
        private System.Windows.Forms.DataGridView dgvStateTally;
        private System.Windows.Forms.TextBox slNo;
        private System.Windows.Forms.TextBox StateEname;
        private System.Windows.Forms.TextBox PartyNo;
        private System.Windows.Forms.TextBox TotalStateSeats;
        private System.Windows.Forms.TextBox StateNameBangla;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.ComboBox cmbVizHost;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox tbParty1;
        private System.Windows.Forms.TextBox tbParty2;
        private System.Windows.Forms.TextBox tbParty3;
        private System.Windows.Forms.TextBox tbParty4;
        private System.Windows.Forms.TextBox tbParty5;
        private System.Windows.Forms.TextBox tbSeats5;
        private System.Windows.Forms.TextBox tbSeats4;
        private System.Windows.Forms.TextBox tbSeats3;
        private System.Windows.Forms.TextBox tbSeats2;
        private System.Windows.Forms.TextBox tbSeats1;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblScene;
        private System.Windows.Forms.TextBox tbSlot;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkbox1;
    }
}

