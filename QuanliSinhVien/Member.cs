using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanliSinhVien
{
    internal class Member
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

       
       
        
        
        public void DisplayBaseInformation()
        {
            
            Console.WriteLine("Ten:  " + Name);
            Console.WriteLine("Tuoi: " + Age);
            Console.WriteLine("Gmail: " + Email);
            Console.WriteLine("SDT:  " + PhoneNumber);
        }
    }
   
}
