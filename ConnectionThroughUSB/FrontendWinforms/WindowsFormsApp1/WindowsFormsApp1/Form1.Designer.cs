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
			this.btnBlinkThreeTimes = new System.Windows.Forms.Button();
			this.btnOpenCircuit = new System.Windows.Forms.Button();
			this.btnCloseCircuit = new System.Windows.Forms.Button();
			this.txtComPort = new System.Windows.Forms.TextBox();
			this.btnSetPort = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnBlinkThreeTimes
			// 
			this.btnBlinkThreeTimes.Location = new System.Drawing.Point(212, 267);
			this.btnBlinkThreeTimes.Name = "btnBlinkThreeTimes";
			this.btnBlinkThreeTimes.Size = new System.Drawing.Size(147, 56);
			this.btnBlinkThreeTimes.TabIndex = 9;
			this.btnBlinkThreeTimes.Text = "Blink 3 times";
			this.btnBlinkThreeTimes.UseVisualStyleBackColor = true;
			this.btnBlinkThreeTimes.Click += new System.EventHandler(this.btnBlinkThreeTimes_Click_1);
			// 
			// btnOpenCircuit
			// 
			this.btnOpenCircuit.Location = new System.Drawing.Point(212, 184);
			this.btnOpenCircuit.Name = "btnOpenCircuit";
			this.btnOpenCircuit.Size = new System.Drawing.Size(147, 56);
			this.btnOpenCircuit.TabIndex = 8;
			this.btnOpenCircuit.Text = "Open Circuit";
			this.btnOpenCircuit.UseVisualStyleBackColor = true;
			this.btnOpenCircuit.Click += new System.EventHandler(this.btnOpenCircuit_Click_1);
			// 
			// btnCloseCircuit
			// 
			this.btnCloseCircuit.Location = new System.Drawing.Point(212, 98);
			this.btnCloseCircuit.Name = "btnCloseCircuit";
			this.btnCloseCircuit.Size = new System.Drawing.Size(147, 56);
			this.btnCloseCircuit.TabIndex = 7;
			this.btnCloseCircuit.Text = "Close Circuit";
			this.btnCloseCircuit.UseVisualStyleBackColor = true;
			this.btnCloseCircuit.Click += new System.EventHandler(this.btnCloseCircuit_Click_1);
			// 
			// txtComPort
			// 
			this.txtComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtComPort.Location = new System.Drawing.Point(43, 23);
			this.txtComPort.Name = "txtComPort";
			this.txtComPort.Size = new System.Drawing.Size(147, 53);
			this.txtComPort.TabIndex = 6;
			this.txtComPort.Text = "COM0";
			// 
			// btnSetPort
			// 
			this.btnSetPort.Location = new System.Drawing.Point(212, 20);
			this.btnSetPort.Name = "btnSetPort";
			this.btnSetPort.Size = new System.Drawing.Size(147, 56);
			this.btnSetPort.TabIndex = 5;
			this.btnSetPort.Text = "Set COM port";
			this.btnSetPort.UseVisualStyleBackColor = true;
			this.btnSetPort.Click += new System.EventHandler(this.btnSetPort_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnBlinkThreeTimes);
			this.Controls.Add(this.btnOpenCircuit);
			this.Controls.Add(this.btnCloseCircuit);
			this.Controls.Add(this.txtComPort);
			this.Controls.Add(this.btnSetPort);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBlinkThreeTimes;
		private System.Windows.Forms.Button btnOpenCircuit;
		private System.Windows.Forms.Button btnCloseCircuit;
		private System.Windows.Forms.TextBox txtComPort;
		private System.Windows.Forms.Button btnSetPort;
	}
}

