using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVMSDialog.Panels
{
    public class MainViewDataPanel : System.Windows.Forms.Panel
    {
        private System.Windows.Forms.Label label1;

        public MainViewDataPanel(string employee, AVMSDT.EmployeePersonalInformation information) : base()
        {

        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "工号：";
            // 
            // MainViewDataPanel
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(166, 414);
            this.ResumeLayout(false);

        }
    }
}
