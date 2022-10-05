using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanliSinhVien
{
    internal class Teacher:Member
    {
        public string Certificate { get; set; }
        public double Salary { get; set; }
        public List<string> Classes { get; set; }
        new public void DisplayBasicInformation()
        {
            base.DisplayBaseInformation();
            Console.WriteLine("Loai bang:  " + Certificate);
            //Console.WriteLine("Luong: " + Salary);
           
        }
        // Ham tra ve lop day
        public List<string> GetClasses()
        {
            Console.WriteLine("So lop dang day: " + Classes.Count);
            return Classes;
        }
    }
   
}
