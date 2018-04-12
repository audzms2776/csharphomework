using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var studentFactory = new StudentFactory();


            while (true)
            {
                Console.WriteLine("한남대학교 관리시스템");
                Console.WriteLine("1. 학생 추가 ");
                Console.WriteLine("2. 학생 검색 ");
                Console.WriteLine("3. 학생 정보 변경 ");
                Console.WriteLine("4. 학생 삭제");
                Console.WriteLine("5. 학생 현황 출력 ");
                Console.WriteLine("6. 전체 학생 출력 ");
                Console.WriteLine("7. 종료 ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    //              1.학생 추가
                    case "1":
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
                        break;
                    //              2.학생 검색
                    case "2":
                        Console.WriteLine("검색할 학번 입력");
                        var studentNumber = Int32.Parse(Console.ReadLine());
                        var searchStudent = studentFactory.SearchStudent(studentNumber);
                        Console.WriteLine(searchStudent);
                        break;
                    //              3.학생 정보 변경
                    case "3":
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
                        break;
                    //              4.학생 삭제
                    case "4":
                        Console.WriteLine("삭제할 학번 입력");
                        var studentNumber3 = Console.ReadLine();
                        studentFactory.DeleteStudent(studentNumber3);
                        break;
                    //              5.학생 현황 출력
                    case "5":
                        studentFactory.ShowAllStatus();
                        break;
                    //              6.전체 학생 출력
                    case "6":
                        studentFactory.ShowAllStudent();
                        break;
                    //              7.종료
                    case "7":
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("잘못 입력함");
                        break;
                }

                Console.WriteLine("계속 하시겠습니까?? yes / no");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "yes":
                        Console.WriteLine("곧 돌아갑니다.....");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                    case "no":
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다... 돌아갑니다");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }
            }

//            studentFactory.AddScholarshipData("20171987");
        }
    }
}