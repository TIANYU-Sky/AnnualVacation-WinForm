using AVMSDT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVMSDialog
{
    internal class ChangePW : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label YesButton;
        private System.Windows.Forms.TextBox PWBox;
        private new System.Windows.Forms.Label CancelButton;
        private System.Windows.Forms.Label PWSee;
        private System.Windows.Forms.Label label1;

        private StringTransPackage UserPW;

        public ChangePW(StringTransPackage changepw) : base()
        {
            InitializeComponent();
            UserPW = changepw;
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.PWSee = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Label();
            this.YesButton = new System.Windows.Forms.Label();
            this.PWBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.PWSee);
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.YesButton);
            this.panel1.Controls.Add(this.PWBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 97);
            this.panel1.TabIndex = 0;
            // 
            // PWSee
            // 
            this.PWSee.BackColor = System.Drawing.Color.White;
            this.PWSee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PWSee.Location = new System.Drawing.Point(275, 23);
            this.PWSee.Name = "PWSee";
            this.PWSee.Size = new System.Drawing.Size(28, 21);
            this.PWSee.TabIndex = 4;
            this.PWSee.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PWSee_MouseDown);
            this.PWSee.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PWSee_MouseUp);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(164, 54);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "取消";
            this.CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // YesButton
            // 
            this.YesButton.BackColor = System.Drawing.Color.White;
            this.YesButton.Location = new System.Drawing.Point(58, 54);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(100, 23);
            this.YesButton.TabIndex = 2;
            this.YesButton.Text = "确定";
            this.YesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // PWBox
            // 
            this.PWBox.Location = new System.Drawing.Point(83, 23);
            this.PWBox.Name = "PWBox";
            this.PWBox.PasswordChar = '*';
            this.PWBox.Size = new System.Drawing.Size(193, 21);
            this.PWBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "新的密码：";
            // 
            // ChangePW
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(326, 103);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePW";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void PWSee_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            PWBox.PasswordChar = '\0';
        }
        private void PWSee_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            PWBox.PasswordChar = '*';
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            if (0 == PWBox.TextLength)
            {
                System.Windows.Forms.MessageBox.Show("请输入密码", "错误", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            UserPW.StringPackage = new AVMSBT.Encryption.MD5().Encryption(PWBox.Text);
            DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Close();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
