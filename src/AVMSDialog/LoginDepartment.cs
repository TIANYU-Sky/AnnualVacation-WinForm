using AVMSDT;
using System;
using System.Drawing;

namespace AVMSDialog
{
    public class LoginDepartment : System.Windows.Forms.Form
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label DepartmentNameBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UserPWText;
        private System.Windows.Forms.TextBox UserDepartmentText;
        private System.Windows.Forms.TextBox UserNameText;
        private System.Windows.Forms.ComboBox UserLevelCombox;
        private System.Windows.Forms.Label AddUser;

        private AVMSDialogStatic.NoParamsFunction LogoutFunction;
        private AVMSDialogStatic.DepartmentAddFunction AddUserFunction;
        private AVMSDialogStatic.StringParamFunction ChangePWFunction;
        private bool TileMouseDownFlag;
        private System.Windows.Forms.Label ChangeUserPW;
        private Point MousePoint;

        public LoginDepartment(string username, string department, AVMSDialogStatic.NoParamsFunction logout_func, AVMSDialogStatic.DepartmentAddFunction add_func, AVMSDialogStatic.StringParamFunction cpw_func) : base()
        {
            InitializeComponent();
            TileMouseDownFlag = false;
            LogoutFunction = logout_func;
            AddUserFunction = add_func;
            ChangePWFunction = cpw_func;
            UserNameBox.Text = username;
            DepartmentNameBox.Text = department;
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ChangeUserPW = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.DepartmentNameBox = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddUser = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UserPWText = new System.Windows.Forms.TextBox();
            this.UserDepartmentText = new System.Windows.Forms.TextBox();
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.UserLevelCombox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CloseButton);
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
            this.panel2.Controls.Add(this.DepartmentNameBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.UserNameBox);
            this.panel2.Controls.Add(this.LogoutButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 121);
            this.panel2.TabIndex = 1;
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
            this.ChangeUserPW.TabIndex = 8;
            this.ChangeUserPW.Text = "修改密码";
            this.ChangeUserPW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChangeUserPW.Click += new System.EventHandler(this.ChangeUserPW_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseButton.Location = new System.Drawing.Point(228, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(37, 22);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "×";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DepartmentNameBox
            // 
            this.DepartmentNameBox.ForeColor = System.Drawing.Color.White;
            this.DepartmentNameBox.Location = new System.Drawing.Point(82, 87);
            this.DepartmentNameBox.Name = "DepartmentNameBox";
            this.DepartmentNameBox.Size = new System.Drawing.Size(138, 24);
            this.DepartmentNameBox.TabIndex = 7;
            this.DepartmentNameBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "部  门：";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(82, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "部门管理员";
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
            this.panel3.Controls.Add(this.AddUser);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.UserPWText);
            this.panel3.Controls.Add(this.UserDepartmentText);
            this.panel3.Controls.Add(this.UserNameText);
            this.panel3.Controls.Add(this.UserLevelCombox);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(3, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 160);
            this.panel3.TabIndex = 2;
            // 
            // AddUser
            // 
            this.AddUser.BackColor = System.Drawing.Color.White;
            this.AddUser.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddUser.Location = new System.Drawing.Point(88, 121);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(100, 23);
            this.AddUser.TabIndex = 19;
            this.AddUser.Text = "新增";
            this.AddUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "密  码：";
            // 
            // UserPWText
            // 
            this.UserPWText.Location = new System.Drawing.Point(75, 36);
            this.UserPWText.Name = "UserPWText";
            this.UserPWText.PasswordChar = '*';
            this.UserPWText.Size = new System.Drawing.Size(190, 21);
            this.UserPWText.TabIndex = 17;
            // 
            // UserDepartmentText
            // 
            this.UserDepartmentText.Location = new System.Drawing.Point(75, 89);
            this.UserDepartmentText.Name = "UserDepartmentText";
            this.UserDepartmentText.ReadOnly = true;
            this.UserDepartmentText.Size = new System.Drawing.Size(190, 21);
            this.UserDepartmentText.TabIndex = 16;
            // 
            // UserNameText
            // 
            this.UserNameText.Location = new System.Drawing.Point(75, 9);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(190, 21);
            this.UserNameText.TabIndex = 15;
            // 
            // UserLevelCombox
            // 
            this.UserLevelCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserLevelCombox.FormattingEnabled = true;
            this.UserLevelCombox.Items.AddRange(new object[] {
            "部门可见",
            "只查看"});
            this.UserLevelCombox.Location = new System.Drawing.Point(75, 63);
            this.UserLevelCombox.Name = "UserLevelCombox";
            this.UserLevelCombox.Size = new System.Drawing.Size(190, 20);
            this.UserLevelCombox.TabIndex = 14;
            this.UserLevelCombox.SelectedIndexChanged += new System.EventHandler(this.LevelComBox_Change);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "部  门：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 66);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "权  限：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(13, 12);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "用户名：";
            // 
            // LoginDepartment
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(280, 334);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginDepartment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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

        private void LevelComBox_Change(object sender, EventArgs e)
        {
            if (0 == UserLevelCombox.SelectedIndex)
                UserDepartmentText.Text = DepartmentNameBox.Text;
            else
                UserDepartmentText.Text = "";
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            if (0 == UserNameText.TextLength)
            {
                System.Windows.Forms.MessageBox.Show("请输入用户名", "错误", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            if (0 == UserPWText.TextLength)
            {
                System.Windows.Forms.MessageBox.Show("请输入密码", "错误", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            switch(AddUserFunction
                (UserNameText.Text,
                UserPWText.Text,
                0==UserLevelCombox.SelectedIndex? 
                AVMSDialogStatic.UserAddLevel.Department: 
                AVMSDialogStatic.UserAddLevel.Read_Only))
            {
                case AVMSDialogStatic.AddResult.Failure:
                    System.Windows.Forms.MessageBox.Show("添加失败 请重试", "错误", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    break;
                case AVMSDialogStatic.AddResult.Repetition:
                    System.Windows.Forms.MessageBox.Show("添加失败（用户已经存在）", "错误", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    break;
                case AVMSDialogStatic.AddResult.Successful:
                default:
                    System.Windows.Forms.MessageBox.Show("用户添加成功", "消息", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    break;
            }
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
