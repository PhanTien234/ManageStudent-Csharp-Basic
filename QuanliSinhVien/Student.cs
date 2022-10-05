using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanliSinhVien
{
    internal class Student:Member
    {   
        public string Class { get; set; }
        public string Major { get; set; }
        public double Assignment { get; set; }
        public double Midterm { get; set; }
        public double Final { get; set; }
        public string Status { get; set; }

        public double Overral
        {
            get
            {
                var overral = (Assignment + Midterm * 2 + Final * 3) / 6;
                return overral;
            }
        }
        new public void DisplayBasicInformation()
        {
            base.DisplayBaseInformation();
            Console.WriteLine("Lop:  " + Class);
            Console.WriteLine("Chuyen Nganh: " + Major);
            Console.WriteLine("Overall: " + Overral);
            
        }
        public void GetDetailGrade()
        {
            Console.WriteLine("Baitap: " + Assignment);
            Console.WriteLine("Giua ki: " + Midterm);
            Console.WriteLine("Cuoi ki: " + Final);
            Console.WriteLine("Diem trung binh: " + Overral);
        }
    

    }
}
