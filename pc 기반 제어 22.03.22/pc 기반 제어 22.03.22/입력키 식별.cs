/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pc_기반_제어_22._03._22
{
    internal class 입력키_식별
    {
        static void Main(string[] args)
        {
            Console.WriteLine("D, Z, M, H중 선택해!");
            ConsoleKeyInfo info = Console.ReadKey();  // ConsoleKeyInfo는 클래스가 아니라 구조체
            Console.WriteLine("");

            switch (info.Key)
            {
                case ConsoleKey.D:
                    Console.WriteLine("드론이 나왔습니다. 불쌍한 아이...");
                        break;
                case ConsoleKey.Z:
                    Console.WriteLine("건물 철거반 풀업 저글링 나갑니다. ");
                    break;
                case ConsoleKey.M:
                    Console.WriteLine("당신은 이재동? 신의 뮤짤을 보여줘!");
                    break;
                case ConsoleKey.H:
                    Console.WriteLine("토스 담당 일찐 히드라 출격");
                    break;
                default:
                    Console.WriteLine("D, Z, M, H중 선택하라고!");
                    break;

            }
        }
    }
}
*/