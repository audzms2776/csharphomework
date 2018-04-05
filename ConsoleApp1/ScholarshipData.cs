using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ScholarshipData
    {
        private readonly string _scholarshipName;
        private readonly string _scholarshipDate;
        private readonly int _scholarshipMoney;

        public ScholarshipData(string scholarshipName, string scholarshipDate, int scholarshipMoney)
        {
            _scholarshipName = scholarshipName;
            _scholarshipDate = scholarshipDate;
            _scholarshipMoney = scholarshipMoney;
        }

        public override string ToString()
        {
            return $"{_scholarshipDate} .. {_scholarshipName} .. {_scholarshipMoney}";
        }
    }
}
