namespace InterlockManager
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnSetPort = new System.Windows.Forms.Button();
			this.btnDoorInterlockOn = new System.Windows.Forms.Button();
			this.btnDoorInterlockOff = new System.Windows.Forms.Button();
			this.btnGetStatus = new System.Windows.Forms.Button();
			this.lblStatus = new System.Windows.Forms.Label();
			this.groupBoxRellays = new System.Windows.Forms.GroupBox();
			this.btnLpInterlockOn = new System.Windows.Forms.Button();
			this.btnLpInterlockOff = new System.Windows.Forms.Button();
			this.comboBoxComPorts = new System.Windows.Forms.ComboBox();
			this.groupBoxComPort = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.listBoxLogs = new System.Windows.Forms.ListBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBoxRellays.SuspendLayout();
			this.groupBoxComPort.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSetPort
			// 
			this.btnSetPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSetPort.Location = new System.Drawing.Point(199, 32);
			this.btnSetPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSetPort.Name = "btnSetPort";
			this.btnSetPort.Size = new System.Drawing.Size(161, 82);
			this.btnSetPort.TabIndex = 5;
			this.btnSetPort.Text = "Set COM port";
			this.btnSetPort.UseVisualStyleBackColor = true;
			this.btnSetPort.Click += new System.EventHandler(this.btnSetPort_Click);
			// 
			// btnDoorInterlockOn
			// 
			this.btnDoorInterlockOn.BackColor = System.Drawing.Color.Red;
			this.btnDoorInterlockOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDoorInterlockOn.Location = new System.Drawing.Point(13, 48);
			this.btnDoorInterlockOn.Margin = new System.Windows.Forms.Padding(4);
			this.btnDoorInterlockOn.Name = "btnDoorInterlockOn";
			this.btnDoorInterlockOn.Size = new System.Drawing.Size(161, 82);
			this.btnDoorInterlockOn.TabIndex = 7;
			this.btnDoorInterlockOn.Text = "Interlock On Door";
			this.btnDoorInterlockOn.UseVisualStyleBackColor = false;
			this.btnDoorInterlockOn.Click += new System.EventHandler(this.btnDoorInterlockOn_Click);
			// 
			// btnDoorInterlockOff
			// 
			this.btnDoorInterlockOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnDoorInterlockOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDoorInterlockOff.Location = new System.Drawing.Point(15, 138);
			this.btnDoorInterlockOff.Margin = new System.Windows.Forms.Padding(4);
			this.btnDoorInterlockOff.Name = "btnDoorInterlockOff";
			this.btnDoorInterlockOff.Size = new System.Drawing.Size(161, 82);
			this.btnDoorInterlockOff.TabIndex = 8;
			this.btnDoorInterlockOff.Text = "Interlock off Door";
			this.btnDoorInterlockOff.UseVisualStyleBackColor = false;
			this.btnDoorInterlockOff.Click += new System.EventHandler(this.btnDoorInterlockOff_Click);
			// 
			// btnGetStatus
			// 
			this.btnGetStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnGetStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGetStatus.Location = new System.Drawing.Point(23, 57);
			this.btnGetStatus.Margin = new System.Windows.Forms.Padding(4);
			this.btnGetStatus.Name = "btnGetStatus";
			this.btnGetStatus.Size = new System.Drawing.Size(161, 82);
			this.btnGetStatus.TabIndex = 23;
			this.btnGetStatus.Text = "Get Relay Statuses";
			this.btnGetStatus.UseVisualStyleBackColor = false;
			this.btnGetStatus.Click += new System.EventHandler(this.btnGetStatus_Click);
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatus.Location = new System.Drawing.Point(18, 191);
			this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(37, 29);
			this.lblStatus.TabIndex = 24;
			this.lblStatus.Text = "---";
			// 
			// groupBoxRellays
			// 
			this.groupBoxRellays.Controls.Add(this.btnLpInterlockOn);
			this.groupBoxRellays.Controls.Add(this.btnLpInterlockOff);
			this.groupBoxRellays.Controls.Add(this.btnDoorInterlockOn);
			this.groupBoxRellays.Controls.Add(this.btnDoorInterlockOff);
			this.groupBoxRellays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxRellays.Location = new System.Drawing.Point(16, 170);
			this.groupBoxRellays.Margin = new System.Windows.Forms.Padding(4);
			this.groupBoxRellays.Name = "groupBoxRellays";
			this.groupBoxRellays.Padding = new System.Windows.Forms.Padding(4);
			this.groupBoxRellays.Size = new System.Drawing.Size(360, 234);
			this.groupBoxRellays.TabIndex = 25;
			this.groupBoxRellays.TabStop = false;
			this.groupBoxRellays.Text = "Rellays control";
			// 
			// btnLpInterlockOn
			// 
			this.btnLpInterlockOn.BackColor = System.Drawing.Color.Red;
			this.btnLpInterlockOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLpInterlockOn.Location = new System.Drawing.Point(182, 48);
			this.btnLpInterlockOn.Margin = new System.Windows.Forms.Padding(4);
			this.btnLpInterlockOn.Name = "btnLpInterlockOn";
			this.btnLpInterlockOn.Size = new System.Drawing.Size(161, 82);
			this.btnLpInterlockOn.TabIndex = 25;
			this.btnLpInterlockOn.Text = "Interlock On LP";
			this.btnLpInterlockOn.UseVisualStyleBackColor = false;
			this.btnLpInterlockOn.Click += new System.EventHandler(this.btnLpInterlockOn_Click);
			// 
			// btnLpInterlockOff
			// 
			this.btnLpInterlockOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnLpInterlockOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLpInterlockOff.Location = new System.Drawing.Point(184, 138);
			this.btnLpInterlockOff.Margin = new System.Windows.Forms.Padding(4);
			this.btnLpInterlockOff.Name = "btnLpInterlockOff";
			this.btnLpInterlockOff.Size = new System.Drawing.Size(161, 82);
			this.btnLpInterlockOff.TabIndex = 26;
			this.btnLpInterlockOff.Text = "Interlock off LP";
			this.btnLpInterlockOff.UseVisualStyleBackColor = false;
			this.btnLpInterlockOff.Click += new System.EventHandler(this.btnLpInterlockOff_Click);
			// 
			// comboBoxComPorts
			// 
			this.comboBoxComPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxComPorts.FormattingEnabled = true;
			this.comboBoxComPorts.Location = new System.Drawing.Point(15, 32);
			this.comboBoxComPorts.Name = "comboBoxComPorts";
			this.comboBoxComPorts.Size = new System.Drawing.Size(159, 37);
			this.comboBoxComPorts.TabIndex = 26;
			// 
			// groupBoxComPort
			// 
			this.groupBoxComPort.Controls.Add(this.btnSetPort);
			this.groupBoxComPort.Controls.Add(this.comboBoxComPorts);
			this.groupBoxComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxComPort.Location = new System.Drawing.Point(16, 37);
			this.groupBoxComPort.Name = "groupBoxComPort";
			this.groupBoxComPort.Size = new System.Drawing.Size(373, 126);
			this.groupBoxComPort.TabIndex = 27;
			this.groupBoxComPort.TabStop = false;
			this.groupBoxComPort.Text = "COM Port";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.listBoxLogs);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(16, 411);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(743, 392);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Logs";
			// 
			// listBoxLogs
			// 
			this.listBoxLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxLogs.FormattingEnabled = true;
			this.listBoxLogs.ItemHeight = 29;
			this.listBoxLogs.Location = new System.Drawing.Point(11, 50);
			this.listBoxLogs.Name = "listBoxLogs";
			this.listBoxLogs.ScrollAlwaysVisible = true;
			this.listBoxLogs.Size = new System.Drawing.Size(709, 323);
			this.listBoxLogs.TabIndex = 29;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(771, 28);
			this.menuStrip1.TabIndex = 29;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
			this.helpToolStripMenuItem.Text = "Help";
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnGetStatus);
			this.groupBox2.Controls.Add(this.lblStatus);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.groupBox2.Location = new System.Drawing.Point(395, 170);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(364, 234);
			this.groupBox2.TabIndex = 30;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Status";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(771, 815);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBoxComPort);
			this.Controls.Add(this.groupBoxRellays);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.Text = "Interlock Commander";
			this.groupBoxRellays.ResumeLayout(false);
			this.groupBoxComPort.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnSetPort;
		private System.Windows.Forms.Button btnDoorInterlockOn;
		private System.Windows.Forms.Button btnDoorInterlockOff;
		private System.Windows.Forms.Button btnGetStatus;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.GroupBox groupBoxRellays;
		private System.Windows.Forms.ComboBox comboBoxComPorts;
		private System.Windows.Forms.GroupBox groupBoxComPort;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox listBoxLogs;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.Button btnLpInterlockOn;
		private System.Windows.Forms.Button btnLpInterlockOff;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}

