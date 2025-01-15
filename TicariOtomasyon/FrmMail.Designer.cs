namespace TicariOtomasyon
{
	partial class FrmMail
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
			this.label1 = new System.Windows.Forms.Label();
			this.txtMail = new DevExpress.XtraEditors.TextEdit();
			this.txrtKonu = new DevExpress.XtraEditors.TextEdit();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.rchMesaj = new System.Windows.Forms.RichTextBox();
			this.btnGonder = new DevExpress.XtraEditors.SimpleButton();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txrtKonu.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 91);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "MAIL:";
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(83, 88);
			this.txtMail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtMail.Name = "txtMail";
			this.txtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtMail.Properties.Appearance.Options.UseFont = true;
			this.txtMail.Size = new System.Drawing.Size(238, 24);
			this.txtMail.TabIndex = 1;
			// 
			// txrtKonu
			// 
			this.txrtKonu.Location = new System.Drawing.Point(83, 143);
			this.txrtKonu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txrtKonu.Name = "txrtKonu";
			this.txrtKonu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txrtKonu.Properties.Appearance.Options.UseFont = true;
			this.txrtKonu.Size = new System.Drawing.Size(238, 24);
			this.txrtKonu.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 146);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "KONU:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 219);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 18);
			this.label3.TabIndex = 4;
			this.label3.Text = "MESAJ:";
			// 
			// rchMesaj
			// 
			this.rchMesaj.Location = new System.Drawing.Point(79, 216);
			this.rchMesaj.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.rchMesaj.Name = "rchMesaj";
			this.rchMesaj.Size = new System.Drawing.Size(242, 221);
			this.rchMesaj.TabIndex = 5;
			this.rchMesaj.Text = "";
			// 
			// btnGonder
			// 
			this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
			this.btnGonder.Location = new System.Drawing.Point(79, 458);
			this.btnGonder.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnGonder.Name = "btnGonder";
			this.btnGonder.Size = new System.Drawing.Size(242, 39);
			this.btnGonder.TabIndex = 6;
			this.btnGonder.Text = "GÖNDER";
			this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(73, 19);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(259, 31);
			this.label4.TabIndex = 7;
			this.label4.Text = "Mail Gönderme Paneli";
			// 
			// FrmMail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(362, 522);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnGonder);
			this.Controls.Add(this.rchMesaj);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txrtKonu);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtMail);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmMail";
			this.Text = "FrmMail";
			this.Load += new System.EventHandler(this.FrmMail_Load);
			((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txrtKonu.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private DevExpress.XtraEditors.TextEdit txtMail;
		private DevExpress.XtraEditors.TextEdit txrtKonu;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox rchMesaj;
		private DevExpress.XtraEditors.SimpleButton btnGonder;
		private System.Windows.Forms.Label label4;
	}
}