using AVMSDT;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVMSDialog
{
    public class LoginUser : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LogoutButton;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UserNameBox;

        private bool TileMouseDownFlag;
        private Point MousePoint;
        private System.Windows.Forms.Label ChangeUserPW;
        private AVMSDialogStatic.NoParamsFunction LogoutFunction;
        private AVMSDialogStatic.StringParamFunction ChangePWFunction;

        public LoginUser(string username, AVMSDialogStatic.NoParamsFunction logout_func, AVMSDialogStatic.StringParamFunction cpw_func) : base()
        {
            InitializeComponent();
            TileMouseDownFlag = false;
            LogoutFunction = logout_func;
            ChangePWFunction = cpw_func;
            UserNameBox.Text = username;
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChangeUserPW = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 32);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Title_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户信息";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.ChangeUserPW);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.UserNameBox);
            this.panel2.Controls.Add(this.LogoutButton);
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 132);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(82, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "只查看";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserNameBox
            // 
            this.UserNameBox.ForeColor = System.Drawing.Color.White;
            this.UserNameBox.Location = new System.Drawing.Point(82, 20);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(138, 24);
            this.UserNameBox.TabIndex = 4;
            this.UserNameBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoutButton
            // 
            this.LogoutButton.AutoSize = true;
            this.LogoutButton.BackColor = System.Drawing.Color.SkyBlue;
            this.LogoutButton.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Location = new System.Drawing.Point(226, 27);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(45, 10);
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "退出登录";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseButton.Location = new System.Drawing.Point(89, 89);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(93, 31);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "关闭";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "权  限：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "用户名：";
            // 
            // ChangeUserPW
            // 
            this.ChangeUserPW.AutoSize = true;
            this.ChangeUserPW.BackColor = System.Drawing.Color.SkyBlue;
            this.ChangeUserPW.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChangeUserPW.ForeColor = System.Drawing.Color.White;
            this.ChangeUserPW.Location = new System.Drawing.Point(226, 42);
            this.ChangeUserPW.Name = "ChangeUserPW";
            this.ChangeUserPW.Size = new System.Drawing.Size(45, 10);
            this.ChangeUserPW.TabIndex = 6;
            this.ChangeUserPW.Text = "修改密码";
            this.ChangeUserPW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChangeUserPW.Click += new System.EventHandler(this.ChangeUserPW_Click);
            // 
            // LoginUser
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(280, 179);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginUser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Title_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MousePoint = new Point(e.X, e.Y);
                TileMouseDownFlag = true;
            }
        }
        private void Title_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (TileMouseDownFlag)
                Location = new Point(Location.X + e.Location.X - MousePoint.X, Location.Y + e.Location.Y - MousePoint.Y);
        }
        private void Title_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (TileMouseDownFlag)
                TileMouseDownFlag = false;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LogoutFunction();
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeUserPW_Click(object sender, EventArgs e)
        {
            AVMSDT.StringTransPackage change = new StringTransPackage();
            if (System.Windows.Forms.DialogResult.Yes == new ChangePW(change).ShowDialog())
            {
                ChangePWFunction(change.StringPackage);
                System.Windows.Forms.MessageBox.Show("密码修改成功");
            }
        }
    }
}
