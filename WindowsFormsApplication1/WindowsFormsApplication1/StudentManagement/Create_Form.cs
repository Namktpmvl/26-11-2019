using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.StudentManagement
{
    public partial class Create_Form : Form
    {
        private LogicLayer Business;
        public Create_Form()
        {
            InitializeComponent();
            this.Business = new LogicLayer();
            this.Load += Create_Form_Load;
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;

        }

        void btnCancel_Click(object sender, EventArgs e)
        {
               this.Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var code = this.txtCode.Text;
            var name = this.txtName.Text;
            var class_id = (int)this.comboClass.SelectedValue;

            this.Business.CreateStudent(code, name, class_id);
            MessageBox.Show("Create student successfully ");
            this.Close();
        }

        void Create_Form_Load(object sender, EventArgs e)
        {
            this.comboClass.DataSource = this.Business.GetClasses();
            this.comboClass.DisplayMember = "Name";
            this.comboClass.ValueMember = "Id";
        }
    }
}
