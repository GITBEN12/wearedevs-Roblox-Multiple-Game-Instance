using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Multiple_ROBLOX
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2
		private void Form1_Load(object sender, EventArgs e)
		{
			new Mutex(true, "ROBLOX_singletonMutex");
		}

		// Token: 0x06000003 RID: 3
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://discord.gg/sVjr9G44p8");
		}
	}
}
