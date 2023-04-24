using DevExpress.XtraEditors;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinClient;

namespace QA.winfrom
{
    public partial class FrmUserLogin : XtraForm
    {
        public FrmUserLogin()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.None;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;//常用代码
            txtUserPwd.Properties.PasswordChar = '*';
        }

        /// <summary>
        /// 注册按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>0
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.timer.Stop();
            this.Hide();
            var frm = new FrmUserRegister();
            frm.ShowDialog();
            this.Show();
            this.timer.Start();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user_no = this.txtUserNo.Text.Trim();
            var user_pwd = this.txtUserPwd.Text.Trim();
            var Automatic = this.chkAutomatic.Checked;
            var Remember = this.chkRemember.Checked;
            if (user_no == "")
            {
                MessageBox.Show("用户名不能为空");
                return;
            }
            if (user_pwd == "")
            {
                MessageBox.Show("密码不能为空");
                return;
            }
            var dt = ClassMethod.lemonSelectLogin(user_no, user_pwd);
            if (dt != null && dt.Rows.Count > 0)
            {
                var user_type = Convert.ToInt32(dt.Rows[0]["user_type"]);
                if (user_type == 1)
                {
                    this.timer.Stop();
                    var json = new { user_no = user_no, user_pwd = Remember ? user_pwd : "", Automatic = Automatic, Remember = Remember };
                    File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "zi.json", JsonConvert.SerializeObject(json));
                    this.Hide();
                    SqlHelper.user_no = user_no;
                    var frm = new FrmTeacherUserMainFrom(user_no);
                    var fan = frm.ShowDialog();
                    if (fan == DialogResult.OK) 
                    {
                        this.Show();
                        this.timer.Start();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    this.timer.Stop();
                    var json = new { user_no = user_no, user_pwd = Remember ? user_pwd : "", Automatic = Automatic, Remember = Remember };
                    File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "zi.json", JsonConvert.SerializeObject(json));
                    SqlHelper.user_no = user_no;
                    this.Hide();
                    var frm = new FrmStudentUserMainFrom(user_no);
                    var fan = frm.ShowDialog();
                    if (fan == DialogResult.OK)
                    {
                        this.Show();
                        this.timer.Start();
                    }
                    else
                    {
                        this.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("用户名或者密码错误");
                return;
            }
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {
            #region 设置pictureBox图片控件为圆的
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(pictureBox.ClientRectangle);
            Region region = new Region(gp);
            pictureBox.Region = region;
            gp.Dispose();
            region.Dispose();
            this.pictureBox.Image = QA.Properties.Resources._default;
            #endregion

            var a = AppDomain.CurrentDomain.BaseDirectory + "zi.json";//路径  
            if (File.Exists(a) == true)
            {
                dynamic json = JsonConvert.DeserializeObject(File.ReadAllText(a));
                txtUserNo.Text = json.user_no ?? "";
                txtUserPwd.Text = json.user_pwd ?? "";
                chkRemember.Checked = json.Remember ?? false;
                chkAutomatic.Checked = json.Automatic ?? false;
                if (json.Automatic == true)
                {
                    btnLogin_Click(null, null);
                }
            }
            this.timer.Start();

            //SoundPlayer sp = new SoundPlayer("C:/gjg/gjg.wav");//必须是带bai.wav扩展名的音频文件
            //sp.PlayLooping();//循环播放
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var card_no = CardReader.Read();
            if (card_no != "")
            {
                var dt = $@"select * from UserInfo where card_no=@card_no".EQ(("@card_no", card_no));
                if (dt != null && dt.Rows.Count > 0)
                {
                    var user_type = Convert.ToInt32(dt.Rows[0]["user_type"]);
                    if (user_type == 1)
                    {
                        this.timer.Stop();

                        var dr = dt.Rows[0];
                        Program.user_guid = Convert.ToString(dr["guid"]);
                        SqlHelper.user_no = Convert.ToString(dr["user_no"]);

                        this.Hide();

                        var frm = new FrmTeacherUserMainFrom();
                        var dia = frm.ShowDialog();
                        if (dia == DialogResult.OK)
                        {
                            this.Show();
                            this.timer.Start();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        this.timer.Stop();

                        var dr = dt.Rows[0];
                        Program.user_guid = Convert.ToString(dr["guid"]);
                        SqlHelper.user_no = Convert.ToString(dr["user_no"]);

                        this.Hide();

                        var frm = new FrmStudentUserMainFrom();
                        var dia = frm.ShowDialog();
                        if (dia == DialogResult.OK)
                        {
                            this.Show();
                            this.timer.Start();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
                else
                {
                    this.timer.Stop();
                    this.Hide();

                    var frm = new FrmUserRegister(card_no);
                    frm.ShowDialog();

                    this.Show();
                    this.timer.Start();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUserNo_EditValueChanged(object sender, EventArgs e)
        {
            var user_no = this.txtUserNo.Text.Trim();
             ClassobjToImage classobjTo = new ClassobjToImage();

            if (user_no != "")
            {
                var dt = $@"select * from UserInfo where user_no=@user_no".EQ(("@user_no", user_no));
                if (dt != null && dt.Rows.Count > 0)
                {
                    var dr = dt.Rows[0];
                    var photo = dr["Photo"];

                    this.pictureBox.Image = classobjTo.objToImage(photo);
                }
                else
                {
                    this.pictureBox.Image = QA.Properties.Resources._default;//图片名称
                }
            }
        }

        private void chkAutomatic_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkAutomatic.Checked == true)
            {
                this.chkRemember.Checked = true;
            }
        }

        private void chkRemember_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkRemember.Checked == false)
            {
                this.chkAutomatic.Checked = false;
            }
        }

        private void lblForgetPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.timer.Stop();
            var user_no = this.txtUserNo.Text.Trim();
            this.Hide();
            var frm = new FrmUserModifyPwd(user_no);
            frm.ShowDialog();
            this.Show();
            this.timer.Start();
        }

        private void lblQRcode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.timer.Stop();
            this.Hide();
            var frm = new FrmUserLoginQrcode();
            frm.ShowDialog();
            this.Show();
            this.timer.Start();
        }

        private void FrmUserLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
