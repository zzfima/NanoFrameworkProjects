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
			this.btnRelay0On = new System.Windows.Forms.Button();
			this.btnRelay0Off = new System.Windows.Forms.Button();
			this.btnGetStatus = new System.Windows.Forms.Button();
			this.lblStatus = new System.Windows.Forms.Label();
			this.groupBoxRellays = new System.Windows.Forms.GroupBox();
			this.comboBoxComPorts = new System.Windows.Forms.ComboBox();
			this.groupBoxComPort = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.listBoxLogs = new System.Windows.Forms.ListBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBoxRellays.SuspendLayout();
			this.groupBoxComPort.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
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
			// btnRelay0On
			// 
			this.btnRelay0On.BackColor = System.Drawing.Color.Red;
			this.btnRelay0On.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRelay0On.Location = new System.Drawing.Point(13, 48);
			this.btnRelay0On.Margin = new System.Windows.Forms.Padding(4);
			this.btnRelay0On.Name = "btnRelay0On";
			this.btnRelay0On.Size = new System.Drawing.Size(161, 82);
			this.btnRelay0On.TabIndex = 7;
			this.btnRelay0On.Text = "Interlock On";
			this.btnRelay0On.UseVisualStyleBackColor = false;
			this.btnRelay0On.Click += new System.EventHandler(this.btnRelay0_On_Click);
			// 
			// btnRelay0Off
			// 
			this.btnRelay0Off.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnRelay0Off.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRelay0Off.Location = new System.Drawing.Point(199, 48);
			this.btnRelay0Off.Margin = new System.Windows.Forms.Padding(4);
			this.btnRelay0Off.Name = "btnRelay0Off";
			this.btnRelay0Off.Size = new System.Drawing.Size(161, 82);
			this.btnRelay0Off.TabIndex = 8;
			this.btnRelay0Off.Text = "Interlock off";
			this.btnRelay0Off.UseVisualStyleBackColor = false;
			this.btnRelay0Off.Click += new System.EventHandler(this.btnRelay0_Off_Click);
			// 
			// btnGetStatus
			// 
			this.btnGetStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnGetStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGetStatus.Location = new System.Drawing.Point(13, 144);
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
			this.lblStatus.Location = new System.Drawing.Point(194, 197);
			this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(37, 29);
			this.lblStatus.TabIndex = 24;
			this.lblStatus.Text = "---";
			// 
			// groupBoxRellays
			// 
			this.groupBoxRellays.Controls.Add(this.lblStatus);
			this.groupBoxRellays.Controls.Add(this.btnRelay0On);
			this.groupBoxRellays.Controls.Add(this.btnGetStatus);
			this.groupBoxRellays.Controls.Add(this.btnRelay0Off);
			this.groupBoxRellays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxRellays.Location = new System.Drawing.Point(16, 170);
			this.groupBoxRellays.Margin = new System.Windows.Forms.Padding(4);
			this.groupBoxRellays.Name = "groupBoxRellays";
			this.groupBoxRellays.Padding = new System.Windows.Forms.Padding(4);
			this.groupBoxRellays.Size = new System.Drawing.Size(373, 234);
			this.groupBoxRellays.TabIndex = 25;
			this.groupBoxRellays.TabStop = false;
			this.groupBoxRellays.Text = "Rellays control";
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
			this.groupBox1.Size = new System.Drawing.Size(456, 392);
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
			this.listBoxLogs.Size = new System.Drawing.Size(439, 323);
			this.listBoxLogs.TabIndex = 29;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(485, 28);
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(485, 815);
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
			this.groupBoxRellays.PerformLayout();
			this.groupBoxComPort.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnSetPort;
		private System.Windows.Forms.Button btnRelay0On;
		private System.Windows.Forms.Button btnRelay0Off;
		private System.Windows.Forms.Button btnGetStatus;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.GroupBox groupBoxRellays;
		private System.Windows.Forms.ComboBox comboBoxComPorts;
		private System.Windows.Forms.GroupBox groupBoxComPort;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox listBoxLogs;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
	}
}

