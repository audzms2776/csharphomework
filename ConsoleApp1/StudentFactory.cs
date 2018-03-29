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
        private List<Student> _list = new List<Student>();
        
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

            Console.WriteLine("학생 추가함 || 인원: {0}", _list.Count);
        }

        public void ShowAllStudent()
        {
            _list.ToArray().ToObservable().Subscribe(Console.WriteLine);
        }

        public Student SearchStudent(int inputNumber)
        {
            Student temp = null;
            Console.WriteLine($"학생 검색!! 입력 받은 번호 : {inputNumber}");
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
