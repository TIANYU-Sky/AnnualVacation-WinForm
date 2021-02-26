using AVMSDT;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVMSDialog.MainSubView
{
    public class EmployeeManage : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SelectCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NoneToDepartment;
        private System.Windows.Forms.Label DepartmentToNone;
        private System.Windows.Forms.Label NoneDepartmentSelectCount;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox EmployeeCalculateType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label SaveButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox EmployeeStaticTimeBox;
        private System.Windows.Forms.TextBox EmployeeSubDepartmentBox;
        private System.Windows.Forms.Label EmployeeNumber;
        private System.Windows.Forms.Label EmployeeName;
        private System.Windows.Forms.Label EmployeeWorkDate;
        private System.Windows.Forms.Label EmployeeDepartment;
        private System.Windows.Forms.Label AddButton;
        private System.Windows.Forms.Label DeleteButton;
        private System.Windows.Forms.CheckBox AddAutoCalculate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox AddStaticValue;
        private System.Windows.Forms.TextBox AddName;
        private System.Windows.Forms.TextBox AddJobNumber;
        private System.Windows.Forms.DateTimePicker AddWorkDate;
        private System.Windows.Forms.ListView EmployeeSelectList;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.TextBox AddEnglishName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label EmployeeEnglishName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView NoneDepartmentList;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private bool TileMouseDownFlag;

        private Dictionary<string, DepartmentOperationData> EmployeeData;
        private AVMSDT.StaticData.OneStringParamBoolReturnDelegate LoadFileFunction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TotalCount;
        private System.Windows.Forms.Label label5;
        private Point MousePoint;

        public EmployeeManage(Dictionary<string, DepartmentOperationData> employeedata, AVMSDT.StaticData.OneStringParamBoolReturnDelegate loadfile_func) : base()
        {
            InitializeComponent();
            SaveButton.Visible = false;
            EmployeeData = employeedata;
            LoadFileFunction = loadfile_func;

            foreach (string i in EmployeeData.Keys)
                DepartmentComboBox.Items.Add(i);
            DepartmentComboBox.SelectedIndex = 0;
            ReflushNoneDepartmentEmployeeList();
            ReflushEmployeeList();
        }

        private void InitializeComponent()
        {
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NoneDepartmentList = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeSelectList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeleteButton = new System.Windows.Forms.Label();
            this.NoneDepartmentSelectCount = new System.Windows.Forms.Label();
            this.NoneToDepartment = new System.Windows.Forms.Label();
            this.DepartmentToNone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EmployeeEnglishName = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.EmployeeDepartment = new System.Windows.Forms.Label();
            this.EmployeeWorkDate = new System.Windows.Forms.Label();
            this.EmployeeName = new System.Windows.Forms.Label();
            this.EmployeeNumber = new System.Windows.Forms.Label();
            this.EmployeeSubDepartmentBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.EmployeeStaticTimeBox = new System.Windows.Forms.TextBox();
            this.EmployeeCalculateType = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddEnglishName = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.AddWorkDate = new System.Windows.Forms.DateTimePicker();
            this.AddName = new System.Windows.Forms.TextBox();
            this.AddJobNumber = new System.Windows.Forms.TextBox();
            this.AddStaticValue = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.AddAutoCalculate = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TitlePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.SkyBlue;
            this.TitlePanel.Controls.Add(this.label6);
            this.TitlePanel.Controls.Add(this.CloseButton);
            this.TitlePanel.Location = new System.Drawing.Point(3, 3);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(800, 29);
            this.TitlePanel.TabIndex = 0;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.TitlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            this.TitlePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Title_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 14);
            this.label6.TabIndex = 2;
            this.label6.Text = "员工管理";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(745, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(46, 23);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.Text = "×";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.TotalCount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.NoneDepartmentList);
            this.panel1.Controls.Add(this.EmployeeSelectList);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.NoneDepartmentSelectCount);
            this.panel1.Controls.Add(this.NoneToDepartment);
            this.panel1.Controls.Add(this.DepartmentToNone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SelectCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DepartmentComboBox);
            this.panel1.Location = new System.Drawing.Point(3, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 409);
            this.panel1.TabIndex = 1;
            // 
            // TotalCount
            // 
            this.TotalCount.Location = new System.Drawing.Point(195, 38);
            this.TotalCount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TotalCount.Name = "TotalCount";
            this.TotalCount.Size = new System.Drawing.Size(48, 14);
            this.TotalCount.TabIndex = 19;
            this.TotalCount.Text = "0";
            this.TotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(159, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 14);
            this.label5.TabIndex = 18;
            this.label5.Text = "全部";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(65, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "已选择";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NoneDepartmentList
            // 
            this.NoneDepartmentList.CheckBoxes = true;
            this.NoneDepartmentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.NoneDepartmentList.FullRowSelect = true;
            this.NoneDepartmentList.HideSelection = false;
            this.NoneDepartmentList.Location = new System.Drawing.Point(309, 57);
            this.NoneDepartmentList.Name = "NoneDepartmentList";
            this.NoneDepartmentList.Size = new System.Drawing.Size(200, 339);
            this.NoneDepartmentList.TabIndex = 15;
            this.NoneDepartmentList.UseCompatibleStateImageBehavior = false;
            this.NoneDepartmentList.View = System.Windows.Forms.View.Details;
            this.NoneDepartmentList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.NoneDepartmentList_ItemChecked);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "序号";
            this.columnHeader5.Width = 40;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "工号";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "中文名";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "英文名";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 100;
            // 
            // EmployeeSelectList
            // 
            this.EmployeeSelectList.CheckBoxes = true;
            this.EmployeeSelectList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.EmployeeSelectList.FullRowSelect = true;
            this.EmployeeSelectList.HideSelection = false;
            this.EmployeeSelectList.Location = new System.Drawing.Point(67, 57);
            this.EmployeeSelectList.Name = "EmployeeSelectList";
            this.EmployeeSelectList.Size = new System.Drawing.Size(175, 339);
            this.EmployeeSelectList.TabIndex = 14;
            this.EmployeeSelectList.UseCompatibleStateImageBehavior = false;
            this.EmployeeSelectList.View = System.Windows.Forms.View.Details;
            this.EmployeeSelectList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.DepartmentList_ItemChecked);
            this.EmployeeSelectList.SelectedIndexChanged += new System.EventHandler(this.DepartmentList_ItemCheckedChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "工号";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "中文名";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "英文名";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(471, 34);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(38, 20);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "删除";
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NoneDepartmentSelectCount
            // 
            this.NoneDepartmentSelectCount.Location = new System.Drawing.Point(307, 38);
            this.NoneDepartmentSelectCount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.NoneDepartmentSelectCount.Name = "NoneDepartmentSelectCount";
            this.NoneDepartmentSelectCount.Size = new System.Drawing.Size(82, 14);
            this.NoneDepartmentSelectCount.TabIndex = 11;
            this.NoneDepartmentSelectCount.Text = "0/0";
            this.NoneDepartmentSelectCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NoneToDepartment
            // 
            this.NoneToDepartment.BackColor = System.Drawing.Color.White;
            this.NoneToDepartment.Location = new System.Drawing.Point(248, 194);
            this.NoneToDepartment.Name = "NoneToDepartment";
            this.NoneToDepartment.Size = new System.Drawing.Size(55, 25);
            this.NoneToDepartment.TabIndex = 10;
            this.NoneToDepartment.Text = "←";
            this.NoneToDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NoneToDepartment.Click += new System.EventHandler(this.NoneToDepartment_Click);
            // 
            // DepartmentToNone
            // 
            this.DepartmentToNone.BackColor = System.Drawing.Color.White;
            this.DepartmentToNone.Location = new System.Drawing.Point(248, 158);
            this.DepartmentToNone.Name = "DepartmentToNone";
            this.DepartmentToNone.Size = new System.Drawing.Size(55, 25);
            this.DepartmentToNone.TabIndex = 9;
            this.DepartmentToNone.Text = "→";
            this.DepartmentToNone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DepartmentToNone.Click += new System.EventHandler(this.DepartmentToNone_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(306, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "非部门员工：";
            // 
            // SelectCount
            // 
            this.SelectCount.Location = new System.Drawing.Point(109, 38);
            this.SelectCount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.SelectCount.Name = "SelectCount";
            this.SelectCount.Size = new System.Drawing.Size(48, 14);
            this.SelectCount.TabIndex = 5;
            this.SelectCount.Text = "0";
            this.SelectCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "员工：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "部门：";
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(67, 10);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(175, 20);
            this.DepartmentComboBox.TabIndex = 0;
            this.DepartmentComboBox.SelectedIndexChanged += new System.EventHandler(this.DepartmentCBValue_Changed);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.EmployeeEnglishName);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.EmployeeDepartment);
            this.panel2.Controls.Add(this.EmployeeWorkDate);
            this.panel2.Controls.Add(this.EmployeeName);
            this.panel2.Controls.Add(this.EmployeeNumber);
            this.panel2.Controls.Add(this.EmployeeSubDepartmentBox);
            this.panel2.Controls.Add(this.SaveButton);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.EmployeeStaticTimeBox);
            this.panel2.Controls.Add(this.EmployeeCalculateType);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(534, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 183);
            this.panel2.TabIndex = 2;
            // 
            // EmployeeEnglishName
            // 
            this.EmployeeEnglishName.Location = new System.Drawing.Point(195, 47);
            this.EmployeeEnglishName.Name = "EmployeeEnglishName";
            this.EmployeeEnglishName.Size = new System.Drawing.Size(65, 13);
            this.EmployeeEnglishName.TabIndex = 20;
            this.EmployeeEnglishName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(140, 47);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 19;
            this.label23.Text = "英文名：";
            // 
            // EmployeeDepartment
            // 
            this.EmployeeDepartment.Location = new System.Drawing.Point(74, 89);
            this.EmployeeDepartment.Name = "EmployeeDepartment";
            this.EmployeeDepartment.Size = new System.Drawing.Size(183, 13);
            this.EmployeeDepartment.TabIndex = 18;
            this.EmployeeDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeWorkDate
            // 
            this.EmployeeWorkDate.Location = new System.Drawing.Point(69, 68);
            this.EmployeeWorkDate.Name = "EmployeeWorkDate";
            this.EmployeeWorkDate.Size = new System.Drawing.Size(188, 13);
            this.EmployeeWorkDate.TabIndex = 17;
            this.EmployeeWorkDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Location = new System.Drawing.Point(69, 47);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(65, 13);
            this.EmployeeName.TabIndex = 16;
            this.EmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeNumber
            // 
            this.EmployeeNumber.Location = new System.Drawing.Point(69, 24);
            this.EmployeeNumber.Name = "EmployeeNumber";
            this.EmployeeNumber.Size = new System.Drawing.Size(188, 13);
            this.EmployeeNumber.TabIndex = 15;
            this.EmployeeNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeSubDepartmentBox
            // 
            this.EmployeeSubDepartmentBox.Location = new System.Drawing.Point(71, 106);
            this.EmployeeSubDepartmentBox.Name = "EmployeeSubDepartmentBox";
            this.EmployeeSubDepartmentBox.Size = new System.Drawing.Size(189, 21);
            this.EmployeeSubDepartmentBox.TabIndex = 14;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(101, 155);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(85, 23);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "保存";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(125, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 13;
            this.label15.Text = "固定值：";
            // 
            // EmployeeStaticTimeBox
            // 
            this.EmployeeStaticTimeBox.Enabled = false;
            this.EmployeeStaticTimeBox.Location = new System.Drawing.Point(183, 130);
            this.EmployeeStaticTimeBox.Name = "EmployeeStaticTimeBox";
            this.EmployeeStaticTimeBox.Size = new System.Drawing.Size(77, 21);
            this.EmployeeStaticTimeBox.TabIndex = 12;
            // 
            // EmployeeCalculateType
            // 
            this.EmployeeCalculateType.AutoSize = true;
            this.EmployeeCalculateType.Checked = true;
            this.EmployeeCalculateType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EmployeeCalculateType.Location = new System.Drawing.Point(71, 133);
            this.EmployeeCalculateType.Name = "EmployeeCalculateType";
            this.EmployeeCalculateType.Size = new System.Drawing.Size(48, 16);
            this.EmployeeCalculateType.TabIndex = 11;
            this.EmployeeCalculateType.Text = "自动";
            this.EmployeeCalculateType.UseVisualStyleBackColor = true;
            this.EmployeeCalculateType.CheckedChanged += new System.EventHandler(this.EmployeeCalculateType_Changed);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 10;
            this.label14.Text = "年假计算：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 9;
            this.label13.Text = "子 部 门：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 8;
            this.label12.Text = "所属部门：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 7;
            this.label11.Text = "入职日期：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "姓    名：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "工    号：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(109, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "员工详情";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
            this.panel3.Controls.Add(this.AddEnglishName);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.AddWorkDate);
            this.panel3.Controls.Add(this.AddName);
            this.panel3.Controls.Add(this.AddJobNumber);
            this.panel3.Controls.Add(this.AddStaticValue);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.AddAutoCalculate);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.AddButton);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(534, 228);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 220);
            this.panel3.TabIndex = 3;
            // 
            // AddEnglishName
            // 
            this.AddEnglishName.Location = new System.Drawing.Point(71, 86);
            this.AddEnglishName.Name = "AddEnglishName";
            this.AddEnglishName.Size = new System.Drawing.Size(189, 21);
            this.AddEnglishName.TabIndex = 26;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 91);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 25;
            this.label21.Text = "英 文 名：";
            // 
            // AddWorkDate
            // 
            this.AddWorkDate.Location = new System.Drawing.Point(71, 115);
            this.AddWorkDate.Name = "AddWorkDate";
            this.AddWorkDate.Size = new System.Drawing.Size(189, 21);
            this.AddWorkDate.TabIndex = 14;
            // 
            // AddName
            // 
            this.AddName.Location = new System.Drawing.Point(71, 56);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(189, 21);
            this.AddName.TabIndex = 24;
            // 
            // AddJobNumber
            // 
            this.AddJobNumber.Location = new System.Drawing.Point(71, 25);
            this.AddJobNumber.Name = "AddJobNumber";
            this.AddJobNumber.Size = new System.Drawing.Size(189, 21);
            this.AddJobNumber.TabIndex = 19;
            // 
            // AddStaticValue
            // 
            this.AddStaticValue.Enabled = false;
            this.AddStaticValue.Location = new System.Drawing.Point(183, 144);
            this.AddStaticValue.Name = "AddStaticValue";
            this.AddStaticValue.Size = new System.Drawing.Size(77, 21);
            this.AddStaticValue.TabIndex = 19;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(128, 151);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 19;
            this.label20.Text = "固定值：";
            // 
            // AddAutoCalculate
            // 
            this.AddAutoCalculate.AutoSize = true;
            this.AddAutoCalculate.Checked = true;
            this.AddAutoCalculate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AddAutoCalculate.Location = new System.Drawing.Point(74, 149);
            this.AddAutoCalculate.Name = "AddAutoCalculate";
            this.AddAutoCalculate.Size = new System.Drawing.Size(48, 16);
            this.AddAutoCalculate.TabIndex = 23;
            this.AddAutoCalculate.Text = "自动";
            this.AddAutoCalculate.UseVisualStyleBackColor = true;
            this.AddAutoCalculate.CheckedChanged += new System.EventHandler(this.AddAutoCalculate_Changed);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 151);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 22;
            this.label19.Text = "年假计算：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 21;
            this.label18.Text = "入职时间：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 20;
            this.label17.Text = "姓    名：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 19;
            this.label16.Text = "工    号：";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(101, 184);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(85, 23);
            this.AddButton.TabIndex = 19;
            this.AddButton.Text = "添加";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(109, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "新增员工";
            // 
            // EmployeeManage
            // 
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeManage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }
        private void ReflushEmployeeList()
        {
            EmployeeSelectList.Items.Clear();
            if (!EmployeeData[DepartmentComboBox.SelectedItem.ToString()].IsOpen)
                if (!LoadFileFunction(DepartmentComboBox.SelectedItem.ToString()))
                    System.Windows.Forms.MessageBox.Show(DepartmentComboBox.SelectedItem.ToString()+"加载失败 数据重置", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            SelectCount.Text = "0";
            TotalCount.Text = EmployeeData[DepartmentComboBox.SelectedItem.ToString()].Empolyees.Count.ToString();
            int index = 0;
            foreach (KeyValuePair<string, EmployeePersonalInformation> i in EmployeeData[DepartmentComboBox.SelectedItem.ToString()].Empolyees)
            {
                System.Windows.Forms.ListViewItem item = EmployeeSelectList.Items.Add((++index).ToString());
                item.SubItems.Add(i.Key);
                item.SubItems.Add(i.Value.Name);
                item.SubItems.Add(i.Value.EnglishName);
            }
            if ("" == DepartmentComboBox.SelectedItem.ToString())
            {
                DeleteButton.Visible = false;
                NoneToDepartment.Visible = false;
                DepartmentToNone.Visible = false;
                NoneDepartmentList.Enabled = false;
            }
            else
            {
                DeleteButton.Visible = true;
                NoneToDepartment.Visible = true;
                DepartmentToNone.Visible = true;
                NoneDepartmentList.Enabled = true;
            }
        }
        private void ReflushNoneDepartmentEmployeeList()
        {
            NoneDepartmentList.Items.Clear();
            if (!EmployeeData[""].IsOpen)
                LoadFileFunction("");
            int index = 0;
            foreach (KeyValuePair<string, EmployeePersonalInformation> i in EmployeeData[""].Empolyees)
            {
                System.Windows.Forms.ListViewItem item = NoneDepartmentList.Items.Add((++index).ToString());
                item.SubItems.Add(i.Key);
                item.SubItems.Add(i.Value.Name);
                item.SubItems.Add(i.Value.EnglishName);
            }
            NoneDepartmentSelectCount.Text = "0/" + NoneDepartmentList.Items.Count;
        }
        private bool CheckAddEmployeeJobNumber(string jobnum)
        {
            foreach (KeyValuePair<string, AVMSDT.DepartmentOperationData> i in EmployeeData)
                if (i.Value.Empolyees.ContainsKey(jobnum))
                    return false;
            return true;
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DepartmentCBValue_Changed(object sender, EventArgs e)
        {
            ReflushEmployeeList();
        }
        private void DepartmentList_ItemCheckedChanged(object sender, EventArgs e)
        {
            if (0 == EmployeeSelectList.SelectedItems.Count)
            {
                EmployeeNumber.Text = "";
                EmployeeName.Text = "";
                EmployeeEnglishName.Text = "";
                EmployeeWorkDate.Text = "";
                EmployeeDepartment.Text = "";
                EmployeeSubDepartmentBox.Enabled = false;
                EmployeeSubDepartmentBox.Clear();
                EmployeeStaticTimeBox.Enabled = false;
                EmployeeStaticTimeBox.Text = "";
                SaveButton.Visible = false;
                EmployeeCalculateType.Checked = true;
            }
            else
            {
                string jnum = EmployeeSelectList.SelectedItems[0].SubItems[1].Text;
                EmployeePersonalInformation infor = EmployeeData[DepartmentComboBox.SelectedItem.ToString()].Empolyees[jnum];
                EmployeeNumber.Text = jnum;
                EmployeeName.Text = infor.Name;
                EmployeeEnglishName.Text = infor.EnglishName;
                EmployeeWorkDate.Text = AVMSBT.Method.GeneralMethods.StructuredToString(infor.EntryTime);
                EmployeeDepartment.Text = "" == DepartmentComboBox.SelectedItem.ToString() ? "未分配部门" : DepartmentComboBox.SelectedItem.ToString();
                if (EmployeeData[DepartmentComboBox.SelectedItem.ToString()].SubDepartment)
                {
                    EmployeeSubDepartmentBox.Enabled = true;
                    EmployeeSubDepartmentBox.Text = infor.SubDepartment;
                }
                else
                {
                    EmployeeSubDepartmentBox.Enabled = false;
                    EmployeeSubDepartmentBox.Clear();
                }
                EmployeeCalculateType.Checked = infor.AutoCalculate;
                if (!infor.AutoCalculate)
                {
                    EmployeeStaticTimeBox.Enabled = true;
                    EmployeeStaticTimeBox.Text = infor.ManualTime.ToString();
                }
                else
                {
                    EmployeeStaticTimeBox.Enabled = false;
                    EmployeeStaticTimeBox.Text = "";
                }
                SaveButton.Visible = true;
            }
        }
        private void DepartmentList_ItemChecked(object sender, System.Windows.Forms.ItemCheckedEventArgs e)
        {
            SelectCount.Text = EmployeeSelectList.CheckedItems.Count.ToString();
        }

        private void EmployeeCalculateType_Changed(object sender, EventArgs e)
        {
            if (EmployeeCalculateType.Checked)
                EmployeeStaticTimeBox.Enabled = false;
            else
                EmployeeStaticTimeBox.Enabled = true;
        }
        private void AddAutoCalculate_Changed(object sender, EventArgs e)
        {
            if (AddAutoCalculate.Checked)
                AddStaticValue.Enabled = false;
            else
                AddStaticValue.Enabled = true;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (0 == AddJobNumber.TextLength)
            {
                System.Windows.Forms.MessageBox.Show("请输入工号", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            if (0 == AddName.TextLength)
            {
                System.Windows.Forms.MessageBox.Show("请输入姓名", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }

            int result = 0;
            if (!AddAutoCalculate.Checked)
            {
                if (0 == AddStaticValue.TextLength)
                {
                    System.Windows.Forms.MessageBox.Show("年假计算非自动模式需填写固定值", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return;
                }
                else if (!int.TryParse(AddStaticValue.Text, out result))
                {
                    System.Windows.Forms.MessageBox.Show("年假固定值应为数字", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return;
                }
            }
            if (!CheckAddEmployeeJobNumber(AddJobNumber.Text))
            {
                System.Windows.Forms.MessageBox.Show("添加员工工号已存在", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            EmployeeData[""].Empolyees.Add(AddJobNumber.Text, new EmployeePersonalInformation
            {
                Name = AddName.Text,
                EnglishName = AddEnglishName.Text,
                EntryTime = AddWorkDate.Value,
                AutoCalculate = AddAutoCalculate.Checked,
                ManualTime = result
            });
            AddJobNumber.Clear();
            AddName.Clear();
            AddEnglishName.Clear();
            AddAutoCalculate.Checked = true;
            AddStaticValue.Clear();
            ReflushNoneDepartmentEmployeeList();
        }

        private void NoneDepartmentList_ItemChecked(object sender, System.Windows.Forms.ItemCheckedEventArgs e)
        {
            NoneDepartmentSelectCount.Text = NoneDepartmentList.CheckedItems.Count + "/" + NoneDepartmentList.Items.Count;
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView.CheckedListViewItemCollection checkedlist = NoneDepartmentList.CheckedItems;
            if (0 == checkedlist.Count)
            {
                System.Windows.Forms.MessageBox.Show("请选择需要删除的项", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < checkedlist.Count; ++i)
                EmployeeData[""].Empolyees.Remove(checkedlist[i].SubItems[1].Text);
            ReflushNoneDepartmentEmployeeList();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (EmployeeSubDepartmentBox.Enabled && 0 == EmployeeSubDepartmentBox.TextLength)
            {
                System.Windows.Forms.MessageBox.Show(EmployeeDepartment.Text + " 部门需要填写子部门", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            int result = 0;
            if (!EmployeeCalculateType.Checked)
            {
                if (0 == EmployeeStaticTimeBox.TextLength)
                {
                    System.Windows.Forms.MessageBox.Show("年假计算非自动模式需填写固定值", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return;
                }
                else if (!int.TryParse(EmployeeStaticTimeBox.Text, out result))
                {
                    System.Windows.Forms.MessageBox.Show("年假固定值应为数字", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return;
                }
            }
            string depart = "未分配部门" == EmployeeDepartment.Text ? "" : EmployeeDepartment.Text;
            EmployeeData[depart].Empolyees[EmployeeNumber.Text].SubDepartment = EmployeeSubDepartmentBox.Text;
            EmployeeData[depart].Empolyees[EmployeeNumber.Text].AutoCalculate = EmployeeCalculateType.Checked;
            EmployeeData[depart].Empolyees[EmployeeNumber.Text].ManualTime = result;
            System.Windows.Forms.MessageBox.Show("保存成功", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }

        private void DepartmentToNone_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView.CheckedListViewItemCollection checkedlist = EmployeeSelectList.CheckedItems;
            if (0 == checkedlist.Count)
            {
                System.Windows.Forms.MessageBox.Show("请选择需要移动的项", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            Queue<string> keys = new Queue<string>();
            Queue<EmployeePersonalInformation> values = new Queue<EmployeePersonalInformation>();
            Dictionary<string, EmployeePersonalInformation> employee = EmployeeData[DepartmentComboBox.SelectedItem.ToString()].Empolyees;
            for (int i = 0; i < checkedlist.Count; ++i) 
            {
                string id = checkedlist[i].SubItems[1].Text;
                keys.Enqueue(id);
                values.Enqueue(employee[id]);
                employee.Remove(id);
            }
            employee = EmployeeData[""].Empolyees;
            while (0 < keys.Count)
                employee.Add(keys.Dequeue(), values.Dequeue());
            ReflushEmployeeList();
            ReflushNoneDepartmentEmployeeList();
        }
        private void NoneToDepartment_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView.CheckedListViewItemCollection checkedlist = NoneDepartmentList.CheckedItems;
            if (0 == checkedlist.Count)
            {
                System.Windows.Forms.MessageBox.Show("请选择需要移动的项", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            Queue<string> keys = new Queue<string>();
            Queue<EmployeePersonalInformation> values = new Queue<EmployeePersonalInformation>();
            Dictionary<string, EmployeePersonalInformation> employee = EmployeeData[""].Empolyees;
            for (int i = 0; i < checkedlist.Count; ++i)
            {
                string id = checkedlist[i].SubItems[1].Text;
                keys.Enqueue(id);
                values.Enqueue(employee[id]);
                employee.Remove(id);
            }
            employee = EmployeeData[DepartmentComboBox.SelectedItem.ToString()].Empolyees;
            while (0 < keys.Count)
                employee.Add(keys.Dequeue(), values.Dequeue());
            ReflushEmployeeList();
            ReflushNoneDepartmentEmployeeList();
        }
    }
}
