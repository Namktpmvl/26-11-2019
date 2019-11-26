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
    public partial class Update_Form : Form
    {
        private int StudentId;
        private LogicLayer Business;
        public Update_Form(int id)
        {
            InitializeComponent();
            this.StudentId = id;
            this.Business = new LogicLayer();
            this.Load += Update_Form_Load;
        }

        void Update_Form_Load(object sender, EventArgs e)
        {
            var student = this.Business.GetStudent(this.StudentId);

            this.comboClass.DataSource = this.Business.GetClasses();
            this.comboClass.DisplayMember = "Name";
            this.comboClass.ValueMember = "Id";
            this.comboClass.SelectedValue = student.Class_id;
        }
    }
}
