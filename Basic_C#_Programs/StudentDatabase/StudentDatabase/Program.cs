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

        public int Age { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
               
                context.Database.CreateIfNotExists();

               
                var student = new Student
                {
                    Name = "John Doe",
                    Age = 20
                };

             
                context.Students.Add(student);

         
                context.SaveChanges();

                Console.WriteLine("Student added to the database.");
            }

            Console.ReadLine();
        }
    }
}
