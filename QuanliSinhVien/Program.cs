using System;
using System.Collections.Generic;

namespace QuanliSinhVien
{
    internal class Program
    {
        private static List<Student> students = new List<Student>();
        private static List<Teacher> teachers = new List<Teacher>();
        private static void Main(string[] args)
        {
           
            var studentA = new Student()
            {
              Name="Minh Tien",
              Age = 20,
              Email = "minhtien@gmail.com",
              PhoneNumber ="067286387283862",
              Class ="GCD1001",
              Major="IT",
              Assignment=9,
              Midterm = 8,
              Final = 7,
            };
            var studentB = new Student()
            {
                Name = "Duc Tai",
                Age = 18,
                Email = "ductai@gmail.com",
                PhoneNumber="57372738235",
                Class = "GAD201819",
                Major = "BN",
                Assignment = 8,
                Midterm = 8,
                Final = 9,
            };

            students.Add(studentA);
            students.Add(studentB);
            Console.WriteLine("Thong tin sinh vien");
            foreach(var student in students)
            {
                student.DisplayBasicInformation();
                Console.WriteLine("------------------------------------------------------");
            }
            
        }
    }
}
