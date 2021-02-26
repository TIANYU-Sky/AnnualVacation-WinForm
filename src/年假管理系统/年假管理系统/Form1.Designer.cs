namespace 年假管理系统
{
    partial class AVMSystem
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AVMSystem));
            this.UserStateLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.MinimumButton = new System.Windows.Forms.Label();
            this.FormContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmployeeDetailPanel = new System.Windows.Forms.Panel();
            this.EmployeeSubDepartment = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.VacationPreApplied = new System.Windows.Forms.TextBox();
            this.VacationCurrentSurplus = new System.Windows.Forms.Label();
            this.VacationCurrentTotal = new System.Windows.Forms.Label();
            this.VacationCurrentAdd = new System.Windows.Forms.Label();
            this.VacationPreAdd = new System.Windows.Forms.Label();
            this.EmployeeDepartment = new System.Windows.Forms.Label();
            this.EmployeeEntryTime = new System.Windows.Forms.Label();
            this.EmployeeEnglish = new System.Windows.Forms.Label();
            this.EmployeeName = new System.Windows.Forms.Label();
            this.JobNumber = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Label();
            this.VacationCurrentApplied = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.VacationCurrentValid = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.VacationMonthCount = new System.Windows.Forms.Label();
            this.MonthSelectedBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmployeeManageButton = new System.Windows.Forms.Label();
            this.DepartmentManageButton = new System.Windows.Forms.Label();
            this.DepartmentSelectBox = new System.Windows.Forms.ComboBox();
            this.EmployeeList = new System.Windows.Forms.ListView();
            this.PleaseLoginLabel = new System.Windows.Forms.Label();
            this.FormContextMenu.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.EmployeeDetailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserStateLabel
            // 
            this.UserStateLabel.BackColor = System.Drawing.Color.White;
            this.UserStateLabel.Location = new System.Drawing.Point(573, 4);
            this.UserStateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserStateLabel.Name = "UserStateLabel";
            this.UserStateLabel.Size = new System.Drawing.Size(170, 28);
            this.UserStateLabel.TabIndex = 5;
            this.UserStateLabel.Text = "未登录";
            this.UserStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UserStateLabel.Click += new System.EventHandler(this.UserStateLabel_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.SteelBlue;
            this.CloseButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(806, 4);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 28);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "×";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MinimumButton
            // 
            this.MinimumButton.BackColor = System.Drawing.Color.SteelBlue;
            this.MinimumButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MinimumButton.ForeColor = System.Drawing.Color.White;
            this.MinimumButton.Location = new System.Drawing.Point(762, 4);
            this.MinimumButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinimumButton.Name = "MinimumButton";
            this.MinimumButton.Size = new System.Drawing.Size(28, 28);
            this.MinimumButton.TabIndex = 10;
            this.MinimumButton.Text = "-";
            this.MinimumButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MinimumButton.Click += new System.EventHandler(this.MinimumButton_Click);
            // 
            // FormContextMenu
            // 
            this.FormContextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.FormContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.导出ToolStripMenuItem,
            this.导入ToolStripMenuItem,
            this.关闭ToolStripMenuItem});
            this.FormContextMenu.Name = "contextMenuStrip1";
            this.FormContextMenu.Size = new System.Drawing.Size(125, 136);
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.Create_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.Open_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.Save_Click);
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.导出ToolStripMenuItem.Text = "导出";
            this.导出ToolStripMenuItem.Click += new System.EventHandler(this.Export_Click);
            // 
            // 导入ToolStripMenuItem
            // 
            this.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem";
            this.导入ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.导入ToolStripMenuItem.Text = "导入";
            this.导入ToolStripMenuItem.Click += new System.EventHandler(this.Import_Click);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关闭ToolStripMenuItem.Text = "关闭文件";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(844, 2);
            this.label1.TabIndex = 16;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.EmployeeManageButton);
            this.MainPanel.Controls.Add(this.DepartmentManageButton);
            this.MainPanel.Controls.Add(this.DepartmentSelectBox);
            this.MainPanel.Controls.Add(this.EmployeeList);
            this.MainPanel.Location = new System.Drawing.Point(10, 43);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(822, 444);
            this.MainPanel.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.EmployeeDetailPanel);
            this.panel1.Location = new System.Drawing.Point(640, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 423);
            this.panel1.TabIndex = 21;
            // 
            // EmployeeDetailPanel
            // 
            this.EmployeeDetailPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.EmployeeDetailPanel.Controls.Add(this.EmployeeSubDepartment);
            this.EmployeeDetailPanel.Controls.Add(this.label13);
            this.EmployeeDetailPanel.Controls.Add(this.VacationPreApplied);
            this.EmployeeDetailPanel.Controls.Add(this.VacationCurrentSurplus);
            this.EmployeeDetailPanel.Controls.Add(this.VacationCurrentTotal);
            this.EmployeeDetailPanel.Controls.Add(this.VacationCurrentAdd);
            this.EmployeeDetailPanel.Controls.Add(this.VacationPreAdd);
            this.EmployeeDetailPanel.Controls.Add(this.EmployeeDepartment);
            this.EmployeeDetailPanel.Controls.Add(this.EmployeeEntryTime);
            this.EmployeeDetailPanel.Controls.Add(this.EmployeeEnglish);
            this.EmployeeDetailPanel.Controls.Add(this.EmployeeName);
            this.EmployeeDetailPanel.Controls.Add(this.JobNumber);
            this.EmployeeDetailPanel.Controls.Add(this.label18);
            this.EmployeeDetailPanel.Controls.Add(this.SaveButton);
            this.EmployeeDetailPanel.Controls.Add(this.VacationCurrentApplied);
            this.EmployeeDetailPanel.Controls.Add(this.label17);
            this.EmployeeDetailPanel.Controls.Add(this.label16);
            this.EmployeeDetailPanel.Controls.Add(this.label15);
            this.EmployeeDetailPanel.Controls.Add(this.label14);
            this.EmployeeDetailPanel.Controls.Add(this.VacationCurrentValid);
            this.EmployeeDetailPanel.Controls.Add(this.label12);
            this.EmployeeDetailPanel.Controls.Add(this.VacationMonthCount);
            this.EmployeeDetailPanel.Controls.Add(this.MonthSelectedBox);
            this.EmployeeDetailPanel.Controls.Add(this.label10);
            this.EmployeeDetailPanel.Controls.Add(this.label9);
            this.EmployeeDetailPanel.Controls.Add(this.label8);
            this.EmployeeDetailPanel.Controls.Add(this.label7);
            this.EmployeeDetailPanel.Controls.Add(this.label6);
            this.EmployeeDetailPanel.Controls.Add(this.label5);
            this.EmployeeDetailPanel.Controls.Add(this.label4);
            this.EmployeeDetailPanel.Controls.Add(this.label3);
            this.EmployeeDetailPanel.Controls.Add(this.label2);
            this.EmployeeDetailPanel.Location = new System.Drawing.Point(4, 4);
            this.EmployeeDetailPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmployeeDetailPanel.Name = "EmployeeDetailPanel";
            this.EmployeeDetailPanel.Size = new System.Drawing.Size(170, 414);
            this.EmployeeDetailPanel.TabIndex = 20;
            // 
            // EmployeeSubDepartment
            // 
            this.EmployeeSubDepartment.Location = new System.Drawing.Point(74, 131);
            this.EmployeeSubDepartment.Name = "EmployeeSubDepartment";
            this.EmployeeSubDepartment.Size = new System.Drawing.Size(93, 12);
            this.EmployeeSubDepartment.TabIndex = 32;
            this.EmployeeSubDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 31;
            this.label13.Text = "子 部 门：";
            // 
            // VacationPreApplied
            // 
            this.VacationPreApplied.Location = new System.Drawing.Point(100, 187);
            this.VacationPreApplied.Name = "VacationPreApplied";
            this.VacationPreApplied.Size = new System.Drawing.Size(67, 21);
            this.VacationPreApplied.TabIndex = 30;
            this.VacationPreApplied.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VacationCurrentSurplus
            // 
            this.VacationCurrentSurplus.Location = new System.Drawing.Point(110, 330);
            this.VacationCurrentSurplus.Name = "VacationCurrentSurplus";
            this.VacationCurrentSurplus.Size = new System.Drawing.Size(57, 12);
            this.VacationCurrentSurplus.TabIndex = 29;
            this.VacationCurrentSurplus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VacationCurrentTotal
            // 
            this.VacationCurrentTotal.Location = new System.Drawing.Point(98, 271);
            this.VacationCurrentTotal.Name = "VacationCurrentTotal";
            this.VacationCurrentTotal.Size = new System.Drawing.Size(69, 12);
            this.VacationCurrentTotal.TabIndex = 28;
            this.VacationCurrentTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VacationCurrentAdd
            // 
            this.VacationCurrentAdd.Location = new System.Drawing.Point(102, 216);
            this.VacationCurrentAdd.Name = "VacationCurrentAdd";
            this.VacationCurrentAdd.Size = new System.Drawing.Size(65, 12);
            this.VacationCurrentAdd.TabIndex = 27;
            this.VacationCurrentAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VacationPreAdd
            // 
            this.VacationPreAdd.Location = new System.Drawing.Point(100, 167);
            this.VacationPreAdd.Name = "VacationPreAdd";
            this.VacationPreAdd.Size = new System.Drawing.Size(67, 12);
            this.VacationPreAdd.TabIndex = 26;
            this.VacationPreAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeDepartment
            // 
            this.EmployeeDepartment.Location = new System.Drawing.Point(74, 109);
            this.EmployeeDepartment.Name = "EmployeeDepartment";
            this.EmployeeDepartment.Size = new System.Drawing.Size(93, 12);
            this.EmployeeDepartment.TabIndex = 25;
            this.EmployeeDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeEntryTime
            // 
            this.EmployeeEntryTime.Location = new System.Drawing.Point(74, 88);
            this.EmployeeEntryTime.Name = "EmployeeEntryTime";
            this.EmployeeEntryTime.Size = new System.Drawing.Size(93, 12);
            this.EmployeeEntryTime.TabIndex = 24;
            this.EmployeeEntryTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeEnglish
            // 
            this.EmployeeEnglish.Location = new System.Drawing.Point(74, 67);
            this.EmployeeEnglish.Name = "EmployeeEnglish";
            this.EmployeeEnglish.Size = new System.Drawing.Size(93, 12);
            this.EmployeeEnglish.TabIndex = 23;
            this.EmployeeEnglish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Location = new System.Drawing.Point(74, 47);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(93, 12);
            this.EmployeeName.TabIndex = 22;
            this.EmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JobNumber
            // 
            this.JobNumber.Location = new System.Drawing.Point(74, 27);
            this.JobNumber.Name = "JobNumber";
            this.JobNumber.Size = new System.Drawing.Size(93, 12);
            this.JobNumber.TabIndex = 21;
            this.JobNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 109);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 20;
            this.label18.Text = "所属部门：";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(17, 380);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(139, 28);
            this.SaveButton.TabIndex = 19;
            this.SaveButton.Text = "保存";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // VacationCurrentApplied
            // 
            this.VacationCurrentApplied.Location = new System.Drawing.Point(110, 350);
            this.VacationCurrentApplied.Name = "VacationCurrentApplied";
            this.VacationCurrentApplied.Size = new System.Drawing.Size(57, 21);
            this.VacationCurrentApplied.TabIndex = 17;
            this.VacationCurrentApplied.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 355);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 12);
            this.label17.TabIndex = 16;
            this.label17.Text = "当前已休年假数：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 330);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 12);
            this.label16.TabIndex = 15;
            this.label16.Text = "当前可休年假数：";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(1, 315);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(168, 2);
            this.label15.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 271);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 12);
            this.label14.TabIndex = 13;
            this.label14.Text = "今年年假总数：";
            // 
            // VacationCurrentValid
            // 
            this.VacationCurrentValid.Location = new System.Drawing.Point(100, 295);
            this.VacationCurrentValid.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.VacationCurrentValid.Name = "VacationCurrentValid";
            this.VacationCurrentValid.Size = new System.Drawing.Size(67, 12);
            this.VacationCurrentValid.TabIndex = 12;
            this.VacationCurrentValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 295);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "截至本月可休：";
            // 
            // VacationMonthCount
            // 
            this.VacationMonthCount.Location = new System.Drawing.Point(100, 245);
            this.VacationMonthCount.Name = "VacationMonthCount";
            this.VacationMonthCount.Size = new System.Drawing.Size(67, 12);
            this.VacationMonthCount.TabIndex = 10;
            this.VacationMonthCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonthSelectedBox
            // 
            this.MonthSelectedBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthSelectedBox.FormattingEnabled = true;
            this.MonthSelectedBox.Items.AddRange(new object[] {
            "1月",
            "2月",
            "3月",
            "4月",
            "5月",
            "6月",
            "7月",
            "8月",
            "9月",
            "10月",
            "11月",
            "12月"});
            this.MonthSelectedBox.Location = new System.Drawing.Point(5, 240);
            this.MonthSelectedBox.Name = "MonthSelectedBox";
            this.MonthSelectedBox.Size = new System.Drawing.Size(84, 20);
            this.MonthSelectedBox.TabIndex = 9;
            this.MonthSelectedBox.SelectedIndexChanged += new System.EventHandler(this.MonthBox_Change);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "今年新增年假：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "去年已休年假：";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 2);
            this.label8.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "去年新增年假：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "入职时间：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "英 文 名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "姓    名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "工    号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "员工年假信息";
            // 
            // EmployeeManageButton
            // 
            this.EmployeeManageButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EmployeeManageButton.ForeColor = System.Drawing.Color.White;
            this.EmployeeManageButton.Location = new System.Drawing.Point(573, 6);
            this.EmployeeManageButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmployeeManageButton.Name = "EmployeeManageButton";
            this.EmployeeManageButton.Size = new System.Drawing.Size(60, 20);
            this.EmployeeManageButton.TabIndex = 19;
            this.EmployeeManageButton.Text = "员工管理";
            this.EmployeeManageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EmployeeManageButton.Click += new System.EventHandler(this.EmployeeManageButton_Click);
            // 
            // DepartmentManageButton
            // 
            this.DepartmentManageButton.BackColor = System.Drawing.Color.SteelBlue;
            this.DepartmentManageButton.ForeColor = System.Drawing.Color.White;
            this.DepartmentManageButton.Location = new System.Drawing.Point(204, 6);
            this.DepartmentManageButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DepartmentManageButton.Name = "DepartmentManageButton";
            this.DepartmentManageButton.Size = new System.Drawing.Size(60, 20);
            this.DepartmentManageButton.TabIndex = 18;
            this.DepartmentManageButton.Text = "部门管理";
            this.DepartmentManageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DepartmentManageButton.Click += new System.EventHandler(this.DepartmentManageButton_Click);
            // 
            // DepartmentSelectBox
            // 
            this.DepartmentSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentSelectBox.FormattingEnabled = true;
            this.DepartmentSelectBox.Location = new System.Drawing.Point(11, 6);
            this.DepartmentSelectBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DepartmentSelectBox.Name = "DepartmentSelectBox";
            this.DepartmentSelectBox.Size = new System.Drawing.Size(177, 20);
            this.DepartmentSelectBox.TabIndex = 17;
            this.DepartmentSelectBox.SelectedIndexChanged += new System.EventHandler(this.DepartmentSelected_Changed);
            // 
            // EmployeeList
            // 
            this.EmployeeList.FullRowSelect = true;
            this.EmployeeList.HideSelection = false;
            this.EmployeeList.Location = new System.Drawing.Point(11, 37);
            this.EmployeeList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.Size = new System.Drawing.Size(624, 392);
            this.EmployeeList.TabIndex = 16;
            this.EmployeeList.UseCompatibleStateImageBehavior = false;
            this.EmployeeList.View = System.Windows.Forms.View.Details;
            this.EmployeeList.SelectedIndexChanged += new System.EventHandler(this.EmployeeList_ItemCheckedChanged);
            // 
            // PleaseLoginLabel
            // 
            this.PleaseLoginLabel.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PleaseLoginLabel.ForeColor = System.Drawing.Color.White;
            this.PleaseLoginLabel.Location = new System.Drawing.Point(249, 195);
            this.PleaseLoginLabel.Name = "PleaseLoginLabel";
            this.PleaseLoginLabel.Size = new System.Drawing.Size(357, 58);
            this.PleaseLoginLabel.TabIndex = 18;
            this.PleaseLoginLabel.Text = "请登录";
            this.PleaseLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AVMSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(844, 495);
            this.Controls.Add(this.PleaseLoginLabel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinimumButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.UserStateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "AVMSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "年假管理系统";
            this.Load += new System.EventHandler(this.AVMSystem_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AVMSystem_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AVMSystem_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AVMSystem_MouseUp);
            this.FormContextMenu.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.EmployeeDetailPanel.ResumeLayout(false);
            this.EmployeeDetailPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label UserStateLabel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label MinimumButton;
        private System.Windows.Forms.ContextMenuStrip FormContextMenu;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel EmployeeDetailPanel;
        private System.Windows.Forms.Label EmployeeManageButton;
        private System.Windows.Forms.Label DepartmentManageButton;
        private System.Windows.Forms.ComboBox DepartmentSelectBox;
        private System.Windows.Forms.ListView EmployeeList;
        private System.Windows.Forms.Label PleaseLoginLabel;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label VacationMonthCount;
        private System.Windows.Forms.ComboBox MonthSelectedBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label VacationCurrentValid;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label SaveButton;
        private System.Windows.Forms.TextBox VacationCurrentApplied;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label EmployeeDepartment;
        private System.Windows.Forms.Label EmployeeEntryTime;
        private System.Windows.Forms.Label EmployeeEnglish;
        private System.Windows.Forms.Label EmployeeName;
        private System.Windows.Forms.Label JobNumber;
        private System.Windows.Forms.Label VacationCurrentAdd;
        private System.Windows.Forms.Label VacationPreAdd;
        private System.Windows.Forms.Label VacationCurrentTotal;
        private System.Windows.Forms.Label VacationCurrentSurplus;
        private System.Windows.Forms.TextBox VacationPreApplied;
        private System.Windows.Forms.Label EmployeeSubDepartment;
        private System.Windows.Forms.Label label13;
    }
}

