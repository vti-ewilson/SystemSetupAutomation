namespace SystemSetupAutomation
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
			if(disposing && (components != null))
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
			this.sshFolderBox = new System.Windows.Forms.TextBox();
			this.sshFolderLabel = new System.Windows.Forms.Label();
			this.gitLinkBox = new System.Windows.Forms.TextBox();
			this.gitLinkLabel = new System.Windows.Forms.Label();
			this.wifiButton = new System.Windows.Forms.RadioButton();
			this.ethButton = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.ScriptBox = new System.Windows.Forms.TextBox();
			this.InstructionBox = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.sshFolderBox);
			this.panel1.Controls.Add(this.sshFolderLabel);
			this.panel1.Controls.Add(this.gitLinkBox);
			this.panel1.Controls.Add(this.gitLinkLabel);
			this.panel1.Controls.Add(this.wifiButton);
			this.panel1.Controls.Add(this.ethButton);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(491, 1264);
			this.panel1.TabIndex = 0;
			// 
			// sshFolderBox
			// 
			this.sshFolderBox.Location = new System.Drawing.Point(17, 563);
			this.sshFolderBox.Name = "sshFolderBox";
			this.sshFolderBox.Size = new System.Drawing.Size(454, 26);
			this.sshFolderBox.TabIndex = 6;
			this.sshFolderBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// sshFolderLabel
			// 
			this.sshFolderLabel.AutoSize = true;
			this.sshFolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sshFolderLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.sshFolderLabel.Location = new System.Drawing.Point(12, 520);
			this.sshFolderLabel.Name = "sshFolderLabel";
			this.sshFolderLabel.Size = new System.Drawing.Size(203, 29);
			this.sshFolderLabel.TabIndex = 5;
			this.sshFolderLabel.Text = ".ssh Folder Path";
			// 
			// gitLinkBox
			// 
			this.gitLinkBox.Location = new System.Drawing.Point(17, 391);
			this.gitLinkBox.Name = "gitLinkBox";
			this.gitLinkBox.Size = new System.Drawing.Size(454, 26);
			this.gitLinkBox.TabIndex = 4;
			this.gitLinkBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// gitLinkLabel
			// 
			this.gitLinkLabel.AutoSize = true;
			this.gitLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gitLinkLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.gitLinkLabel.Location = new System.Drawing.Point(12, 349);
			this.gitLinkLabel.Name = "gitLinkLabel";
			this.gitLinkLabel.Size = new System.Drawing.Size(229, 29);
			this.gitLinkLabel.TabIndex = 3;
			this.gitLinkLabel.Text = "Git SSH Clone link";
			// 
			// wifiButton
			// 
			this.wifiButton.AutoSize = true;
			this.wifiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.wifiButton.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.wifiButton.Location = new System.Drawing.Point(67, 214);
			this.wifiButton.Name = "wifiButton";
			this.wifiButton.Size = new System.Drawing.Size(77, 29);
			this.wifiButton.TabIndex = 2;
			this.wifiButton.Text = "WiFi";
			this.wifiButton.UseVisualStyleBackColor = true;
			this.wifiButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// ethButton
			// 
			this.ethButton.AutoSize = true;
			this.ethButton.Checked = true;
			this.ethButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ethButton.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.ethButton.Location = new System.Drawing.Point(67, 172);
			this.ethButton.Name = "ethButton";
			this.ethButton.Size = new System.Drawing.Size(110, 29);
			this.ethButton.TabIndex = 1;
			this.ethButton.TabStop = true;
			this.ethButton.Text = "Ethernet";
			this.ethButton.UseVisualStyleBackColor = true;
			this.ethButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Location = new System.Drawing.Point(12, 119);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(452, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "How are you connecting to the system";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel2.Controls.Add(this.ScriptBox);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(491, 402);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(40, 20, 40, 40);
			this.panel2.Size = new System.Drawing.Size(1779, 862);
			this.panel2.TabIndex = 1;
			// 
			// ScriptBox
			// 
			this.ScriptBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ScriptBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ScriptBox.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.ScriptBox.Location = new System.Drawing.Point(40, 20);
			this.ScriptBox.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
			this.ScriptBox.Multiline = true;
			this.ScriptBox.Name = "ScriptBox";
			this.ScriptBox.ReadOnly = true;
			this.ScriptBox.Size = new System.Drawing.Size(1699, 802);
			this.ScriptBox.TabIndex = 1;
			// 
			// InstructionBox
			// 
			this.InstructionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.InstructionBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.InstructionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InstructionBox.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.InstructionBox.Location = new System.Drawing.Point(40, 40);
			this.InstructionBox.Multiline = true;
			this.InstructionBox.Name = "InstructionBox";
			this.InstructionBox.ReadOnly = true;
			this.InstructionBox.Size = new System.Drawing.Size(1699, 342);
			this.InstructionBox.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel3.Controls.Add(this.InstructionBox);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(491, 0);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(40, 40, 40, 20);
			this.panel3.Size = new System.Drawing.Size(1779, 402);
			this.panel3.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2270, 1264);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox ScriptBox;
		private System.Windows.Forms.TextBox InstructionBox;
		private System.Windows.Forms.RadioButton wifiButton;
		private System.Windows.Forms.RadioButton ethButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label gitLinkLabel;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox sshFolderBox;
		private System.Windows.Forms.Label sshFolderLabel;
		private System.Windows.Forms.TextBox gitLinkBox;
	}
}

