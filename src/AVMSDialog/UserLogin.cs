using AVMSDT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVMSDialog
{
    public class UserLogin : System.Windows.Forms.Form
    {
        private UserLoginData UserData;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserPWBox;
        private System.Windows.Forms.TextBox UserNameBox;
        private new System.Windows.Forms.Label CancelButton;
        private System.Windows.Forms.Label LoginButton;

        public UserLogin(UserLoginData userdata) : base()
        {
            InitializeComponent();
            UserData = userdata;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Panel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Label();
            this.UserPWBox = new System.Windows.Forms.TextBox();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.SkyBlue;
            this.Panel.Controls.Add(this.CancelButton);
            this.Panel.Controls.Add(this.LoginButton);
            this.Panel.Controls.Add(this.UserPWBox);
            this.Panel.Controls.Add(this.UserNameBox);
            this.Panel.Controls.Add(this.label2);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Location = new System.Drawing.Point(3, 3);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(313, 132);
            this.Panel.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(161, 92);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "取消";
            this.CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.SteelBlue;
            this.LoginButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(55, 92);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(100, 23);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "登录";
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UserPWBox
            // 
            this.UserPWBox.Location = new System.Drawing.Point(87, 51);
            this.UserPWBox.Name = "UserPWBox";
            this.UserPWBox.PasswordChar = '*';
            this.UserPWBox.Size = new System.Drawing.Size(213, 21);
            this.UserPWBox.TabIndex = 3;
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(87, 22);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(213, 21);
            this.UserNameBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "密  码：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserLogin
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 138);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (0 == UserNameBox.TextLength)
            {
                System.Windows.Forms.MessageBox.Show("请输入用户名", "错误", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            if (0 == UserPWBox.TextLength)
            {
                System.Windows.Forms.MessageBox.Show("请输入密码", "错误", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            UserData.UserName = UserNameBox.Text;
            UserData.UserPW = new AVMSBT.Encryption.MD5().Encryption(UserPWBox.Text);
            DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Close();
        }
    }
}
