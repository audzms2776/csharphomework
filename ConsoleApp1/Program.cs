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
    class Program 
    {
        private static void Main(string[] args)
        {
            var studentFactory = new StudentFactory();

            studentFactory.AddStudent(3, "2", "33", "44", "555");
            studentFactory.ShowAllStudent();
            var searchStudent = studentFactory.SearchStudent(20181209);
            Console.WriteLine(searchStudent);
        }
    }
}
