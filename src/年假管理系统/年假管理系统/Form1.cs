using AVMSDT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 年假管理系统
{
    public partial class AVMSystem : Form
    {
        private Point mousePoint;
        private bool AVMSystemMouseDownFlag;

        public AVMSystem()
        {
            InitializeComponent();
            PleaseLoginLabel.Visible = false;
            MainPanel.Visible = false;
            UserStateLabel.Visible = false;
            保存ToolStripMenuItem.Visible = false;
            导入ToolStripMenuItem.Visible = false;
            导出ToolStripMenuItem.Visible = false;
            关闭ToolStripMenuItem.Visible = false;
            CleanEmployeeInform();
        }

        private void FileInitOperation()
        {
            UserStateLabel.Visible = true;
            PleaseLoginLabel.Visible = true;
            关闭ToolStripMenuItem.Visible = true;
        }

        private void ReflushDepartmentComboBox()
        {
            DepartmentSelectBox.Items.Clear();
            if (UserLevel.DEPARTMENT == OperationData.ActiveLevel)
                DepartmentSelectBox.Items.AddRange(new string[]{
                    "",
                    OperationData.UserDepartment
                });
            else
                DepartmentSelectBox.Items.AddRange(OperationData.EmpolyeeData.Keys.ToArray());
            DepartmentSelectBox.SelectedIndex = 0;
            OperationData.SelectedDepartment = DepartmentSelectBox.SelectedItem.ToString();
        }
        private void ReflushEmployeeList()
        {
            EmployeeList.Clear();

            DepartmentOperationData department = OperationData.EmpolyeeData[DepartmentSelectBox.SelectedItem.ToString()];
            if (!department.IsOpen)
                Utils.Files.LoadFile(DepartmentSelectBox.SelectedItem.ToString());
            // 生成列表列
            EmployeeList.Columns.Add("序号", 60, HorizontalAlignment.Center);
            EmployeeList.Columns.Add("工号", 70, HorizontalAlignment.Center);
            EmployeeList.Columns.Add("姓名", 100, HorizontalAlignment.Center);
            EmployeeList.Columns.Add("英文名", 100, HorizontalAlignment.Center);
            EmployeeList.Columns.Add("入职时间", 100, HorizontalAlignment.Center);
            if (department.SubDepartment)
                EmployeeList.Columns.Add("子部门", 100, HorizontalAlignment.Center);
            EmployeeList.Columns.Add("年假模式", 60, HorizontalAlignment.Center);
            // 载入数据
            int index = 0;
            foreach (KeyValuePair<string, EmployeePersonalInformation> i in department.Empolyees)
            {
                ListViewItem item = EmployeeList.Items.Add((++index).ToString());
                item.SubItems.Add(i.Key);
                item.SubItems.Add(i.Value.Name);
                item.SubItems.Add(i.Value.EnglishName);
                item.SubItems.Add(AVMSBT.Method.GeneralMethods.StructuredToString(i.Value.EntryTime));
                if (department.SubDepartment)
                    item.SubItems.Add(i.Value.SubDepartment);
                item.SubItems.Add(i.Value.AutoCalculate ? "自动" : "固定");
            }
        }
        private void CleanEmployeeInform()
        {
            JobNumber.Text = "";
            EmployeeName.Text = "";
            EmployeeEnglish.Text = "";
            EmployeeEntryTime.Text = "";
            EmployeeDepartment.Text = "";
            EmployeeSubDepartment.Text = "";
            VacationPreAdd.Text = "";
            VacationPreApplied.Clear();
            VacationCurrentAdd.Text = "";
            MonthSelectedBox.SelectedIndex = 0;
            VacationMonthCount.Text = "";
            VacationCurrentTotal.Text = "";
            VacationCurrentValid.Text = "";
            VacationCurrentSurplus.Text = "";
            VacationCurrentApplied.Clear();
            SaveButton.Visible = false;
            OperationData.SelectedEmployeeInfo = null;
            OperationData.SelectedEmployeeNumber = "";
            OperationData.SelectedEmployeeMonthVac = new double[]{ 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
            OperationData.SelectedEmployeePreVac = 0.0;
            OperationData.SelectedEmployeeCurrentVac = 0.0;
        }

        private void Open_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog
            {
                Description = "请选择打开的文件夹"
            };
            if (DialogResult.OK == dialog.ShowDialog(this))
            {
                if (!string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    Utils.Files.OpenFiles(dialog.SelectedPath);
                    return;
                }
            }
        }
        private void Create_Click(object sender, EventArgs e)
        {
            CreateNewFile create = new CreateNewFile();
            if (System.Windows.Forms.DialogResult.Yes == new AVMSDialog.ExtenedView.CreateNewView(create).ShowDialog(this)) 
            {
                OperationData.Init();
                OperationData.EmpolyeeData.Add("", new DepartmentOperationData
                {
                    FileID = Guid.NewGuid().ToString(),
                    IsOpen = true,
                    SubDepartment = false,
                    Empolyees = new Dictionary<string, EmployeePersonalInformation>()
                });
                OperationData.DirectoryName = create.FileName;
                OperationData.LoginData = create.UsersLoginInfor;
                UserStateLabel.Visible = true;
                PleaseLoginLabel.Visible = true;
                关闭ToolStripMenuItem.Visible = true;
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if ("" == OperationData.FileDictionary)
            {
                // 此处需要选择保存位置
                FolderBrowserDialog dialog = new FolderBrowserDialog
                {
                    Description = "请选择打开的文件夹"
                };
                while (true)
                {
                    if (DialogResult.OK == dialog.ShowDialog())
                    {
                        if (string.IsNullOrEmpty(dialog.SelectedPath))
                            MessageBox.Show("请选择一个保存路径", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            if (!System.IO.Directory.Exists(dialog.SelectedPath + "\\" + OperationData.DirectoryName))
                                System.IO.Directory.CreateDirectory(dialog.SelectedPath + "\\" + OperationData.DirectoryName);
                            OperationData.FileDictionary = dialog.SelectedPath + "\\" + OperationData.DirectoryName;
                            break;
                        }
                    }
                    return;
                }
            }
            Utils.Files.SaveFiles();
        }
        private void Import_Click(object sender, EventArgs e)
        {
            if (null == Type.GetTypeFromProgID("Excel.Application"))
            {
                MessageBox.Show("当前设备未安装Office Excel组件 无法导入", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "选择导入的文件";
            dialog.Filter = "Excel工作簿 (*.xlsx) | *.xlsx | Excel 97-2003 工作簿 (*.xls) | *.xls";
            if (DialogResult.OK == dialog.ShowDialog(this))
            {
                Utils.Import import = new Utils.Import(dialog.FileName);
                if (import.ImportData())
                    MessageBox.Show("导入成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("导入失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                import.Close();
                ReflushDepartmentComboBox();
                ReflushEmployeeList();
                CleanEmployeeInform();
            }
        }
        private void Export_Click(object sender, EventArgs e)
        {
            if (null == Type.GetTypeFromProgID("Excel.Application"))
            {
                MessageBox.Show("当前设备未安装Office Excel组件 无法导出", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "导出文件到";
            dialog.Filter = "Excel工作簿 (*.xlsx) | *.xlsx | Excel 97-2003 工作簿 (*.xls) | *.xls";
            if (DialogResult.OK == dialog.ShowDialog(this))
            {
                Utils.Export export = new Utils.Export();
                if (export.ExportData())
                {
                    MessageBox.Show("导出成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    export.Save(dialog.FileName);
                }
                else
                    MessageBox.Show("导出失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                export.Close();
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show
                    (
                    null,
                    "是否关闭当前文件？ （请确定文件数据已经保存）",
                    "提示",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ))
            {
                return;
            }
            OperationData.Init();
            PleaseLoginLabel.Visible = false;
            MainPanel.Visible = false;
            UserStateLabel.Visible = false;
            保存ToolStripMenuItem.Visible = false;
            导入ToolStripMenuItem.Visible = false;
            导出ToolStripMenuItem.Visible = false;
            关闭ToolStripMenuItem.Visible = false;
            关闭ToolStripMenuItem.Visible = false;
        }

        private void AVMSystem_Load(object sender, EventArgs e)
        {
            OperationData.Init();
            OperationData.FileInitOperation = FileInitOperation;
        }
        private void AVMSystem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Y < 32)
            {
                if (e.Button == MouseButtons.Left)
                {
                    mousePoint = new Point(e.X, e.Y);
                    AVMSystemMouseDownFlag = true;
                }
                else if (MouseButtons.Right == e.Button)
                {
                    FormContextMenu.Show(this, e.Location);
                }
            }
        }
        private void AVMSystem_MouseMove(object sender, MouseEventArgs e)
        {
            if (AVMSystemMouseDownFlag)
            {
                Point temp = e.Location;
                int x = Location.X + temp.X - mousePoint.X;
                int y = Location.Y + temp.Y - mousePoint.Y;
                Location = new Point(x, y);
            }
        }
        private void AVMSystem_MouseUp(object sender, MouseEventArgs e)
        {
            if (AVMSystemMouseDownFlag)
                AVMSystemMouseDownFlag = false;
        }

        private void MinimumButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show
                    (
                    null,
                    "正在关闭程序 请确定文件数据已经保存",
                    "提示",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ))
            {
                return;
            }
            Close();
        }

        private void UserStateLabel_Click(object sender, EventArgs e)
        {
            if (UserLevel.NO_ACCESS == OperationData.ActiveLevel
                && string.IsNullOrEmpty(OperationData.ActiveUser))
            {
                UserLoginData logindata = new UserLoginData();
                if (DialogResult.Yes == new AVMSDialog.UserLogin(logindata).ShowDialog(this))
                {
                    switch (Login(logindata))
                    {
                        case UserLoginState.Successful:
                            break;
                        case UserLoginState.Wrong_PW:
                            MessageBox.Show("登录密码错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case UserLoginState.None_User:
                            MessageBox.Show("登录用户名不存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
            }
            else if (UserLevel.DEPARTMENT == OperationData.ActiveLevel)
                new AVMSDialog.LoginDepartment(OperationData.ActiveUser, OperationData.UserDepartment, Logout, AddUser, ChangeUserPW).ShowDialog(this);
            else if (UserLevel.READ_ONLY == OperationData.ActiveLevel)
                new AVMSDialog.LoginUser(OperationData.ActiveUser, Logout, ChangeUserPW).ShowDialog(this);
            else
            {
                List<string> slist = new List<string>();
                foreach (string i in OperationData.EmpolyeeData.Keys)
                    if ("" != i)
                        slist.Add(i);
                new AVMSDialog.LoginAdmin(OperationData.ActiveUser, slist.ToArray(), OperationData.LoginData, Logout).ShowDialog(this);
            }
        }

        private AVMSDialogStatic.AddResult AddUser(string username, string userpw, AVMSDialogStatic.UserAddLevel level)
        {
            if (!OperationData.LoginData.ContainsKey(username))
            {
                if (AVMSDialogStatic.UserAddLevel.Department == level)
                {
                    OperationData.LoginData.Add(username, new UserLoginInformation
                    {
                        Department = OperationData.UserDepartment,
                        Level = UserLevel.DEPARTMENT,
                        UserPW = userpw
                    });
                }
                else
                {
                    OperationData.LoginData.Add(username, new UserLoginInformation
                    {
                        Department = "",
                        Level = UserLevel.READ_ONLY,
                        UserPW = userpw
                    });
                }
                return AVMSDialogStatic.AddResult.Successful;
            }
            return AVMSDialogStatic.AddResult.Repetition;
        }
        private void ChangeUserPW(string password)
        {
            OperationData.LoginData[OperationData.ActiveUser].UserPW = password;
        }
        private void Logout()
        {
            //if (UserLevel.ADMIN == OperationData.ActiveLevel || UserLevel.DEPARTMENT == OperationData.ActiveLevel)
            //    Save_Click(null, null);
            OperationData.ActiveUser = "";
            OperationData.ActiveLevel = UserLevel.NO_ACCESS;
            OperationData.UserDepartment = "";
            UserStateLabel.Text = "未登录";
            SwitchLevelLabel();
        }
        private UserLoginState Login(UserLoginData logindata)
        {
            if(OperationData.LoginData.TryGetValue(logindata.UserName,out UserLoginInformation information))
            {
                if (logindata.UserPW == information.UserPW)
                {
                    OperationData.ActiveUser = logindata.UserName;
                    OperationData.ActiveLevel = information.Level;
                    OperationData.UserDepartment = information.Department;
                    UserStateLabel.Text = logindata.UserName;
                    SwitchLevelLabel();
                    return UserLoginState.Successful;
                }
                return UserLoginState.Wrong_PW;
            }
            return UserLoginState.None_User;
        }
        private void SwitchLevelLabel()
        {
            switch (OperationData.ActiveLevel)
            {
                case UserLevel.ADMIN:
                    UserStateLabel.BackColor = Color.Black;
                    UserStateLabel.ForeColor = Color.White;
                    PleaseLoginLabel.Visible = false;
                    MainPanel.Visible = true;
                    保存ToolStripMenuItem.Visible = true;
                    导入ToolStripMenuItem.Visible = true;
                    导出ToolStripMenuItem.Visible = true;

                    DepartmentManageButton.Visible = true;
                    EmployeeManageButton.Visible = true;
                    ReflushDepartmentComboBox();
                    ReflushEmployeeList();
                    break;
                case UserLevel.DEPARTMENT:
                    UserStateLabel.BackColor = Color.Red;
                    UserStateLabel.ForeColor = Color.White;
                    PleaseLoginLabel.Visible = false;
                    MainPanel.Visible = true;
                    保存ToolStripMenuItem.Visible = true;
                    导入ToolStripMenuItem.Visible = false;
                    导出ToolStripMenuItem.Visible = true;

                    DepartmentManageButton.Visible = false;
                    EmployeeManageButton.Visible = false;
                    ReflushDepartmentComboBox();
                    ReflushEmployeeList();
                    break;
                case UserLevel.READ_ONLY:
                    UserStateLabel.BackColor = Color.Green;
                    UserStateLabel.ForeColor = Color.White;
                    PleaseLoginLabel.Visible = false;
                    MainPanel.Visible = true;
                    保存ToolStripMenuItem.Visible = false;
                    导入ToolStripMenuItem.Visible = false;
                    导出ToolStripMenuItem.Visible = false;

                    DepartmentManageButton.Visible = false;
                    EmployeeManageButton.Visible = false;
                    ReflushDepartmentComboBox();
                    ReflushEmployeeList();
                    break;
                default:
                    UserStateLabel.BackColor = Color.White;
                    UserStateLabel.ForeColor = Color.Black;
                    PleaseLoginLabel.Visible = true;
                    MainPanel.Visible = false;
                    保存ToolStripMenuItem.Visible = false;
                    导入ToolStripMenuItem.Visible = false;
                    导出ToolStripMenuItem.Visible = false;
                    break;
            }
        }

        private void DepartmentManageButton_Click(object sender, EventArgs e)
        {
            new AVMSDialog.MainSubView.DepartmentManage(OperationData.EmpolyeeData, OperationData.LoginData).ShowDialog(this);
            ReflushDepartmentComboBox();
            ReflushEmployeeList();
        }
        private void EmployeeManageButton_Click(object sender, EventArgs e)
        {
            new AVMSDialog.MainSubView.EmployeeManage(OperationData.EmpolyeeData, Utils.Files.LoadFile).ShowDialog(this);
        }

        private void DepartmentSelected_Changed(object sender, EventArgs e)
        {
            ReflushEmployeeList();
        }
        private void EmployeeList_ItemCheckedChanged(object sender, EventArgs e)
        {
            if (0 == EmployeeList.SelectedItems.Count)
                CleanEmployeeInform();
            else
            {
                OperationData.SelectedEmployeeNumber = EmployeeList.SelectedItems[0].SubItems[1].Text;
                OperationData.SelectedEmployeeInfo = OperationData.EmpolyeeData[DepartmentSelectBox.SelectedItem.ToString()].Empolyees[OperationData.SelectedEmployeeNumber];
                JobNumber.Text = OperationData.SelectedEmployeeNumber;
                EmployeeName.Text = OperationData.SelectedEmployeeInfo.Name;
                EmployeeEnglish.Text = OperationData.SelectedEmployeeInfo.EnglishName;
                EmployeeEntryTime.Text = AVMSBT.Method.GeneralMethods.StructuredToString(OperationData.SelectedEmployeeInfo.EntryTime);
                EmployeeDepartment.Text = DepartmentSelectBox.SelectedItem.ToString();
                EmployeeSubDepartment.Text = OperationData.SelectedEmployeeInfo.SubDepartment;

                if (OperationData.SelectedEmployeeInfo.AutoCalculate)
                {
                    OperationData.SelectedEmployeePreVac = AVMSBT.Method.AnnualVacation.AutoCalculatePassed(OperationData.SelectedEmployeeInfo.EntryTime);
                    OperationData.SelectedEmployeeCurrentVac = AVMSBT.Method.AnnualVacation.AutoCalculateCurrent(OperationData.SelectedEmployeeInfo.EntryTime, OperationData.SelectedEmployeeMonthVac);
                }
                else
                {
                    OperationData.SelectedEmployeePreVac = AVMSBT.Method.AnnualVacation.StaticCalculatePassed(OperationData.SelectedEmployeeInfo.EntryTime, OperationData.SelectedEmployeeInfo.ManualTime);
                    OperationData.SelectedEmployeeCurrentVac = AVMSBT.Method.AnnualVacation.StaticCalculateCurrent(OperationData.SelectedEmployeeInfo.EntryTime, OperationData.SelectedEmployeeInfo.ManualTime, OperationData.SelectedEmployeeMonthVac);
                }
                
                VacationPreAdd.Text = AVMSBT.Method.GeneralMethods.StructuredToString(OperationData.SelectedEmployeePreVac);
                VacationCurrentAdd.Text = AVMSBT.Method.GeneralMethods.StructuredToString(OperationData.SelectedEmployeeCurrentVac);
                MonthSelectedBox.SelectedIndex = 0;
                VacationMonthCount.Text = AVMSBT.Method.GeneralMethods.StructuredToString(OperationData.SelectedEmployeeMonthVac[MonthSelectedBox.SelectedIndex]);
                double delay = OperationData.SelectedEmployeePreVac - OperationData.SelectedEmployeeInfo.LastApplied;
                VacationCurrentTotal.Text = AVMSBT.Method.GeneralMethods.StructuredToString(OperationData.SelectedEmployeeCurrentVac + delay);
                double vaild = 0.0;
                for (int i = 0; i < DateTime.Today.Month; ++i)
                    vaild += OperationData.SelectedEmployeeMonthVac[i];
                VacationCurrentValid.Text = AVMSBT.Method.GeneralMethods.StructuredToString(vaild + delay);
                VacationCurrentSurplus.Text = AVMSBT.Method.GeneralMethods.StructuredToString(vaild + delay - OperationData.SelectedEmployeeInfo.Applied);

                VacationPreApplied.Text = OperationData.SelectedEmployeeInfo.LastApplied.ToString();
                VacationCurrentApplied.Text = OperationData.SelectedEmployeeInfo.Applied.ToString();
                if (UserLevel.READ_ONLY == OperationData.ActiveLevel)
                {
                    VacationPreApplied.Enabled = false;
                    VacationCurrentApplied.Enabled = false;
                    SaveButton.Visible = false;
                }
                else
                {
                    VacationPreApplied.Enabled = true;
                    VacationCurrentApplied.Enabled = true;
                    SaveButton.Visible = true;
                }
            }
        }

        private void MonthBox_Change(object sender, EventArgs e)
        {
            if (null != OperationData.SelectedEmployeeInfo)
                VacationMonthCount.Text = AVMSBT.Method.GeneralMethods.StructuredToString(OperationData.SelectedEmployeeMonthVac[MonthSelectedBox.SelectedIndex]);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int pre_apply = 0, curr_apply = 0;
            if (int.TryParse(VacationPreApplied.Text, out pre_apply) 
                && int.TryParse(VacationCurrentApplied.Text, out curr_apply)) 
            {
                OperationData.SelectedEmployeeInfo.LastApplied = pre_apply;
                OperationData.SelectedEmployeeInfo.Applied = curr_apply;
                double delay = OperationData.SelectedEmployeePreVac - pre_apply;
                VacationCurrentTotal.Text = AVMSBT.Method.GeneralMethods.StructuredToString(OperationData.SelectedEmployeeCurrentVac + delay);
                double vaild = 0.0;
                for (int i = 0; i < DateTime.Today.Month; ++i)
                    vaild += OperationData.SelectedEmployeeMonthVac[i];
                VacationCurrentValid.Text = AVMSBT.Method.GeneralMethods.StructuredToString(vaild + delay);
                VacationCurrentSurplus.Text = AVMSBT.Method.GeneralMethods.StructuredToString(vaild + delay - curr_apply);
            }
            else
                MessageBox.Show("已休年假请输入数字", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
