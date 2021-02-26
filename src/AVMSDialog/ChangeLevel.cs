using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVMSDialog
{
    internal class ChangeLevel : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CurrentLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label YesButton;
        private new System.Windows.Forms.Label CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectLevelBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SelectDepartmentBox;

        private AVMSDT.StringTransPackage UserDepartment;
        private AVMSDT.ObjectTransPackage UserLevel;

        public ChangeLevel(AVMSDT.ObjectTransPackage changelevel, AVMSDT.StringTransPackage changedepartment, string[] departments) : base()
        {
            InitializeComponent();
            UserDepartment = changedepartment;
            UserLevel = changelevel;
            CurrentLevel.Text = (string)changelevel.TransPackage;
            SelectLevelBox.Items.AddRange(new string[]
            {
            AVMSDT.StaticData.UserLevelStrings.UserLevelDepartment,
            AVMSDT.StaticData.UserLevelStrings.UserLevelReadOnly
            });
            SelectLevelBox.SelectedIndex = 0;
            SelectDepartmentBox.Items.Add("");
            SelectDepartmentBox.Items.AddRange(departments);
            SelectDepartmentBox.SelectedIndex = 0;
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SelectLevelBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Label();
            this.YesButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentLevel = new System.Windows.Forms.Label();
            this.SelectDepartmentBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.SelectLevelBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.YesButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CurrentLevel);
            this.panel1.Controls.Add(this.SelectDepartmentBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 161);
            this.panel1.TabIndex = 0;
            // 
            // SelectLevelBox
            // 
            this.SelectLevelBox.FormattingEnabled = true;
            this.SelectLevelBox.Location = new System.Drawing.Point(100, 41);
            this.SelectLevelBox.Name = "SelectLevelBox";
            this.SelectLevelBox.Size = new System.Drawing.Size(175, 20);
            this.SelectLevelBox.TabIndex = 7;
            this.SelectLevelBox.SelectedIndexChanged += new System.EventHandler(this.LevelBox_Change);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "新的权限：";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(158, 112);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 31);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "取消";
            this.CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // YesButton
            // 
            this.YesButton.BackColor = System.Drawing.Color.White;
            this.YesButton.ForeColor = System.Drawing.Color.Black;
            this.YesButton.Location = new System.Drawing.Point(62, 112);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(90, 31);
            this.YesButton.TabIndex = 4;
            this.YesButton.Text = "确定";
            this.YesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "部    门：";
            // 
            // CurrentLevel
            // 
            this.CurrentLevel.ForeColor = System.Drawing.Color.White;
            this.CurrentLevel.Location = new System.Drawing.Point(100, 17);
            this.CurrentLevel.Name = "CurrentLevel";
            this.CurrentLevel.Size = new System.Drawing.Size(175, 12);
            this.CurrentLevel.TabIndex = 2;
            this.CurrentLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectDepartmentBox
            // 
            this.SelectDepartmentBox.FormattingEnabled = true;
            this.SelectDepartmentBox.Location = new System.Drawing.Point(100, 72);
            this.SelectDepartmentBox.Name = "SelectDepartmentBox";
            this.SelectDepartmentBox.Size = new System.Drawing.Size(175, 20);
            this.SelectDepartmentBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前权限：";
            // 
            // ChangeLevel
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(325, 167);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeLevel";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void LevelBox_Change(object sender, EventArgs e)
        {
            if (0 != SelectLevelBox.SelectedIndex)
            {
                SelectDepartmentBox.SelectedIndex = 0;
                SelectDepartmentBox.Enabled = false;
            }
            else
                SelectDepartmentBox.Enabled = true;
        }
        private void YesButton_Click(object sender, EventArgs e)
        {
            if (0 == SelectDepartmentBox.SelectedIndex)
            {
                DialogResult = System.Windows.Forms.DialogResult.Yes;
                UserLevel.TransPackage = 0 == SelectLevelBox.SelectedIndex ? AVMSDT.UserLevel.DEPARTMENT : AVMSDT.UserLevel.READ_ONLY;
                UserDepartment.StringPackage = (string)SelectDepartmentBox.SelectedValue;
                this.Close();
            }
            else
                System.Windows.Forms.MessageBox.Show("请选择一个部门", "错误", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
