using AVMSDT;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVMSDialog.MainSubView
{
    public class DepartmentManage : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView DepartmentList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DeleteButton;
        private System.Windows.Forms.Label AddButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton SubDepartmentNo;
        private System.Windows.Forms.RadioButton SubDepartmentYes;
        private System.Windows.Forms.TextBox AddDepartmentName;
        private System.Windows.Forms.Label DepartmentCount;
        private System.Windows.Forms.Label SaveButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox DepartmentName;

        private Dictionary<string, DepartmentOperationData> EmployeeData;
        private Dictionary<string, UserLoginInformation> LoginData;
        private string SelectedDepartmentName;
        private Point MousePoint;
        private bool TileMouseDownFlag;

        public DepartmentManage(Dictionary<string, DepartmentOperationData> employeedata, Dictionary<string, UserLoginInformation> logindata) : base()
        {
            InitializeComponent();
            EmployeeData = employeedata;
            LoginData = logindata;
            SelectedDepartmentName = "";
            DeleteButton.Visible = false;
            SaveButton.Visible = false;
            SubDepartmentNo.Checked = true;
            DepartmentName.Enabled = false;
            Init();
        }

        private void InitializeComponent()
        {
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DepartmentList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.DepartmentName = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Label();
            this.DepartmentCount = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddDepartmentName = new System.Windows.Forms.TextBox();
            this.SubDepartmentNo = new System.Windows.Forms.RadioButton();
            this.SubDepartmentYes = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Label();
            this.TitlePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.SkyBlue;
            this.TitlePanel.Controls.Add(this.CloseButton);
            this.TitlePanel.Controls.Add(this.label1);
            this.TitlePanel.Location = new System.Drawing.Point(3, 3);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(494, 29);
            this.TitlePanel.TabIndex = 0;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(Title_MouseDown);
            this.TitlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(Title_MouseMove);
            this.TitlePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(Title_MouseUp);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseButton.Location = new System.Drawing.Point(452, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(33, 21);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "×";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "部门管理";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.DepartmentList);
            this.panel1.Location = new System.Drawing.Point(3, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 233);
            this.panel1.TabIndex = 1;
            // 
            // DepartmentList
            // 
            this.DepartmentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.DepartmentList.FullRowSelect = true;
            this.DepartmentList.HideSelection = false;
            this.DepartmentList.Location = new System.Drawing.Point(3, 6);
            this.DepartmentList.Name = "DepartmentList";
            this.DepartmentList.Size = new System.Drawing.Size(240, 218);
            this.DepartmentList.TabIndex = 0;
            this.DepartmentList.UseCompatibleStateImageBehavior = false;
            this.DepartmentList.View = System.Windows.Forms.View.Details;
            this.DepartmentList.SelectedIndexChanged += new System.EventHandler(this.DepartmentSelected_Change);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "部门";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.DepartmentName);
            this.panel2.Controls.Add(this.SaveButton);
            this.panel2.Controls.Add(this.DepartmentCount);
            this.panel2.Controls.Add(this.DeleteButton);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(255, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 110);
            this.panel2.TabIndex = 2;
            // 
            // DepartmentName
            // 
            this.DepartmentName.Location = new System.Drawing.Point(79, 28);
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.Size = new System.Drawing.Size(143, 21);
            this.DepartmentName.TabIndex = 6;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.White;
            this.SaveButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SaveButton.Location = new System.Drawing.Point(126, 80);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(84, 21);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "保存";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DepartmentCount
            // 
            this.DepartmentCount.Location = new System.Drawing.Point(80, 53);
            this.DepartmentCount.Name = "DepartmentCount";
            this.DepartmentCount.Size = new System.Drawing.Size(142, 12);
            this.DepartmentCount.TabIndex = 4;
            this.DepartmentCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.White;
            this.DeleteButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteButton.Location = new System.Drawing.Point(36, 80);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(84, 21);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "删除";
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteButton.Click += new EventHandler(this.DeleteButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "部门人数：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "部门名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(97, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "部门详情";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
            this.panel3.Controls.Add(this.AddDepartmentName);
            this.panel3.Controls.Add(this.SubDepartmentNo);
            this.panel3.Controls.Add(this.SubDepartmentYes);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.AddButton);
            this.panel3.Location = new System.Drawing.Point(255, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 119);
            this.panel3.TabIndex = 3;
            // 
            // AddDepartmentName
            // 
            this.AddDepartmentName.Location = new System.Drawing.Point(79, 29);
            this.AddDepartmentName.Name = "AddDepartmentName";
            this.AddDepartmentName.Size = new System.Drawing.Size(154, 21);
            this.AddDepartmentName.TabIndex = 7;
            // 
            // SubDepartmentNo
            // 
            this.SubDepartmentNo.AutoSize = true;
            this.SubDepartmentNo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SubDepartmentNo.ForeColor = System.Drawing.Color.White;
            this.SubDepartmentNo.Location = new System.Drawing.Point(131, 60);
            this.SubDepartmentNo.Name = "SubDepartmentNo";
            this.SubDepartmentNo.Size = new System.Drawing.Size(36, 16);
            this.SubDepartmentNo.TabIndex = 6;
            this.SubDepartmentNo.TabStop = true;
            this.SubDepartmentNo.Text = "无";
            this.SubDepartmentNo.UseVisualStyleBackColor = true;
            // 
            // SubDepartmentYes
            // 
            this.SubDepartmentYes.AutoSize = true;
            this.SubDepartmentYes.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SubDepartmentYes.ForeColor = System.Drawing.Color.White;
            this.SubDepartmentYes.Location = new System.Drawing.Point(80, 60);
            this.SubDepartmentYes.Name = "SubDepartmentYes";
            this.SubDepartmentYes.Size = new System.Drawing.Size(36, 16);
            this.SubDepartmentYes.TabIndex = 5;
            this.SubDepartmentYes.TabStop = true;
            this.SubDepartmentYes.Text = "有";
            this.SubDepartmentYes.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "子 部 门：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(97, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "部门新增";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "部门名称：";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.White;
            this.AddButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddButton.Location = new System.Drawing.Point(83, 89);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(84, 21);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "添加";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DepartmentManage
            // 
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(500, 274);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepartmentManage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }
        private void Init()
        {
            ReflushViewList();
        }
        private void ReflushViewList()
        {
            DepartmentList.Items.Clear();
            int index = 0;
            foreach (string i in EmployeeData.Keys)
            {
                System.Windows.Forms.ListViewItem item = DepartmentList.Items.Add((++index).ToString());
                item.SubItems.Add(i);
            }
            DepartmentName.Text = "";
            DepartmentCount.Text = "";
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

        private void DepartmentSelected_Change(object sender, EventArgs e)
        {
            if (0 != DepartmentList.SelectedItems.Count)
            {
                SelectedDepartmentName = DepartmentList.SelectedItems[0].SubItems[1].Text;
                DepartmentCount.Text = EmployeeData[SelectedDepartmentName].Empolyees.Count.ToString();
                if ("" == SelectedDepartmentName)
                {
                    DeleteButton.Visible = false;
                    SaveButton.Visible = false;
                    DepartmentName.Enabled = false;
                    DepartmentName.Text = "未分类部门";
                }
                else
                {
                    DeleteButton.Visible = true;
                    SaveButton.Visible = true;
                    DepartmentName.Enabled = true;
                    DepartmentName.Text = SelectedDepartmentName;
                }
            }
            else
            {
                DepartmentName.Clear();
                DepartmentCount.Text = "";
                DeleteButton.Visible = false;
                SaveButton.Visible = false;
                DepartmentName.Enabled = false;
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show("是否删除部门：" + SelectedDepartmentName + "？\n如果删除部门，该部门管理员也将被移除", "提示", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question)) 
            {
                // 将该部门人员移至未分类部分
                EmployeeData[""].Empolyees = EmployeeData[""].Empolyees.Concat(EmployeeData[SelectedDepartmentName].Empolyees).ToDictionary(k => k.Key, v => v.Value);
                // 将该部门管理员删除
                List<string> slist = new List<string>();
                foreach (KeyValuePair<string, UserLoginInformation> i in LoginData)
                    if (UserLevel.DEPARTMENT == i.Value.Level && i.Value.Department == SelectedDepartmentName)
                        slist.Add(i.Key);
                foreach (string i in slist)
                    LoginData.Remove(i);
                // 删除该部门
                EmployeeData.Remove(SelectedDepartmentName);
                SelectedDepartmentName = "";
                ReflushViewList();
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SelectedDepartmentName != DepartmentName.Text)
            {
                // 修改该部门名称
                if (EmployeeData.TryGetValue(SelectedDepartmentName, out DepartmentOperationData value)) 
                {
                    EmployeeData.Remove(SelectedDepartmentName);
                    EmployeeData.Add(DepartmentName.Text, value);
                    SelectedDepartmentName = "";
                }
                // 修改该部门管理员的部门名称
                foreach (KeyValuePair<string, UserLoginInformation> i in LoginData)
                    if (UserLevel.DEPARTMENT == i.Value.Level && i.Value.Department == SelectedDepartmentName)
                        i.Value.Department = DepartmentName.Text;
                ReflushViewList();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (0 == AddDepartmentName.TextLength)
                System.Windows.Forms.MessageBox.Show("部门名称不能为空", "错误", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            else if (EmployeeData.ContainsKey(AddDepartmentName.Text))
                System.Windows.Forms.MessageBox.Show("部门名称已存在", "错误", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            else
            {
                EmployeeData.Add(AddDepartmentName.Text, new DepartmentOperationData
                {
                    IsOpen = true,
                    SubDepartment = SubDepartmentYes.Checked,
                    FileID = Guid.NewGuid().ToString(),
                    Empolyees = new Dictionary<string, EmployeePersonalInformation>()
                });
                ReflushViewList();
                AddDepartmentName.Clear();
                SubDepartmentNo.Checked = true;
                SubDepartmentYes.Checked = false;
                //System.Windows.Forms.MessageBox.Show("添加成功", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
    }
}
