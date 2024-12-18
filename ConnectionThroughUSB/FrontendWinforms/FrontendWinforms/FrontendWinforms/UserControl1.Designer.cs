namespace FrontendWinforms
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.btnSetPort = new System.Windows.Forms.Button();
			this.txtComPort = new System.Windows.Forms.TextBox();
			this.btnCloseCircuit = new System.Windows.Forms.Button();
			this.btnOpenCircuit = new System.Windows.Forms.Button();
			this.btnBlinkThreeTimes = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSetPort
			// 
			this.btnSetPort.Location = new System.Drawing.Point(195, 18);
			this.btnSetPort.Name = "btnSetPort";
			this.btnSetPort.Size = new System.Drawing.Size(147, 56);
			this.btnSetPort.TabIndex = 0;
			this.btnSetPort.Text = "Set COM port";
			this.btnSetPort.UseVisualStyleBackColor = true;
			this.btnSetPort.Click += new System.EventHandler(this.btnSetPort_Click);
			// 
			// txtComPort
			// 
			this.txtComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtComPort.Location = new System.Drawing.Point(26, 21);
			this.txtComPort.Name = "txtComPort";
			this.txtComPort.Size = new System.Drawing.Size(147, 53);
			this.txtComPort.TabIndex = 1;
			this.txtComPort.Text = "COM0";
			// 
			// btnCloseCircuit
			// 
			this.btnCloseCircuit.Location = new System.Drawing.Point(195, 96);
			this.btnCloseCircuit.Name = "btnCloseCircuit";
			this.btnCloseCircuit.Size = new System.Drawing.Size(147, 56);
			this.btnCloseCircuit.TabIndex = 2;
			this.btnCloseCircuit.Text = "Close Circuit";
			this.btnCloseCircuit.UseVisualStyleBackColor = true;
			this.btnCloseCircuit.Click += new System.EventHandler(this.btnCloseCircuit_Click);
			// 
			// btnOpenCircuit
			// 
			this.btnOpenCircuit.Location = new System.Drawing.Point(195, 182);
			this.btnOpenCircuit.Name = "btnOpenCircuit";
			this.btnOpenCircuit.Size = new System.Drawing.Size(147, 56);
			this.btnOpenCircuit.TabIndex = 3;
			this.btnOpenCircuit.Text = "Open Circuit";
			this.btnOpenCircuit.UseVisualStyleBackColor = true;
			this.btnOpenCircuit.Click += new System.EventHandler(this.btnOpenCircuit_Click);
			// 
			// btnBlinkThreeTimes
			// 
			this.btnBlinkThreeTimes.Location = new System.Drawing.Point(195, 265);
			this.btnBlinkThreeTimes.Name = "btnBlinkThreeTimes";
			this.btnBlinkThreeTimes.Size = new System.Drawing.Size(147, 56);
			this.btnBlinkThreeTimes.TabIndex = 4;
			this.btnBlinkThreeTimes.Text = "Blink 3 times";
			this.btnBlinkThreeTimes.UseVisualStyleBackColor = true;
			this.btnBlinkThreeTimes.Click += new System.EventHandler(this.btnBlinkThreeTimes_Click);
			// 
			// UserControl1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnBlinkThreeTimes);
			this.Controls.Add(this.btnOpenCircuit);
			this.Controls.Add(this.btnCloseCircuit);
			this.Controls.Add(this.txtComPort);
			this.Controls.Add(this.btnSetPort);
			this.Name = "UserControl1";
			this.Size = new System.Drawing.Size(800, 450);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button btnSetPort;
		private System.Windows.Forms.TextBox txtComPort;
		private System.Windows.Forms.Button btnCloseCircuit;
		private System.Windows.Forms.Button btnOpenCircuit;
		private System.Windows.Forms.Button btnBlinkThreeTimes;
	}
}
