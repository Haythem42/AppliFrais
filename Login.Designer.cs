
namespace AppliFrais
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MailTb = new System.Windows.Forms.TextBox();
            this.MdpTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConnexionBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ClosePic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ClosePic);
            this.panel1.Controls.Add(this.ConnexionBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.MdpTb);
            this.panel1.Controls.Add(this.MailTb);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 356);
            this.panel1.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(149)))), ((int)(((byte)(198)))));
            this.label1.Location = new System.Drawing.Point(183, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Galaxy Swiss Bourdin Europe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(149)))), ((int)(((byte)(198)))));
            this.label2.Location = new System.Drawing.Point(270, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "AppliFrais";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(268, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MailTb
            // 
            this.MailTb.Location = new System.Drawing.Point(188, 183);
            this.MailTb.Name = "MailTb";
            this.MailTb.Size = new System.Drawing.Size(270, 20);
            this.MailTb.TabIndex = 23;
            // 
            // MdpTb
            // 
            this.MdpTb.Location = new System.Drawing.Point(188, 249);
            this.MdpTb.Name = "MdpTb";
            this.MdpTb.Size = new System.Drawing.Size(270, 20);
            this.MdpTb.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(149)))), ((int)(((byte)(198)))));
            this.label3.Location = new System.Drawing.Point(301, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(149)))), ((int)(((byte)(198)))));
            this.label4.Location = new System.Drawing.Point(274, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mot de passe";
            // 
            // ConnexionBtn
            // 
            this.ConnexionBtn.ActiveBorderThickness = 1;
            this.ConnexionBtn.ActiveCornerRadius = 20;
            this.ConnexionBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(149)))), ((int)(((byte)(198)))));
            this.ConnexionBtn.ActiveForecolor = System.Drawing.Color.White;
            this.ConnexionBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(149)))), ((int)(((byte)(198)))));
            this.ConnexionBtn.BackColor = System.Drawing.Color.White;
            this.ConnexionBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConnexionBtn.BackgroundImage")));
            this.ConnexionBtn.ButtonText = "Se connecter";
            this.ConnexionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnexionBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnexionBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(149)))), ((int)(((byte)(198)))));
            this.ConnexionBtn.IdleBorderThickness = 1;
            this.ConnexionBtn.IdleCornerRadius = 20;
            this.ConnexionBtn.IdleFillColor = System.Drawing.Color.White;
            this.ConnexionBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(149)))), ((int)(((byte)(198)))));
            this.ConnexionBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(149)))), ((int)(((byte)(198)))));
            this.ConnexionBtn.Location = new System.Drawing.Point(233, 293);
            this.ConnexionBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ConnexionBtn.Name = "ConnexionBtn";
            this.ConnexionBtn.Size = new System.Drawing.Size(181, 41);
            this.ConnexionBtn.TabIndex = 27;
            this.ConnexionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ConnexionBtn.Click += new System.EventHandler(this.ConnexionBtn_Click);

            // 
            // ClosePic
            // 
            this.ClosePic.Image = ((System.Drawing.Image)(resources.GetObject("ClosePic.Image")));
            this.ClosePic.Location = new System.Drawing.Point(590, 3);
            this.ClosePic.Name = "ClosePic";
            this.ClosePic.Size = new System.Drawing.Size(54, 50);
            this.ClosePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClosePic.TabIndex = 28;
            this.ClosePic.TabStop = false;
            this.ClosePic.Click += new System.EventHandler(this.ClosePic_Click);

            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(149)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(671, 380);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MdpTb;
        private System.Windows.Forms.TextBox MailTb;
        private Bunifu.Framework.UI.BunifuThinButton2 ConnexionBtn;
        private System.Windows.Forms.PictureBox ClosePic;
    }
}