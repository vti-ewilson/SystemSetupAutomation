using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemSetupAutomation
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			UpdateDescription();
			UpdateScript();
		}

		private void UpdateDescription()
		{
			if(ethButton.Checked)
			{
				InstructionBox.Text = "- Run Powershell as Administrator then paste in this script";
			}
			else
			{
				InstructionBox.Text = "- Copy over SSH folder manually\r\n\r\n- Run Powershell as Administrator then paste in this script";
			}
		}

		private void UpdateScript()
		{
			string script;
			if(ethButton.Checked)
			{
				script = File.ReadAllText(@"../../scripts/setup.ps1");
				script = script.Replace("{SSHFOLDER}", sshFolderBox.Text);
			}
			else
			{
				script = File.ReadAllText(@"../../scripts/setup_wifi.ps1");
			}
			script = script.Replace("{GITLINK}", gitLinkBox.Text);
			ScriptBox.Text = script;
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if(ethButton.Checked)
			{
				sshFolderLabel.Visible = true;
				sshFolderBox.Visible = true;
			}
			else
			{
				sshFolderLabel.Visible = false;
				sshFolderBox.Visible = false;
			}
			UpdateDescription();
			UpdateScript();
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			UpdateDescription();
			UpdateScript();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			UpdateScript();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			UpdateScript();
		}

		
	}
}
