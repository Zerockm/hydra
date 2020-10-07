namespace Hydra
{
	// Token: 0x02000002 RID: 2
	public partial class MsgBoxForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002270 File Offset: 0x00000470
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002290 File Offset: 0x00000490
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Hydra.MsgBoxForm));
			this.lblText = new global::System.Windows.Forms.Label();
			this.btnOk = new global::System.Windows.Forms.Button();
			this.pbIcon = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pbIcon).BeginInit();
			base.SuspendLayout();
			this.lblText.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblText.Location = new global::System.Drawing.Point(82, 12);
			this.lblText.Name = "lblText";
			this.lblText.Size = new global::System.Drawing.Size(376, 117);
			this.lblText.TabIndex = 1;
			this.btnOk.Location = new global::System.Drawing.Point(383, 143);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new global::System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new global::System.EventHandler(this.btnOk_Click);
			this.pbIcon.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pbIcon.Image");
			this.pbIcon.Location = new global::System.Drawing.Point(12, 12);
			this.pbIcon.Name = "pbIcon";
			this.pbIcon.Size = new global::System.Drawing.Size(64, 64);
			this.pbIcon.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbIcon.TabIndex = 0;
			this.pbIcon.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(470, 178);
			base.Controls.Add(this.btnOk);
			base.Controls.Add(this.lblText);
			base.Controls.Add(this.pbIcon);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "MsgBoxForm";
			base.Opacity = 0.0;
			base.ShowIcon = false;
			this.Text = "HYDRA";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.MsgBoxForm_FormClosing);
			base.Load += new global::System.EventHandler(this.MsgBoxForm_Load);
			base.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.MsgBoxForm_KeyPress);
			((global::System.ComponentModel.ISupportInitialize)this.pbIcon).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000003 RID: 3
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.PictureBox pbIcon;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Label lblText;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Button btnOk;
	}
}
