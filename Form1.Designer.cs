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
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.copyButton = new System.Windows.Forms.Button();
			this.ScriptBox = new System.Windows.Forms.TextBox();
			this.InstructionBox = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.panel1.Controls.Add(this.checkedListBox1);
			this.panel1.Controls.Add(this.sshFolderBox);
			this.panel1.Controls.Add(this.sshFolderLabel);
			this.panel1.Controls.Add(this.gitLinkBox);
			this.panel1.Controls.Add(this.gitLinkLabel);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(491, 1264);
			this.panel1.TabIndex = 0;
			// 
			// sshFolderBox
			// 
			this.sshFolderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.sshFolderBox.Location = new System.Drawing.Point(17, 254);
			this.sshFolderBox.Name = "sshFolderBox";
			this.sshFolderBox.Size = new System.Drawing.Size(454, 28);
			this.sshFolderBox.TabIndex = 6;
			this.sshFolderBox.Text = "\\\\vac-controls.vti.local\\Central Storage\\";
			this.sshFolderBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// sshFolderLabel
			// 
			this.sshFolderLabel.AutoSize = true;
			this.sshFolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
			this.sshFolderLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.sshFolderLabel.Location = new System.Drawing.Point(12, 211);
			this.sshFolderLabel.Name = "sshFolderLabel";
			this.sshFolderLabel.Size = new System.Drawing.Size(236, 32);
			this.sshFolderLabel.TabIndex = 5;
			this.sshFolderLabel.Text = ".ssh Folder Path";
			// 
			// gitLinkBox
			// 
			this.gitLinkBox.Location = new System.Drawing.Point(17, 82);
			this.gitLinkBox.Name = "gitLinkBox";
			this.gitLinkBox.Size = new System.Drawing.Size(454, 26);
			this.gitLinkBox.TabIndex = 4;
			this.gitLinkBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// gitLinkLabel
			// 
			this.gitLinkLabel.AutoSize = true;
			this.gitLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
			this.gitLinkLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.gitLinkLabel.Location = new System.Drawing.Point(12, 40);
			this.gitLinkLabel.Name = "gitLinkLabel";
			this.gitLinkLabel.Size = new System.Drawing.Size(267, 32);
			this.gitLinkLabel.TabIndex = 3;
			this.gitLinkLabel.Text = "Git SSH Clone link";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Location = new System.Drawing.Point(19, 353);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Options";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.panel2.Controls.Add(this.copyButton);
			this.panel2.Controls.Add(this.ScriptBox);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(491, 120);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(40, 20, 40, 40);
			this.panel2.Size = new System.Drawing.Size(1779, 1144);
			this.panel2.TabIndex = 1;
			// 
			// copyButton
			// 
			this.copyButton.BackgroundImage = global::SystemSetupAutomation.Properties.Resources.copyImage;
			this.copyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.copyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.copyButton.Location = new System.Drawing.Point(1626, 73);
			this.copyButton.Margin = new System.Windows.Forms.Padding(0);
			this.copyButton.Name = "copyButton";
			this.copyButton.Size = new System.Drawing.Size(62, 58);
			this.copyButton.TabIndex = 2;
			this.copyButton.UseVisualStyleBackColor = true;
			this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
			// 
			// ScriptBox
			// 
			this.ScriptBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.ScriptBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ScriptBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.ScriptBox.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.ScriptBox.Location = new System.Drawing.Point(40, 20);
			this.ScriptBox.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
			this.ScriptBox.Multiline = true;
			this.ScriptBox.Name = "ScriptBox";
			this.ScriptBox.ReadOnly = true;
			this.ScriptBox.Size = new System.Drawing.Size(1699, 1084);
			this.ScriptBox.TabIndex = 1;
			// 
			// InstructionBox
			// 
			this.InstructionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.InstructionBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.InstructionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InstructionBox.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.InstructionBox.Location = new System.Drawing.Point(40, 40);
			this.InstructionBox.Multiline = true;
			this.InstructionBox.Name = "InstructionBox";
			this.InstructionBox.ReadOnly = true;
			this.InstructionBox.Size = new System.Drawing.Size(1699, 60);
			this.InstructionBox.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.panel3.Controls.Add(this.InstructionBox);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(491, 0);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(40, 40, 40, 20);
			this.panel3.Size = new System.Drawing.Size(1779, 120);
			this.panel3.TabIndex = 2;
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.checkedListBox1.CheckOnClick = true;
			this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.checkedListBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[] {
            "Set Static IP for PLC",
            "Copy SSH Keys",
            "Copy Config Folder"});
			this.checkedListBox1.Location = new System.Drawing.Point(24, 402);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(447, 208);
			this.checkedListBox1.TabIndex = 3;
			this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label gitLinkLabel;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox sshFolderBox;
		private System.Windows.Forms.Label sshFolderLabel;
		private System.Windows.Forms.TextBox gitLinkBox;
		private System.Windows.Forms.Button copyButton;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
	}
}

