namespace Multiple_ROBLOX
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000004 RID: 4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000005 RID: 5
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Multiple_ROBLOX.Form1));
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.label3 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Verdana", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(11, 33);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(88, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "cracked by nismo1337";
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.Font = new global::System.Drawing.Font("Verdana", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(9, 8);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(261, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Multiple Game Instance";
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.linkLabel1.Font = new global::System.Drawing.Font("Verdana", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.linkLabel1.ForeColor = global::System.Drawing.Color.White;
			this.linkLabel1.LinkColor = global::System.Drawing.Color.White;
			this.linkLabel1.Location = new global::System.Drawing.Point(82, 237);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new global::System.Drawing.Size(118, 18);
			this.linkLabel1.TabIndex = 2;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "cracked by nismo1337";
			this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.Font = new global::System.Drawing.Font("Verdana", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(5, 81);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(274, 126);
			this.label3.TabIndex = 3;
			this.label3.Text = componentResourceManager.GetString("label3.Text");
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(284, 261);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.linkLabel1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(300, 300);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(300, 300);
			base.Name = "Form1";
			this.Text = "Multiple Game Instance";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Label label3;
	}
}
