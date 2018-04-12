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
            while (true)
            {
                Menu.ShowMainMenu();

                var choice = Console.ReadLine();

                switch (choice)
                {
                    //              1.학생 추가
                    case "1":
                        Menu.AddMenuStudent();
                        break;
                    //              2.학생 검색
                    case "2":
                        Menu.SearchMenuStudent();
                        break;
                    //              3.학생 정보 변경
                    case "3":
                        Menu.EditMenuStudent();
                        break;
                    //              4.학생 장학금 추가
                    case "4":
                        Menu.AddMenuScholarShip();
                        break;
                    //              5.학생 삭제
                    case "5":
                        Menu.DeleteMenuStudent();
                        break;
                    //              6.학생 현황 출력
                    case "6":
                        Menu.ShowMenuStatus();
                        break;
                    //              7.전체 학생 출력
                    case "7":
                        Menu.ShowMenuStudent();
                        break;
                    //              8.종료
                    case "8":
                        Menu.ExitMenu();
                        break;
                    default:
                        Console.WriteLine("잘못 입력함");
                        break;
                }

                Menu.ControlMenu();
            }

//            studentFactory.AddScholarshipData("20171987");
        }
    }
}