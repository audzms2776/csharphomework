using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Menu
    {
        static StudentFactory studentFactory = new StudentFactory();

        public static void ShowMainMenu()
        {
            Console.WriteLine("한남대학교 관리시스템");
            Console.WriteLine("1. 학생 추가 ");
            Console.WriteLine("2. 학생 검색 ");
            Console.WriteLine("3. 학생 정보 변경 ");
            Console.WriteLine("4. 학생 장학금 추가");
            Console.WriteLine("5. 학생 삭제");
            Console.WriteLine("6. 학생 현황 출력 ");
            Console.WriteLine("7. 전체 학생 출력 ");
            Console.WriteLine("8. 종료 ");
        }

        public static void AddMenuStudent()
        {
            Console.WriteLine("학번");
            var tempStudentId = Int32.Parse(Console.ReadLine());
            Console.WriteLine("전화번호");
            var tempphoneNumber = Console.ReadLine();
            Console.WriteLine("이메일");
            var tempemail = Console.ReadLine();
            Console.WriteLine("이름");
            var tempname = Console.ReadLine();
            Console.WriteLine("전공");
            var tempmajor = Console.ReadLine();

            studentFactory.AddStudent(tempStudentId, tempphoneNumber, tempemail, tempname, tempmajor);
        }

        public static void AddMenuScholarShip()
        {
            studentFactory.ShowAllStudentId();
            Console.WriteLine("추가할 학번 입력");
            studentFactory.AddScholarshiponly(Console.ReadLine());
        }

        public static void SearchMenuStudent()
        {
            studentFactory.ShowAllStudentId();
            Console.WriteLine("검색할 학번 입력");
            var studentNumber = Int32.Parse(Console.ReadLine());
            var searchStudent = studentFactory.SearchStudent(studentNumber);
            Console.WriteLine(searchStudent);
        }

        public static void EditMenuStudent()
        {
            studentFactory.ShowAllStudentId();
            Console.WriteLine("변경할 학번 입력");
            var studentNumber2 = Console.ReadLine();

            Console.WriteLine("전화번호");
            var tempphoneNumber2 = Console.ReadLine();
            Console.WriteLine("이메일");
            var tempemail2 = Console.ReadLine();
            Console.WriteLine("이름");
            var tempname2 = Console.ReadLine();
            Console.WriteLine("전공");
            var tempmajor2 = Console.ReadLine();

            studentFactory.EditStudent(studentNumber2, tempphoneNumber2, tempemail2, tempname2, tempmajor2);
        }

        public static void DeleteMenuStudent()
        {
            Console.WriteLine("삭제할 학번 입력");
            var studentNumber3 = Console.ReadLine();
            studentFactory.DeleteStudent(studentNumber3);
        }

        public static void ShowMenuStatus()
        {
            studentFactory.ShowAllStatus();
        }

        public static void ShowMenuStudent()
        {
            studentFactory.ShowAllStudent();
        }

        public static void ExitMenu()
        {
            Console.Clear();
            Environment.Exit(0);
        }

        public static void ControlMenu()
        {
            Console.WriteLine("계속 하시겠습니까?? yes / no");
            var input = Console.ReadLine();

            switch (input)
            {
                case "yes":
                    Console.Write("곧 돌아갑니다.....");
                    Thread.Sleep(400);
                    Console.Write(".");
                    Thread.Sleep(400);
                    Console.Write(".");
                    Thread.Sleep(400);
                    Console.Write(".");
                    Thread.Sleep(400);
                    Console.Write(".");
                    Thread.Sleep(400);
                    Console.Write(".");
                    Console.Clear();
                    break;
                case "no":
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다... 돌아갑니다");
                    Thread.Sleep(1500);
                    Console.Clear();
                    break;
            }
        }
    }
}