namespace WindowsFormsApp1
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
			this.txtComPort = new System.Windows.Forms.TextBox();
			this.btnSetPort = new System.Windows.Forms.Button();
			this.btnRelay0On = new System.Windows.Forms.Button();
			this.btnRelay0Off = new System.Windows.Forms.Button();
			this.btnRelay1Off = new System.Windows.Forms.Button();
			this.btnRelay1On = new System.Windows.Forms.Button();
			this.btnRelay2Off = new System.Windows.Forms.Button();
			this.btnRelay2On = new System.Windows.Forms.Button();
			this.btnRelay3Off = new System.Windows.Forms.Button();
			this.btnRelay3On = new System.Windows.Forms.Button();
			this.btnRelay4Off = new System.Windows.Forms.Button();
			this.btnRelay4On = new System.Windows.Forms.Button();
			this.btnRelay5Off = new System.Windows.Forms.Button();
			this.btnRelay5On = new System.Windows.Forms.Button();
			this.btnRelay6Off = new System.Windows.Forms.Button();
			this.btnRelay6On = new System.Windows.Forms.Button();
			this.btnRelay7Off = new System.Windows.Forms.Button();
			this.btnRelay7On = new System.Windows.Forms.Button();
			this.btnGetStatus = new System.Windows.Forms.Button();
			this.lblStatus = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtComPort
			// 
			this.txtComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtComPort.Location = new System.Drawing.Point(12, 18);
			this.txtComPort.Margin = new System.Windows.Forms.Padding(2);
			this.txtComPort.Name = "txtComPort";
			this.txtComPort.Size = new System.Drawing.Size(111, 26);
			this.txtComPort.TabIndex = 6;
			this.txtComPort.Text = "COM0";
			// 
			// btnSetPort
			// 
			this.btnSetPort.Location = new System.Drawing.Point(127, 18);
			this.btnSetPort.Margin = new System.Windows.Forms.Padding(2);
			this.btnSetPort.Name = "btnSetPort";
			this.btnSetPort.Size = new System.Drawing.Size(110, 26);
			this.btnSetPort.TabIndex = 5;
			this.btnSetPort.Text = "Set COM port";
			this.btnSetPort.UseVisualStyleBackColor = true;
			this.btnSetPort.Click += new System.EventHandler(this.btnSetPort_Click);
			// 
			// btnRelay0On
			// 
			this.btnRelay0On.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnRelay0On.Location = new System.Drawing.Point(6, 21);
			this.btnRelay0On.Name = "btnRelay0On";
			this.btnRelay0On.Size = new System.Drawing.Size(75, 23);
			this.btnRelay0On.TabIndex = 7;
			this.btnRelay0On.Text = "Relay 0 On";
			this.btnRelay0On.UseVisualStyleBackColor = false;
			this.btnRelay0On.Click += new System.EventHandler(this.btnRelay0On_Click);
			// 
			// btnRelay0Off
			// 
			this.btnRelay0Off.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnRelay0Off.Location = new System.Drawing.Point(6, 50);
			this.btnRelay0Off.Name = "btnRelay0Off";
			this.btnRelay0Off.Size = new System.Drawing.Size(75, 23);
			this.btnRelay0Off.TabIndex = 8;
			this.btnRelay0Off.Text = "Relay 0 Off";
			this.btnRelay0Off.UseVisualStyleBackColor = false;
			this.btnRelay0Off.Click += new System.EventHandler(this.btnRelay0Off_Click);
			// 
			// btnRelay1Off
			// 
			this.btnRelay1Off.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnRelay1Off.Location = new System.Drawing.Point(87, 50);
			this.btnRelay1Off.Name = "btnRelay1Off";
			this.btnRelay1Off.Size = new System.Drawing.Size(75, 23);
			this.btnRelay1Off.TabIndex = 10;
			this.btnRelay1Off.Text = "Relay 1 Off";
			this.btnRelay1Off.UseVisualStyleBackColor = false;
			this.btnRelay1Off.Click += new System.EventHandler(this.btnRelay1Off_Click);
			// 
			// btnRelay1On
			// 
			this.btnRelay1On.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnRelay1On.Location = new System.Drawing.Point(87, 21);
			this.btnRelay1On.Name = "btnRelay1On";
			this.btnRelay1On.Size = new System.Drawing.Size(75, 23);
			this.btnRelay1On.TabIndex = 9;
			this.btnRelay1On.Text = "Relay 1 On";
			this.btnRelay1On.UseVisualStyleBackColor = false;
			this.btnRelay1On.Click += new System.EventHandler(this.btnRelay1On_Click);
			// 
			// btnRelay2Off
			// 
			this.btnRelay2Off.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnRelay2Off.Location = new System.Drawing.Point(168, 50);
			this.btnRelay2Off.Name = "btnRelay2Off";
			this.btnRelay2Off.Size = new System.Drawing.Size(75, 23);
			this.btnRelay2Off.TabIndex = 12;
			this.btnRelay2Off.Text = "Relay 2 Off";
			this.btnRelay2Off.UseVisualStyleBackColor = false;
			this.btnRelay2Off.Click += new System.EventHandler(this.btnRelay2Off_Click);
			// 
			// btnRelay2On
			// 
			this.btnRelay2On.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnRelay2On.Location = new System.Drawing.Point(168, 21);
			this.btnRelay2On.Name = "btnRelay2On";
			this.btnRelay2On.Size = new System.Drawing.Size(75, 23);
			this.btnRelay2On.TabIndex = 11;
			this.btnRelay2On.Text = "Relay 2 On";
			this.btnRelay2On.UseVisualStyleBackColor = false;
			this.btnRelay2On.Click += new System.EventHandler(this.btnRelay2On_Click);
			// 
			// btnRelay3Off
			// 
			this.btnRelay3Off.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnRelay3Off.Location = new System.Drawing.Point(249, 50);
			this.btnRelay3Off.Name = "btnRelay3Off";
			this.btnRelay3Off.Size = new System.Drawing.Size(75, 23);
			this.btnRelay3Off.TabIndex = 14;
			this.btnRelay3Off.Text = "Relay 3 Off";
			this.btnRelay3Off.UseVisualStyleBackColor = false;
			this.btnRelay3Off.Click += new System.EventHandler(this.btnRelay3Off_Click);
			// 
			// btnRelay3On
			// 
			this.btnRelay3On.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnRelay3On.Location = new System.Drawing.Point(249, 21);
			this.btnRelay3On.Name = "btnRelay3On";
			this.btnRelay3On.Size = new System.Drawing.Size(75, 23);
			this.btnRelay3On.TabIndex = 13;
			this.btnRelay3On.Text = "Relay 3 On";
			this.btnRelay3On.UseVisualStyleBackColor = false;
			this.btnRelay3On.Click += new System.EventHandler(this.btnRelay3On_Click);
			// 
			// btnRelay4Off
			// 
			this.btnRelay4Off.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnRelay4Off.Location = new System.Drawing.Point(330, 50);
			this.btnRelay4Off.Name = "btnRelay4Off";
			this.btnRelay4Off.Size = new System.Drawing.Size(75, 23);
			this.btnRelay4Off.TabIndex = 16;
			this.btnRelay4Off.Text = "Relay 4 Off";
			this.btnRelay4Off.UseVisualStyleBackColor = false;
			this.btnRelay4Off.Click += new System.EventHandler(this.btnRelay4Off_Click);
			// 
			// btnRelay4On
			// 
			this.btnRelay4On.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnRelay4On.Location = new System.Drawing.Point(330, 21);
			this.btnRelay4On.Name = "btnRelay4On";
			this.btnRelay4On.Size = new System.Drawing.Size(75, 23);
			this.btnRelay4On.TabIndex = 15;
			this.btnRelay4On.Text = "Relay 4 On";
			this.btnRelay4On.UseVisualStyleBackColor = false;
			this.btnRelay4On.Click += new System.EventHandler(this.btnRelay4On_Click);
			// 
			// btnRelay5Off
			// 
			this.btnRelay5Off.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnRelay5Off.Location = new System.Drawing.Point(411, 50);
			this.btnRelay5Off.Name = "btnRelay5Off";
			this.btnRelay5Off.Size = new System.Drawing.Size(75, 23);
			this.btnRelay5Off.TabIndex = 18;
			this.btnRelay5Off.Text = "Relay 5 Off";
			this.btnRelay5Off.UseVisualStyleBackColor = false;
			this.btnRelay5Off.Click += new System.EventHandler(this.btnRelay5Off_Click);
			// 
			// btnRelay5On
			// 
			this.btnRelay5On.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnRelay5On.Location = new System.Drawing.Point(411, 21);
			this.btnRelay5On.Name = "btnRelay5On";
			this.btnRelay5On.Size = new System.Drawing.Size(75, 23);
			this.btnRelay5On.TabIndex = 17;
			this.btnRelay5On.Text = "Relay 5 On";
			this.btnRelay5On.UseVisualStyleBackColor = false;
			this.btnRelay5On.Click += new System.EventHandler(this.btnRelay5On_Click);
			// 
			// btnRelay6Off
			// 
			this.btnRelay6Off.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnRelay6Off.Location = new System.Drawing.Point(492, 50);
			this.btnRelay6Off.Name = "btnRelay6Off";
			this.btnRelay6Off.Size = new System.Drawing.Size(75, 23);
			this.btnRelay6Off.TabIndex = 20;
			this.btnRelay6Off.Text = "Relay 6 Off";
			this.btnRelay6Off.UseVisualStyleBackColor = false;
			this.btnRelay6Off.Click += new System.EventHandler(this.btnRelay6Off_Click);
			// 
			// btnRelay6On
			// 
			this.btnRelay6On.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnRelay6On.Location = new System.Drawing.Point(492, 21);
			this.btnRelay6On.Name = "btnRelay6On";
			this.btnRelay6On.Size = new System.Drawing.Size(75, 23);
			this.btnRelay6On.TabIndex = 19;
			this.btnRelay6On.Text = "Relay 6 On";
			this.btnRelay6On.UseVisualStyleBackColor = false;
			this.btnRelay6On.Click += new System.EventHandler(this.btnRelay6On_Click);
			// 
			// btnRelay7Off
			// 
			this.btnRelay7Off.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnRelay7Off.Location = new System.Drawing.Point(573, 50);
			this.btnRelay7Off.Name = "btnRelay7Off";
			this.btnRelay7Off.Size = new System.Drawing.Size(75, 23);
			this.btnRelay7Off.TabIndex = 22;
			this.btnRelay7Off.Text = "Relay 7 Off";
			this.btnRelay7Off.UseVisualStyleBackColor = false;
			this.btnRelay7Off.Click += new System.EventHandler(this.btnRelay7Off_Click);
			// 
			// btnRelay7On
			// 
			this.btnRelay7On.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnRelay7On.Location = new System.Drawing.Point(573, 21);
			this.btnRelay7On.Name = "btnRelay7On";
			this.btnRelay7On.Size = new System.Drawing.Size(75, 23);
			this.btnRelay7On.TabIndex = 21;
			this.btnRelay7On.Text = "Relay 7 On";
			this.btnRelay7On.UseVisualStyleBackColor = false;
			this.btnRelay7On.Click += new System.EventHandler(this.btnRelay7On_Click);
			// 
			// btnGetStatus
			// 
			this.btnGetStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnGetStatus.Location = new System.Drawing.Point(6, 88);
			this.btnGetStatus.Name = "btnGetStatus";
			this.btnGetStatus.Size = new System.Drawing.Size(75, 23);
			this.btnGetStatus.TabIndex = 23;
			this.btnGetStatus.Text = "Get Status";
			this.btnGetStatus.UseVisualStyleBackColor = false;
			this.btnGetStatus.Click += new System.EventHandler(this.btnGetStatus_Click);
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(98, 93);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(16, 13);
			this.lblStatus.TabIndex = 24;
			this.lblStatus.Text = "---";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnRelay5Off);
			this.groupBox1.Controls.Add(this.lblStatus);
			this.groupBox1.Controls.Add(this.btnRelay0On);
			this.groupBox1.Controls.Add(this.btnGetStatus);
			this.groupBox1.Controls.Add(this.btnRelay0Off);
			this.groupBox1.Controls.Add(this.btnRelay7Off);
			this.groupBox1.Controls.Add(this.btnRelay1On);
			this.groupBox1.Controls.Add(this.btnRelay7On);
			this.groupBox1.Controls.Add(this.btnRelay1Off);
			this.groupBox1.Controls.Add(this.btnRelay6Off);
			this.groupBox1.Controls.Add(this.btnRelay2On);
			this.groupBox1.Controls.Add(this.btnRelay6On);
			this.groupBox1.Controls.Add(this.btnRelay2Off);
			this.groupBox1.Controls.Add(this.btnRelay3On);
			this.groupBox1.Controls.Add(this.btnRelay5On);
			this.groupBox1.Controls.Add(this.btnRelay3Off);
			this.groupBox1.Controls.Add(this.btnRelay4Off);
			this.groupBox1.Controls.Add(this.btnRelay4On);
			this.groupBox1.Location = new System.Drawing.Point(12, 50);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(658, 119);
			this.groupBox1.TabIndex = 25;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rellays control";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(675, 179);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtComPort);
			this.Controls.Add(this.btnSetPort);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtComPort;
		private System.Windows.Forms.Button btnSetPort;
		private System.Windows.Forms.Button btnRelay0On;
		private System.Windows.Forms.Button btnRelay0Off;
		private System.Windows.Forms.Button btnRelay1Off;
		private System.Windows.Forms.Button btnRelay1On;
		private System.Windows.Forms.Button btnRelay2Off;
		private System.Windows.Forms.Button btnRelay2On;
		private System.Windows.Forms.Button btnRelay3Off;
		private System.Windows.Forms.Button btnRelay3On;
		private System.Windows.Forms.Button btnRelay4Off;
		private System.Windows.Forms.Button btnRelay4On;
		private System.Windows.Forms.Button btnRelay5Off;
		private System.Windows.Forms.Button btnRelay5On;
		private System.Windows.Forms.Button btnRelay6Off;
		private System.Windows.Forms.Button btnRelay6On;
		private System.Windows.Forms.Button btnRelay7Off;
		private System.Windows.Forms.Button btnRelay7On;
		private System.Windows.Forms.Button btnGetStatus;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

