using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
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

        public StudentFactory()
        {
            InitList();
            MakeStudent();
        }

        public void InitList()
        {
            _list = new List<Student>();

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

                _list.Add(temp);
            }
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

            _list.Add(temp);

            Console.WriteLine("\n학생 추가함 || 인원: {0}", _list.Count);
        }

        public void DeleteStudent(string studentNumber)
        {
            var studentId = int.Parse(studentNumber);
            var temp = new Student {StudentNumber = studentId};
            
            Console.WriteLine($"\n학생 제거! {studentId} 학생을 제거합니다 \n" +
                              $"남은 학생 수 : {_list.Count}");
            _list.Remove(temp);
        }

        public void EditStudent(string studentNumber)
        {
            var studentId = int.Parse(studentNumber);

            Console.WriteLine("\n학생 정보 수정하기");
            var source =
                from student in _list
                where student.StudentNumber == studentId
                select student;

            foreach (var editStudent in source)
            {
                editStudent.Email = "new Email!!";
                editStudent.PhoneNumber = "new Phone!!";
                editStudent.Name = "new Name";
                editStudent.Major = "new Major";
            }

            Console.WriteLine(SearchStudent(studentId));
        }

        public void ShowAllStudent()
        {
            Console.WriteLine("\n학생 목록 출력!");
            _list.ToArray().ToObservable().Subscribe(Console.WriteLine);
        }

        public Student SearchStudent(int inputNumber)
        {
            Student temp = null;
            Console.WriteLine($"\n학생 검색!! 입력 받은 번호 : {inputNumber}");
            var seq = _list.ToArray().ToObservable();

            var source =
                from student in seq
                where student.StudentNumber == inputNumber
                select student;

            source.Subscribe(x => { temp = x; });
   
            return temp;
        }
    }
}
