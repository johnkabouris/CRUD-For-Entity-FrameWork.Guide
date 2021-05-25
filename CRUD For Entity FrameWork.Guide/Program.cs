using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CRUD_For_Entity_FrameWork.Guide
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateStudents();
            //ReadStudents();
            //UpdateStudents();
            //DeleteStudents();

            //SelectAllWithLINQ();
        }

        private static void SelectAllWithLINQ()
        {
            MyDatabase db = new MyDatabase();
            var students = db.Students.SqlQuery("Select * From Students").ToList();
            foreach (var stu in students)
            {
                Console.WriteLine(stu.LastName);
            }
        }

        private static void DeleteStudents()
        {
            MyDatabase db = new MyDatabase();
            Student stu = db.Students.Find(2);//instead of using the id u can pass directly the number of the id u want 
            //into Find Method
            if (stu is null)
            {
                Console.WriteLine("Id not found");
            }
            else
            {
                db.Entry<Student>(stu).State = EntityState.Deleted;
                db.SaveChanges();//Always use this to save changes 
            }
        }

        private static void UpdateStudents()
        {
            MyDatabase db = new MyDatabase();
            int id = 1;
            Student stu = db.Students.Find(id);
            if (stu is null)
            {
                Console.WriteLine("Id not found ");
            }
            else
            {
                Console.WriteLine(stu.TuitionFees);
                stu.TuitionFees = 5000;
                stu.LastName = "Parker";
                db.Entry<Student>(stu).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        private static void ReadStudents()
        {
            using (MyDatabase db = new MyDatabase())
            {
                var students = db.Students;
                foreach (var stud in students)
                {
                    Console.WriteLine(stud.LastName);
                }
            }
        }

        private static void CreateStudents()
        {
            MyDatabase db = new MyDatabase();
            Student stu = new Student() { FirstName = "Morgan", LastName = "Freeman", TuitionFees = 2600 };
            db.Entry<Student>(stu).State = EntityState.Added;
            db.SaveChanges();
        }

    }
}
