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
        public readonly List<ScholarshipData> ScholarshipArray = new List<ScholarshipData>();

        public int StudentNumber { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Major { get; set; }

        public override string ToString()
        {
            var returnStr = $"전공: {Major} - 학번: {StudentNumber} - 이름: {Name}" +
                            $" - 이메일: {Email} - 폰 번호 : {PhoneNumber} \n";

            foreach (var variable in ScholarshipArray)
            {
                returnStr += $"{variable} \n";
            }

            return returnStr;
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

        public void AddScholarship(string shName, string shDate, int shMoney)
        {
            ScholarshipArray.Add(new ScholarshipData(shName, shDate, shMoney));
        }
    }
}
