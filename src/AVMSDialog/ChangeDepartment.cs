using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVMSDialog
{
    internal class ChangeDepartment : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CurrentDepatment;
        private System.Windows.Forms.ComboBox SelectDepartmentBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label YesButton;
        private new System.Windows.Forms.Label CancelButton;
        private System.Windows.Forms.Label label1;

        private AVMSDT.StringTransPackage UserDepartment;

        public ChangeDepartment(AVMSDT.StringTransPackage change, string[] departmentlist) : base()
        {
            InitializeComponent();
            UserDepartment = change;
            CurrentDepatment.Text = change.StringPackage;
            SelectDepartmentBox.Items.Add("");
            SelectDepartmentBox.Items.AddRange(departmentlist);
            SelectDepartmentBox.SelectedIndex = 0;
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Label();
            this.YesButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentDepatment = new System.Windows.Forms.Label();
            this.SelectDepartmentBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.YesButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CurrentDepatment);
            this.panel1.Controls.Add(this.SelectDepartmentBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 128);
            this.panel1.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(158, 82);
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
            this.YesButton.Location = new System.Drawing.Point(62, 82);
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
            this.label2.Location = new System.Drawing.Point(29, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "新的部门：";
            // 
            // CurrentDepatment
            // 
            this.CurrentDepatment.ForeColor = System.Drawing.Color.White;
            this.CurrentDepatment.Location = new System.Drawing.Point(100, 17);
            this.CurrentDepatment.Name = "CurrentDepatment";
            this.CurrentDepatment.Size = new System.Drawing.Size(175, 12);
            this.CurrentDepatment.TabIndex = 2;
            this.CurrentDepatment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectDepartmentBox
            // 
            this.SelectDepartmentBox.FormattingEnabled = true;
            this.SelectDepartmentBox.Location = new System.Drawing.Point(100, 42);
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
            this.label1.Text = "当前部门：";
            // 
            // ChangeDepartment
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(325, 134);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeDepartment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            if (0 == SelectDepartmentBox.SelectedIndex)
            {
                DialogResult = System.Windows.Forms.DialogResult.Yes;
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
