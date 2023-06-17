using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                var student = new Student { Name = "Billy Jeans" };
                db.Students.Add(student);
                db.SaveChanges();


                Console.WriteLine("Student added successfully!");

                // Retrieve all students from the database
                var students = db.Students;
                foreach (var s in students)
                {
                    Console.WriteLine($"Student ID: {s.StudentId}, Name: {s.Name}");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
