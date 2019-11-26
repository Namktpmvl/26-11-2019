using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.StudentManagement
{
    public class LogicLayer
    {
        public Student[] GetStudents()
        {
            var db = new DHNEntities();
            return db.Students.ToArray();

        }

        public Student GetStudent(int id)
        {
            var db = new DHNEntities();
            return db.Students.Find(id);
        }

        public void CreateStudent(string code, string name, int class_id)
        {
            var newStudent = new Student();
            newStudent.Name = name;
            newStudent.Code = code;
            newStudent.Class_id = class_id;

            var db = new DHNEntities();
            db.Students.Add(newStudent);
            db.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            var db = new DHNEntities();
            var student = db.Students.Find(id);

            db.Students.Remove(student);
            db.SaveChanges();

        }

        public void UpdateStudent(int id , string name , int class_id)
        {
            var db = new DHNEntities();
            var student = db.Students.Find(id);

            student.Name = name;
            student.Class_id = class_id;

            db.Entry(student).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            
        }

        public Class[] GetClasses()
        {
            var db = new DHNEntities();
            return db.Classes.ToArray();

        }
    }
}
