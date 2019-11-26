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
    public partial class Index_Form : Form
    {
        private LogicLayer Business;
        public Index_Form()
        {
            InitializeComponent();
            this.Business = new LogicLayer();
            this.btnCreate.Click += btnCreate_Click;
            this.btnDelete.Click += btnDelete_Click;
            this.GridStudent.DoubleClick += GridStudent_DoubleClick;
            this.Load += Index_Form_Load;

        }
        private void ShowAllStudent()
        {
            //this.GridStudent.DataSource = this.Business.GetStudents();
            var students = this.Business.GetStudents();
            var studentView = new StudentView[students.Length];
            for (int i = 0; i < students.Length; i++)
                studentView[i] = new StudentView(students[i]);

            this.GridStudent.DataSource = studentView;
        }

        void Index_Form_Load(object sender, EventArgs e)
        {
            this.ShowAllStudent();
            
        }

        void GridStudent_DoubleClick(object sender, EventArgs e)
        {
            if(this.GridStudent.SelectedRows.Count == 1)
            {
                var row = this.GridStudent.SelectedRows[0];
                var studentView = (StudentView)row.DataBoundItem;

                (new Update_Form(studentView.id)).ShowDialog();
            }
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnCreate_Click(object sender, EventArgs e)
        {
            var createform = new Create_Form();
            createform.ShowDialog();
            this.ShowAllStudent();
        }
    }
}
