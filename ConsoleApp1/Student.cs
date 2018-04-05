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

        public int StudentNumber { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Major { get; set; }

        public override string ToString()
        {
            return $"전공: {Major} | 학번: {StudentNumber} | 이름: {Name}" +
                   $" | 이메일: {Email} | 폰 번호 : {PhoneNumber} |";
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (!(obj is Student objAsPart))
            {
                return false;
            }

            return Equals(objAsPart);
        }

        protected bool Equals(Student other)
        {
            return StudentNumber == other.StudentNumber;
        }

        public override int GetHashCode()
        {
            return StudentNumber;
        }
    }
}
