using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.StudentManagement
{
    public class StudentView
    {
        public int id { get; set; }

        public string Code { get; set;}

        public string Name { get ; set; }

        public string Class { get; set; }

        public StudentView(Student student)
        {
            this.id = student.Id;
            this.Code = student.Code;
            this.Name = student.Name;
            this.Class = student.Class.Name;
        }
    }
}
