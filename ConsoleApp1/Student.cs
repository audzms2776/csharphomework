using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        private ArrayList _scholarshipArray = new ArrayList();

        public Student()
        {

        }

        public int StudentNumber { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Major { get; set; }
    }
}
