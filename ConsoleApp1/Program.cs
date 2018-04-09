using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using System.Reactive.Linq;

namespace ConsoleApp1
{
    internal class Program 
    {
        private static void Main(string[] args)
        {
            var studentFactory = new StudentFactory();


            Console.WriteLine("한남대학교 관리시스템");
            Console.WriteLine("학생 추가 ");
//            studentFactory.AddStudent(3, "2", "33", "44", "555");
//            studentFactory.ShowAllStudent();
//            var searchStudent = studentFactory.SearchStudent(20181209);
//            Console.WriteLine(searchStudent);

//            studentFactory.DeleteStudent("20141932");
//            studentFactory.DeleteStudent("20181209");

//            studentFactory.EditStudent("20181209");
            studentFactory.AddScholarshipData("20181209");

//            studentFactory.ShowAllStatus();

            studentFactory.ShowAllStudent();
        }
    }
}
