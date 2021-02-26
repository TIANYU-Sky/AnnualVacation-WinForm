using AVMSDT;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVMSDialog
{
    public class LoginAdmin : System.Windows.Forms.Form
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox UserNameText;
        private System.Windows.Forms.ComboBox UserLevelCombox;
        private System.Windows.Forms.Label AddUser;
        private System.Windows.Forms.ComboBox DepartmentComBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView LoginUserList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.ColumnHeader PassWord;
        private System.Windows.Forms.ColumnHeader UserLevel;
        private System.Windows.Forms.ColumnHeader Department;
        private System.Windows.Forms.ContextMenuStrip ViewListItemContextMenu;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripMenuItem 重置密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改部门ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改权限ToolStripMenuItem;
        private System.Windows.Forms.Label SinMultSwitchButton;
        private System.Windows.Forms.Label DeleteUserButton;
        private System.Windows.Forms.Label ChangeUserPW;

        private Point MousePoint;
        private AVMSDialogStatic.NoParamsFunction LogoutFunction;
        private bool TileMouseDownFlag;
        private Dictionary<string, UserLoginInformation> LoginUserData;
        private bool ViewListSinMultState;
        private string[] DepartmentsList;

        public LoginAdmin(string username, string[] department, Dictionary<string, UserLoginInformation> login_data, AVMSDialogStatic.NoParamsFunction logout_func) : base()
        {
            InitializeComponent();
            TileMouseDownFlag = false;
            LogoutFunction = logout_func;
            UserNameBox.Text = username;
            DepartmentsList = department;
            DepartmentComBox.Items.AddRange(department);
            LoginUserData = login_data;
            ViewListSinMultState = false;
            ReflushViewList();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ChangeUserPW = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DepartmentComBox = new System.Windows.Forms.ComboBox();
            this.AddUser = new System.Windows.Forms.Label();
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.UserLevelCombox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DeleteUserButton = new System.Windows.Forms.Label();
            this.SinMultSwitchButton = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LoginUserList = new System.Windows.Forms.ListView();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PassWord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Department = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewListItemContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.重置密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改部门ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改权限ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.ViewListItemContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 32);
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
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 98);
            this.panel2.TabIndex = 1;
            // 
            // ChangeUserPW
            // 
            this.ChangeUserPW.AutoSize = true;
            this.ChangeUserPW.BackColor = System.Drawing.Color.SkyBlue;
            this.ChangeUserPW.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChangeUserPW.ForeColor = System.Drawing.Color.White;
            this.ChangeUserPW.Location = new System.Drawing.Point(226, 43);
            this.ChangeUserPW.Name = "ChangeUserPW";
            this.ChangeUserPW.Size = new System.Drawing.Size(45, 10);
            this.ChangeUserPW.TabIndex = 6;
            this.ChangeUserPW.Text = "修改密码";
            this.ChangeUserPW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChangeUserPW.Click += new System.EventHandler(this.ChangeUserPW_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseButton.Location = new System.Drawing.Point(759, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 25);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "×";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(82, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "管理员";
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
            this.panel3.Controls.Add(this.DepartmentComBox);
            this.panel3.Controls.Add(this.AddUser);
            this.panel3.Controls.Add(this.UserNameText);
            this.panel3.Controls.Add(this.UserLevelCombox);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(3, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 142);
            this.panel3.TabIndex = 2;
            // 
            // DepartmentComBox
            // 
            this.DepartmentComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentComBox.FormattingEnabled = true;
            this.DepartmentComBox.Location = new System.Drawing.Point(74, 65);
            this.DepartmentComBox.Name = "DepartmentComBox";
            this.DepartmentComBox.Size = new System.Drawing.Size(190, 20);
            this.DepartmentComBox.TabIndex = 20;
            // 
            // AddUser
            // 
            this.AddUser.BackColor = System.Drawing.Color.White;
            this.AddUser.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddUser.Location = new System.Drawing.Point(81, 108);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(100, 23);
            this.AddUser.TabIndex = 19;
            this.AddUser.Text = "新增";
            this.AddUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // UserNameText
            // 
            this.UserNameText.Location = new System.Drawing.Point(74, 12);
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
            this.UserLevelCombox.Location = new System.Drawing.Point(74, 39);
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
            this.label7.Location = new System.Drawing.Point(11, 68);
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
            this.label10.Location = new System.Drawing.Point(11, 42);
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
            this.label11.Location = new System.Drawing.Point(12, 15);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "用户名：";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SkyBlue;
            this.panel4.Controls.Add(this.DeleteUserButton);
            this.panel4.Controls.Add(this.SinMultSwitchButton);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.LoginUserList);
            this.panel4.Location = new System.Drawing.Point(283, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(514, 246);
            this.panel4.TabIndex = 3;
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.BackColor = System.Drawing.Color.White;
            this.DeleteUserButton.Location = new System.Drawing.Point(433, 4);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(33, 15);
            this.DeleteUserButton.TabIndex = 6;
            this.DeleteUserButton.Text = "删除";
            this.DeleteUserButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // SinMultSwitchButton
            // 
            this.SinMultSwitchButton.BackColor = System.Drawing.Color.White;
            this.SinMultSwitchButton.Location = new System.Drawing.Point(472, 4);
            this.SinMultSwitchButton.Name = "SinMultSwitchButton";
            this.SinMultSwitchButton.Size = new System.Drawing.Size(33, 15);
            this.SinMultSwitchButton.TabIndex = 5;
            this.SinMultSwitchButton.Text = "多选";
            this.SinMultSwitchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SinMultSwitchButton.Click += new System.EventHandler(this.SinMultSwitchButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(238, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "用户列表";
            // 
            // LoginUserList
            // 
            this.LoginUserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.UserName,
            this.PassWord,
            this.UserLevel,
            this.Department});
            this.LoginUserList.FullRowSelect = true;
            this.LoginUserList.HideSelection = false;
            this.LoginUserList.Location = new System.Drawing.Point(7, 22);
            this.LoginUserList.MultiSelect = false;
            this.LoginUserList.Name = "LoginUserList";
            this.LoginUserList.Size = new System.Drawing.Size(498, 213);
            this.LoginUserList.TabIndex = 0;
            this.LoginUserList.UseCompatibleStateImageBehavior = false;
            this.LoginUserList.View = System.Windows.Forms.View.Details;
            this.LoginUserList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ViewList_Click);
            // 
            // Index
            // 
            this.Index.Text = "序号";
            // 
            // UserName
            // 
            this.UserName.Text = "用户名";
            this.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserName.Width = 120;
            // 
            // PassWord
            // 
            this.PassWord.Text = "密码";
            this.PassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassWord.Width = 100;
            // 
            // UserLevel
            // 
            this.UserLevel.Text = "权限";
            this.UserLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserLevel.Width = 100;
            // 
            // Department
            // 
            this.Department.Text = "部门";
            this.Department.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Department.Width = 100;
            // 
            // ViewListItemContextMenu
            // 
            this.ViewListItemContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重置密码ToolStripMenuItem,
            this.修改部门ToolStripMenuItem,
            this.修改权限ToolStripMenuItem});
            this.ViewListItemContextMenu.Name = "ViewListItemContextMenu";
            this.ViewListItemContextMenu.Size = new System.Drawing.Size(125, 70);
            // 
            // 重置密码ToolStripMenuItem
            // 
            this.重置密码ToolStripMenuItem.Name = "重置密码ToolStripMenuItem";
            this.重置密码ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.重置密码ToolStripMenuItem.Text = "重置密码";
            this.重置密码ToolStripMenuItem.Click += new System.EventHandler(this.重置密码ToolStripMenuItem_Click);
            // 
            // 修改部门ToolStripMenuItem
            // 
            this.修改部门ToolStripMenuItem.Name = "修改部门ToolStripMenuItem";
            this.修改部门ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改部门ToolStripMenuItem.Text = "修改部门";
            this.修改部门ToolStripMenuItem.Click += new System.EventHandler(this.修改部门ToolStripMenuItem_Click);
            // 
            // 修改权限ToolStripMenuItem
            // 
            this.修改权限ToolStripMenuItem.Name = "修改权限ToolStripMenuItem";
            this.修改权限ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改权限ToolStripMenuItem.Text = "修改权限";
            this.修改权限ToolStripMenuItem.Click += new System.EventHandler(this.修改权限ToolStripMenuItem_Click);
            // 
            // LoginAdmin
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 293);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginAdmin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ViewListItemContextMenu.ResumeLayout(false);
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
            if (0 != UserLevelCombox.SelectedIndex)
            {
                DepartmentComBox.SelectedIndex = -1;
                DepartmentComBox.Enabled = false;
            }
            else
                DepartmentComBox.Enabled = true;
        }
        private void AddUser_Click(object sender, EventArgs e)
        {
            if (0 == UserNameText.TextLength)
            {
                System.Windows.Forms.MessageBox.Show("请输入用户名", "错误", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            if (0 > UserLevelCombox.SelectedIndex)
            {
                System.Windows.Forms.MessageBox.Show("请选择权限", "错误", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            if (0 == UserLevelCombox.SelectedIndex && 0 > DepartmentComBox.SelectedIndex)
            {
                System.Windows.Forms.MessageBox.Show("请选择部门", "错误", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            if (!LoginUserData.ContainsKey(UserNameText.Text))
            {
                LoginUserData.Add(UserNameText.Text, new UserLoginInformation
                {
                    UserPW = new AVMSBT.Encryption.MD5().Encryption(StaticData.DefaultPassWord),
                    Level = 0 == UserLevelCombox.SelectedIndex ? AVMSDT.UserLevel.DEPARTMENT : AVMSDT.UserLevel.READ_ONLY,
                    Department = 0 == UserLevelCombox.SelectedIndex ? (string)DepartmentComBox.SelectedItem : ""
                });
                UserNameText.Text = "";
                UserLevelCombox.SelectedIndex = -1;
                DepartmentComBox.SelectedIndex = -1;
                ReflushViewList();
                System.Windows.Forms.MessageBox.Show("用户添加成功", "消息", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            else
                System.Windows.Forms.MessageBox.Show("添加失败（用户已经存在）", "错误", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }
        private void ChangeUserPW_Click(object sender, EventArgs e)
        {
            AVMSDT.StringTransPackage change = new StringTransPackage();
            if (System.Windows.Forms.DialogResult.Yes == new ChangePW(change).ShowDialog()) 
            {
                LoginUserData[UserNameBox.Text].UserPW = change.StringPackage;
                ReflushViewList();
                System.Windows.Forms.MessageBox.Show("密码修改成功");
            }
        }

        private void ViewList_Click(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (System.Windows.Forms.MouseButtons.Right == e.Button)
                ViewListItemContextMenu.Show(LoginUserList, e.Location);
        }
        private void SinMultSwitchButton_Click(object sender, EventArgs e)
        {
            ViewListSinMultState = !ViewListSinMultState;
            if (ViewListSinMultState)
            {
                LoginUserList.MultiSelect = true;
                SinMultSwitchButton.Text = "单选";
            }
            else
            {
                LoginUserList.MultiSelect = false;
                SinMultSwitchButton.Text = "多选";
            }
        }
        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (0 == LoginUserList.SelectedItems.Count)
                System.Windows.Forms.MessageBox.Show("请选择一个用户用于删除", "消息", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            else
            {
                if (System.Windows.Forms.DialogResult.Yes != System.Windows.Forms.MessageBox.Show("是否删除这些用户", "", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                    return;
                bool admin = false;
                for(int i = 0; i < LoginUserList.SelectedItems.Count; ++i)
                {
                    switch (LoginUserList.SelectedItems[i].SubItems[4].Text)
                    {
                        case StaticData.UserLevelStrings.UserLevelAdmin:
                            admin = true;
                            continue;
                        default:
                            LoginUserData.Remove(LoginUserList.SelectedItems[i].SubItems[1].Text);
                            break;
                    }
                }
                if (admin)
                    System.Windows.Forms.MessageBox.Show("管理员用户无法删除", "消息", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                ReflushViewList();
            }
        }

        private void 重置密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ListViewItem selected = LoginUserList.SelectedItems[0];
            if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show("是否重置密码？", "", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                LoginUserData[selected.SubItems[1].Text].UserPW = new AVMSBT.Encryption.MD5().Encryption(StaticData.DefaultPassWord);
            ReflushViewList();
        }
        private void 修改部门ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ListViewItem selected = LoginUserList.SelectedItems[0];
            if (StaticData.UserLevelStrings.UserLevelDepartment == selected.SubItems[4].Text)
            {
                StringTransPackage change = new StringTransPackage
                {
                    StringPackage = selected.SubItems[3].Text
                };
                if (System.Windows.Forms.DialogResult.Yes == new ChangeDepartment(change, DepartmentsList).ShowDialog())
                {
                    LoginUserData[selected.SubItems[1].Text].Department = change.StringPackage;
                    ReflushViewList();
                }
            }
            else
                System.Windows.Forms.MessageBox.Show("非部门管理员不可修改部门", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }
        private void 修改权限ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ListViewItem selected = LoginUserList.SelectedItems[0];
            if (StaticData.UserLevelStrings.UserLevelAdmin == selected.SubItems[4].Text)
            {
                System.Windows.Forms.MessageBox.Show("无法更改管理员的权限", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                return;
            }
            StringTransPackage changedep = new StringTransPackage();
            ObjectTransPackage changelev = new ObjectTransPackage
            {
                TransPackage = selected.SubItems[4].Text
            };
            if (System.Windows.Forms.DialogResult.Yes == new ChangeLevel(changelev, changedep, DepartmentsList).ShowDialog())
            {
                LoginUserData[selected.SubItems[1].Text].Level = (AVMSDT.UserLevel)changelev.TransPackage;
                if (AVMSDT.UserLevel.DEPARTMENT == (AVMSDT.UserLevel)changelev.TransPackage)
                    LoginUserData[selected.SubItems[1].Text].Department = changedep.StringPackage;
                else
                    LoginUserData[selected.SubItems[1].Text].Department = "";
                ReflushViewList();
            }
        }

        private void ReflushViewList()
        {
            LoginUserList.Items.Clear();
            int index = 0;
            foreach (KeyValuePair<string, UserLoginInformation> i in LoginUserData)
            {
                System.Windows.Forms.ListViewItem item = LoginUserList.Items.Add((++index).ToString());
                item.SubItems.Add(i.Key);
                item.SubItems.Add(i.Value.UserPW);
                switch (i.Value.Level)
                {
                    case AVMSDT.UserLevel.ADMIN:
                        item.SubItems.Add(StaticData.UserLevelStrings.UserLevelAdmin);
                        break;
                    case AVMSDT.UserLevel.DEPARTMENT:
                        item.SubItems.Add(StaticData.UserLevelStrings.UserLevelDepartment);
                        break;
                    case AVMSDT.UserLevel.READ_ONLY:
                        item.SubItems.Add(StaticData.UserLevelStrings.UserLevelReadOnly);
                        break;
                }
                item.SubItems.Add(i.Value.Department);
            }
        }

    }
}
