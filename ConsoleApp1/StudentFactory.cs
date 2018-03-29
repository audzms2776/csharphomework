using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StudentFactory
    {
        public ArrayList _arrayList;

        // 18개
        private readonly int[] _studentNumbersInts =
        {
            20141932, 
            20181209, 
            20161183, 
            20012567, 
            20132985, 
            20172322, 
            20171987, 
            20161429, 
            20120740, 
            20141510, 
            20151148, 
            20152337, 
            20133056, 
            20151916, 
            20123481, 
            20182811, 
            20161464, 
            20161629
        };

        private readonly string[] _phoneNumbers =
        {
            "070 7684 6796",   
            "042 6608 6107",    
            "678 8442 8522",    
            "010 3627 2832",    
            "070 7616 6054",   
            "042 6608 7709",    
            "010 3954 7315",    
            "010 6038 4491",    
            "010 9943 7485",   
            "010 2752 7544",   
            "010 2786 6771",   
            "010 2539 9587",   
            "070 7079 4441",   
            "010 2666 2516",   
            "010 2659 1671",   
            "010 6049 1704",  
            "070 3316 5588",    
            "010 7935 7050"
        };

        private readonly string[] _emails =
        {
            "rkqwn12z@naver.com",
            "gmh9091d@naver.com",
            "mic313d7@naver.com",
            "seokm982@naver.com",
            "s6913528@naver.com",
            "soleeddh@nate.com ",
            "jjjyy306@naver.com",
            "ahshrl12@naver.com",
            "qqaa9813@naver.com",
            "ever9165@gmail.com",
            "chltigus@naver.com",
            "seohy424@naver.com",
            "cmw11dd7@naver.com",
            "sang8197@naver.com",
            "ju1991kr@naver.com",
            "seon9039@gmail.com",
            "vvv22vvv@gmail.com",
            "dms5d454@naver.com"

        };

        private readonly string[] _names =
        {
            "황갑주",
            "홍은경",
            "이예원",
            "홍석민",
            "함남규",
            "한소이",
            "하지연",
            "최지선",
            "최재필",
            "최영원",
            "최석현",
            "최서형",
            "최민우",
            "천상희",
            "조은상",
            "조선희",
            "정희석",
            "정혜은",
        };

        private readonly string[] _majors =
        {
            "법학전공",
            "경영학과",
            "경영학과",
            "경영학과",
            "생활체육학과",
            "식품영양학과",
            "아동복지학과",
            "무역학과",
            "디자인학과",
            "경제학과",
            "산업경영공학과",
            "회화과",
            "글로벌 IT 경영전공",
            "행정학과",
            "국어국문·창작학과",
            "자유전공학부",
            "경제학과",
            "컨벤션호텔경영학과",
        };

        public StudentFactory()
        {
            InitList();
            MakeStudent();
        }

        public void InitList()
        {
            _arrayList = new ArrayList();

            Console.WriteLine($"{_studentNumbersInts.Length}, " +
                              $"{_phoneNumbers.Length}, " +
                              $"{_emails.Length}, " +
                              $"{_names.Length}, " +
                              $"{_majors.Length}");
        }

        public void MakeStudent()
        {
            for (var i = 0; i < 18; i++)
            {
                var temp = new Student
                {
                    StudentNumber = _studentNumbersInts[i],
                    PhoneNumber = _phoneNumbers[i],
                    Email = _emails[i],
                    Name = _names[i],
                    Major = _majors[i]
                };

                _arrayList.Add(temp);
            }
        }

        public void AddStudent()
        {

        }

    }
}
