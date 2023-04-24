
namespace QA.winfrom
{
    partial class FrmUserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserLogin));
            this.lblForgetPwd = new System.Windows.Forms.LinkLabel();
            this.lblQRcode = new System.Windows.Forms.LinkLabel();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.chkAutomatic = new System.Windows.Forms.CheckBox();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.lblUserPwd = new DevExpress.XtraEditors.LabelControl();
            this.lblUserNo = new DevExpress.XtraEditors.LabelControl();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtUserPwd = new DevExpress.XtraEditors.TextEdit();
            this.txtUserNo = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForgetPwd
            // 
            this.lblForgetPwd.AutoSize = true;
            this.lblForgetPwd.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgetPwd.LinkColor = System.Drawing.Color.Red;
            this.lblForgetPwd.Location = new System.Drawing.Point(374, 306);
            this.lblForgetPwd.Name = "lblForgetPwd";
            this.lblForgetPwd.Size = new System.Drawing.Size(45, 12);
            this.lblForgetPwd.TabIndex = 32;
            this.lblForgetPwd.TabStop = true;
            this.lblForgetPwd.Text = "忘记密码";
            this.lblForgetPwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblForgetPwd_LinkClicked);
            // 
            // lblQRcode
            // 
            this.lblQRcode.AutoSize = true;
            this.lblQRcode.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQRcode.LinkColor = System.Drawing.Color.Aqua;
            this.lblQRcode.Location = new System.Drawing.Point(374, 338);
            this.lblQRcode.Name = "lblQRcode";
            this.lblQRcode.Size = new System.Drawing.Size(95, 12);
            this.lblQRcode.TabIndex = 31;
            this.lblQRcode.TabStop = true;
            this.lblQRcode.Text = "使用二维码扫描登录";
            this.lblQRcode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblQRcode_LinkClicked);
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.Location = new System.Drawing.Point(262, 283);
            this.chkRemember.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(74, 18);
            this.chkRemember.TabIndex = 29;
            this.chkRemember.Text = "记住密码";
            this.chkRemember.UseVisualStyleBackColor = true;
            this.chkRemember.CheckedChanged += new System.EventHandler(this.chkRemember_CheckedChanged);
            // 
            // chkAutomatic
            // 
            this.chkAutomatic.AutoSize = true;
            this.chkAutomatic.Location = new System.Drawing.Point(142, 283);
            this.chkAutomatic.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.chkAutomatic.Name = "chkAutomatic";
            this.chkAutomatic.Size = new System.Drawing.Size(74, 18);
            this.chkAutomatic.TabIndex = 28;
            this.chkAutomatic.Text = "自动登录";
            this.chkAutomatic.UseVisualStyleBackColor = true;
            this.chkAutomatic.CheckedChanged += new System.EventHandler(this.chkAutomatic_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(253, 324);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(87, 26);
            this.btnRegister.TabIndex = 26;
            this.btnRegister.Text = "注册";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(126, 324);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 26);
            this.btnLogin.TabIndex = 27;
            this.btnLogin.Text = "登录";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUserPwd
            // 
            this.lblUserPwd.Location = new System.Drawing.Point(189, 233);
            this.lblUserPwd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lblUserPwd.Name = "lblUserPwd";
            this.lblUserPwd.Size = new System.Drawing.Size(40, 14);
            this.lblUserPwd.TabIndex = 22;
            this.lblUserPwd.Text = "密   码:";
            // 
            // lblUserNo
            // 
            this.lblUserNo.Location = new System.Drawing.Point(189, 175);
            this.lblUserNo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lblUserNo.Name = "lblUserNo";
            this.lblUserNo.Size = new System.Drawing.Size(40, 14);
            this.lblUserNo.TabIndex = 21;
            this.lblUserNo.Text = "用户名:";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.Location = new System.Drawing.Point(253, 230);
            this.txtUserPwd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.Size = new System.Drawing.Size(149, 20);
            this.txtUserPwd.TabIndex = 25;
            // 
            // txtUserNo
            // 
            this.txtUserNo.Location = new System.Drawing.Point(253, 172);
            this.txtUserNo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(149, 20);
            this.txtUserNo.TabIndex = 24;
            this.txtUserNo.EditValueChanged += new System.EventHandler(this.txtUserNo_EditValueChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(75, 163);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(102, 97);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 23;
            this.pictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(542, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // FrmUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 413);
            this.Controls.Add(this.lblForgetPwd);
            this.Controls.Add(this.lblQRcode);
            this.Controls.Add(this.chkRemember);
            this.Controls.Add(this.chkAutomatic);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUserPwd);
            this.Controls.Add(this.txtUserNo);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblUserPwd);
            this.Controls.Add(this.lblUserNo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmUserLogin";
            this.Text = "登录";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmUserLogin_FormClosed);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblForgetPwd;
        private System.Windows.Forms.LinkLabel lblQRcode;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.CheckBox chkAutomatic;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.TextEdit txtUserPwd;
        private DevExpress.XtraEditors.TextEdit txtUserNo;
        private System.Windows.Forms.PictureBox pictureBox;
        private DevExpress.XtraEditors.LabelControl lblUserPwd;
        private DevExpress.XtraEditors.LabelControl lblUserNo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer;
    }
}