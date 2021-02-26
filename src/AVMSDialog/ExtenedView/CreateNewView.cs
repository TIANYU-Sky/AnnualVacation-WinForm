using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVMSDialog.ExtenedView
{
    public class CreateNewView : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView AdminList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SaveButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.TextBox AdminName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label AddAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DeleteButton;
        private AVMSDT.CreateNewFile CreateData;

        public CreateNewView(AVMSDT.CreateNewFile create) : base()
        {
            InitializeComponent();
            CreateData = create;
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaveButton = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AdminName = new System.Windows.Forms.TextBox();
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddAdmin = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 29);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "新建文件";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseButton.Location = new System.Drawing.Point(478, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(33, 21);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "×";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
            this.panel3.Controls.Add(this.DeleteButton);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.AdminList);
            this.panel3.Location = new System.Drawing.Point(263, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 216);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(98, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "管理员列表";
            // 
            // AdminList
            // 
            this.AdminList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.AdminList.FullRowSelect = true;
            this.AdminList.HideSelection = false;
            this.AdminList.Location = new System.Drawing.Point(4, 30);
            this.AdminList.Name = "AdminList";
            this.AdminList.Size = new System.Drawing.Size(253, 180);
            this.AdminList.TabIndex = 0;
            this.AdminList.UseCompatibleStateImageBehavior = false;
            this.AdminList.View = System.Windows.Forms.View.Details;
            this.AdminList.CheckBoxes = true;
            this.AdminList.MultiSelect = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "用户名";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "密码";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.White;
            this.SaveButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SaveButton.Location = new System.Drawing.Point(74, 179);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(84, 21);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "确定";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SkyBlue;
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.FileNameBox);
            this.panel4.Controls.Add(this.SaveButton);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(3, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(254, 216);
            this.panel4.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddAdmin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AdminName);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 107);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加管理员";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "用户名：";
            // 
            // AdminName
            // 
            this.AdminName.Location = new System.Drawing.Point(61, 31);
            this.AdminName.Name = "AdminName";
            this.AdminName.Size = new System.Drawing.Size(170, 21);
            this.AdminName.TabIndex = 10;
            // 
            // FileNameBox
            // 
            this.FileNameBox.Location = new System.Drawing.Point(74, 12);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(168, 21);
            this.FileNameBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "文件名：";
            // 
            // AddAdmin
            // 
            this.AddAdmin.BackColor = System.Drawing.Color.White;
            this.AddAdmin.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddAdmin.ForeColor = System.Drawing.Color.Black;
            this.AddAdmin.Location = new System.Drawing.Point(65, 66);
            this.AddAdmin.Name = "AddAdmin";
            this.AddAdmin.Size = new System.Drawing.Size(84, 25);
            this.AddAdmin.TabIndex = 6;
            this.AddAdmin.Text = "添加";
            this.AddAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddAdmin.Click += new System.EventHandler(this.AddAdmin_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.White;
            this.DeleteButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteButton.Location = new System.Drawing.Point(212, 12);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(45, 15);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "删除";
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CreateNewView
            // 
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(526, 260);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateNewView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        private void ReflushAdminList()
        {
            AdminList.Items.Clear();
            int index = 0;
            foreach (KeyValuePair<string, AVMSDT.UserLoginInformation> i in CreateData.UsersLoginInfor)
            {
                System.Windows.Forms.ListViewItem item = AdminList.Items.Add((++index).ToString());
                item.SubItems.Add(i.Key);
                item.SubItems.Add(i.Value.UserPW);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (0 == FileNameBox.TextLength)
            {
                System.Windows.Forms.MessageBox.Show("文件名不能为空", "错误", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            if (0 == CreateData.UsersLoginInfor.Count)
            {
                System.Windows.Forms.MessageBox.Show("请至少添加一个管理员", "错误", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            CreateData.FileName = FileNameBox.Text;
            DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Close();
        }

        private void AddAdmin_Click(object sender, EventArgs e)
        {
            if (0 == AdminName.TextLength)
            {
                System.Windows.Forms.MessageBox.Show("用户名不能为空", "错误", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            if (CreateData.UsersLoginInfor.ContainsKey(AdminName.Text))
            {
                System.Windows.Forms.MessageBox.Show("用户名已存在", "错误", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            CreateData.UsersLoginInfor.Add(AdminName.Text, new AVMSDT.UserLoginInformation
            {
                Department = "",
                Level = AVMSDT.UserLevel.ADMIN,
                UserPW = new AVMSBT.Encryption.MD5().Encryption(AVMSDT.StaticData.DefaultPassWord)
            });
            AdminName.Clear();
            ReflushAdminList();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (0 == AdminList.CheckedItems.Count)
            {
                System.Windows.Forms.MessageBox.Show("请选择需要删除的项", "错误", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < AdminList.CheckedItems.Count; ++i)
                CreateData.UsersLoginInfor.Remove(AdminList.CheckedItems[i].SubItems[1].Text);
            ReflushAdminList();
        }
    }
}
