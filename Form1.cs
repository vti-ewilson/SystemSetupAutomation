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
			for(int i = 0; i < checkedListBox1.Items.Count; i++){
				checkedListBox1.SetItemChecked(i, true);
			}
			UpdateDescription();
			UpdateScript();
		}

		private void UpdateDescription()
		{
			InstructionBox.Text = " - Run Powershell as Administrator then paste in this script";
		}

		private void UpdateScript()
		{
			string script = "";

			// Set Static IP for PLC
			if(checkedListBox1.GetItemChecked(0))
			{
				script += File.ReadAllText(@"../../scripts/SetStaticIP.ps1");
			}

			// Copy SSH keys
			if(checkedListBox1.GetItemChecked(1))
			{
				script += File.ReadAllText(@"../../scripts/CopySSHKeys.ps1");
				script = script.Replace("{SSHFOLDER}", sshFolderBox.Text);
			}

			// Clone Repo
			script += File.ReadAllText(@"../../scripts/Clone.ps1");
			script = script.Replace("{GITLINK}", gitLinkBox.Text);

			// Copy Config Folder
			if(checkedListBox1.GetItemChecked(2))
			{
				script += File.ReadAllText(@"../../scripts/CopyConfig.ps1");
			}

			// Open sln and ckp
			script += File.ReadAllText(@"../../scripts/Open.ps1");

			ScriptBox.Text = script.Trim();
		}

		

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			UpdateScript();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			UpdateScript();
		}

		private void copyButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(ScriptBox.Text);
		}

		private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if(e.Index == 1)
			{
				if(e.NewValue == CheckState.Checked)
				{
					sshFolderBox.Visible = true;
					sshFolderLabel.Visible = true;
				}
				else
				{
					sshFolderBox.Visible = false;
					sshFolderLabel.Visible = false;
				}
			}
			this.BeginInvoke((MethodInvoker)(() => UpdateScript())); // delay UpdateScript because this event executes before item state change
		}
	}
}
