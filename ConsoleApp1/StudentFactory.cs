using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StudentFactory
    {
        private List<Student> _list;

        private readonly int[] _studentNumbersInts = Constants.StudentNumbersInts;
        private readonly string[] _phoneNumbers = Constants.PhoneNumbers;
        private readonly string[] _emails = Constants.Emails;
        private readonly string[] _names = Constants.Names;
        private readonly string[] _majors = Constants.Majors;
        private readonly Random _random = new Random();

        public StudentFactory()
        {
            InitList();
            MakeStudent();
        }

        public void InitList()
        {
            _list = new List<Student>();

//            Console.WriteLine($"{_studentNumbersInts.Length}, " +
//                              $"{_phoneNumbers.Length}, " +
//                              $"{_emails.Length}, " +
//                              $"{_names.Length}, " +
//                              $"{_majors.Length}");
        }

        public void MakeStudent()
        {
            for (var i = 0; i < 10; i++)
            {
                var temp = new Student
                {
                    StudentNumber = _studentNumbersInts[i],
                    PhoneNumber = _phoneNumbers[i],
                    Email = _emails[i],
                    Name = _names[i],
                    Major = _majors[i]
                };

                GetScholarshipData(temp, true);

                _list.Add(temp);
            }
        }

        public void ShowAllStudentId()
        {
            _list.ForEach(s => Console.Write(s.StudentNumber + " / "));
            Console.WriteLine();
        }

        public void AddStudent(int studentNumber, string phoneNumber, string email, string name,
            string major)
        {
            var temp = new Student
            {
                StudentNumber = studentNumber,
                PhoneNumber = phoneNumber,
                Email = email,
                Name = name,
                Major = major
            };

            ShowScholarshipDataList();
            GetScholarshipData(temp, false);
            _list.Add(temp);

            Console.WriteLine("\n학생 추가함 || 인원: {0}", _list.Count);
        }

        public void ShowScholarshipDataList()
        {
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine(
                    $"{i + 1}. {Constants.ShcolarshipNames[i]} -- {Constants.ShcolarshipDates[i]} -- {Constants.ShcolarshipMoneys[i]}");
            }
        }

        public void AddScholarshipData(string studentNumber)
        {
            var studentId = int.Parse(studentNumber);
            var tempStudent = SearchStudent(studentId);
//            ShowScholarshipDataList();

            GetScholarshipData(tempStudent);
        }

        public void GetScholarshipData(Student tempStudent)
        {
            var choiceIdx = _random.Next(0, 4);

            tempStudent.AddScholarship(
                Constants.ShcolarshipNames[choiceIdx],
                Constants.ShcolarshipDates[choiceIdx],
                Constants.ShcolarshipMoneys[choiceIdx]);
        }

        public void GetScholarshipData(Student tempStudent, int choiceKey)
        {
            tempStudent.AddScholarship(
                Constants.ShcolarshipNames[choiceKey],
                Constants.ShcolarshipDates[choiceKey],
                Constants.ShcolarshipMoneys[choiceKey]);
        }

        public void GetScholarshipData(Student tempStudent, bool isAuto)
        {
            if (isAuto)
            {
                // TODO
                // 나중에 선택할 수 있는 기능 넣어야함
                var choiceIdx = _random.Next(0, 4);

                tempStudent.AddScholarship(
                    Constants.ShcolarshipNames[choiceIdx],
                    Constants.ShcolarshipDates[choiceIdx],
                    Constants.ShcolarshipMoneys[choiceIdx]);
            }
            else
            {
                var tempChoice = Int32.Parse(Console.ReadLine()) - 1;
                GetScholarshipData(tempStudent, tempChoice);
            }
        }

        public void DeleteStudent(string studentNumber)
        {
            var studentId = int.Parse(studentNumber);
            var temp = new Student {StudentNumber = studentId};

            _list.Remove(temp);
            Console.WriteLine($"\n학생 제거! {studentId} 학생을 제거합니다 \n" +
                              $"남은 학생 수 : {_list.Count}");
        }

        public void EditStudent(string studentNumber, string phone, string email, string name, string major)
        {
            var studentId = int.Parse(studentNumber);

            Console.WriteLine("\n학생 정보 수정하기");
            var source =
                from student in _list
                where student.StudentNumber == studentId
                select student;

            foreach (var editStudent in source)
            {
                editStudent.Email = email;
                editStudent.PhoneNumber = phone;
                editStudent.Name = name;
                editStudent.Major = major;

                GetScholarshipData(editStudent, false);
            }

            Console.WriteLine(SearchStudent(studentId));
        }

        public void ShowAllStudent()
        {
            Console.WriteLine("\n학생 목록 출력!");
            _list.ForEach(Console.WriteLine);
        }

        public Student SearchStudent(int inputNumber)
        {
            Student temp = null;
            Console.WriteLine($"\n학생 검색!! 입력 받은 번호 : {inputNumber}");

            var source =
                from student in _list
                where student.StudentNumber == inputNumber
                select student;
            
            foreach (var vv in source)
            {
                temp = vv;
            }

            return temp;
        }

        public void ShowAllStatus()
        {
            Console.WriteLine($"전체 학생 숫자 : {_list.Count}");

            var sumScholaship = 0;

            foreach (var student in _list)
            {
                foreach (var data in student.ScholarshipArray)
                {
                    sumScholaship += data.ScholarshipMoney;
                }
            }

            Console.WriteLine($"장학금 총액 : {sumScholaship}");
            Console.WriteLine($"평균 수혜 장학금 {sumScholaship / _list.Count}");
        }
    }
}