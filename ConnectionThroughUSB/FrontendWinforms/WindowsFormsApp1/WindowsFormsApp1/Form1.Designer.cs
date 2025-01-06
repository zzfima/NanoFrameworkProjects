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
			this.btnSetPort = new System.Windows.Forms.Button();
			this.btnRelay0On = new System.Windows.Forms.Button();
			this.btnRelay0Off = new System.Windows.Forms.Button();
			this.btnGetStatus = new System.Windows.Forms.Button();
			this.lblStatus = new System.Windows.Forms.Label();
			this.groupBoxRellays = new System.Windows.Forms.GroupBox();
			this.comboBoxComPorts = new System.Windows.Forms.ComboBox();
			this.groupBoxComPort = new System.Windows.Forms.GroupBox();
			this.groupBoxRellays.SuspendLayout();
			this.groupBoxComPort.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSetPort
			// 
			this.btnSetPort.Location = new System.Drawing.Point(125, 21);
			this.btnSetPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSetPort.Name = "btnSetPort";
			this.btnSetPort.Size = new System.Drawing.Size(97, 24);
			this.btnSetPort.TabIndex = 5;
			this.btnSetPort.Text = "Set COM port";
			this.btnSetPort.UseVisualStyleBackColor = true;
			this.btnSetPort.Click += new System.EventHandler(this.btnSetPort_Click);
			// 
			// btnRelay0On
			// 
			this.btnRelay0On.BackColor = System.Drawing.Color.Red;
			this.btnRelay0On.Location = new System.Drawing.Point(11, 41);
			this.btnRelay0On.Margin = new System.Windows.Forms.Padding(4);
			this.btnRelay0On.Name = "btnRelay0On";
			this.btnRelay0On.Size = new System.Drawing.Size(100, 79);
			this.btnRelay0On.TabIndex = 7;
			this.btnRelay0On.Text = "Interlock On";
			this.btnRelay0On.UseVisualStyleBackColor = false;
			this.btnRelay0On.Click += new System.EventHandler(this.btnRelay0_On_Click);
			// 
			// btnRelay0Off
			// 
			this.btnRelay0Off.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnRelay0Off.Location = new System.Drawing.Point(119, 41);
			this.btnRelay0Off.Margin = new System.Windows.Forms.Padding(4);
			this.btnRelay0Off.Name = "btnRelay0Off";
			this.btnRelay0Off.Size = new System.Drawing.Size(100, 79);
			this.btnRelay0Off.TabIndex = 8;
			this.btnRelay0Off.Text = "Interlock off";
			this.btnRelay0Off.UseVisualStyleBackColor = false;
			this.btnRelay0Off.Click += new System.EventHandler(this.btnRelay0_Off_Click);
			// 
			// btnGetStatus
			// 
			this.btnGetStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnGetStatus.Location = new System.Drawing.Point(11, 165);
			this.btnGetStatus.Margin = new System.Windows.Forms.Padding(4);
			this.btnGetStatus.Name = "btnGetStatus";
			this.btnGetStatus.Size = new System.Drawing.Size(100, 28);
			this.btnGetStatus.TabIndex = 23;
			this.btnGetStatus.Text = "Get Status";
			this.btnGetStatus.UseVisualStyleBackColor = false;
			this.btnGetStatus.Click += new System.EventHandler(this.btnGetStatus_Click);
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(11, 197);
			this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(19, 16);
			this.lblStatus.TabIndex = 24;
			this.lblStatus.Text = "---";
			// 
			// groupBoxRellays
			// 
			this.groupBoxRellays.Controls.Add(this.lblStatus);
			this.groupBoxRellays.Controls.Add(this.btnRelay0On);
			this.groupBoxRellays.Controls.Add(this.btnGetStatus);
			this.groupBoxRellays.Controls.Add(this.btnRelay0Off);
			this.groupBoxRellays.Location = new System.Drawing.Point(16, 77);
			this.groupBoxRellays.Margin = new System.Windows.Forms.Padding(4);
			this.groupBoxRellays.Name = "groupBoxRellays";
			this.groupBoxRellays.Padding = new System.Windows.Forms.Padding(4);
			this.groupBoxRellays.Size = new System.Drawing.Size(232, 226);
			this.groupBoxRellays.TabIndex = 25;
			this.groupBoxRellays.TabStop = false;
			this.groupBoxRellays.Text = "Rellays control";
			// 
			// comboBoxComPorts
			// 
			this.comboBoxComPorts.FormattingEnabled = true;
			this.comboBoxComPorts.Location = new System.Drawing.Point(14, 21);
			this.comboBoxComPorts.Name = "comboBoxComPorts";
			this.comboBoxComPorts.Size = new System.Drawing.Size(100, 24);
			this.comboBoxComPorts.TabIndex = 26;
			// 
			// groupBoxComPort
			// 
			this.groupBoxComPort.Controls.Add(this.btnSetPort);
			this.groupBoxComPort.Controls.Add(this.comboBoxComPorts);
			this.groupBoxComPort.Location = new System.Drawing.Point(16, 12);
			this.groupBoxComPort.Name = "groupBoxComPort";
			this.groupBoxComPort.Size = new System.Drawing.Size(232, 58);
			this.groupBoxComPort.TabIndex = 27;
			this.groupBoxComPort.TabStop = false;
			this.groupBoxComPort.Text = "COM Port";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(264, 316);
			this.Controls.Add(this.groupBoxComPort);
			this.Controls.Add(this.groupBoxRellays);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.Text = "Interlock Commander";
			this.groupBoxRellays.ResumeLayout(false);
			this.groupBoxRellays.PerformLayout();
			this.groupBoxComPort.ResumeLayout(false);
			this.ResumeLayout(false);

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
	}
}

