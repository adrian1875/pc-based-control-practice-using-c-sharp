/*using System;

namespace pc_기반_제어_22._03._22
{
    internal class if_조건문
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int i = 0;
            Console.Write("숫자입력: ");
            int input = int.Parse(Console.ReadLine());
         
            while (true) {

                if (input == arr[i])
                {
                    Console.WriteLine(arr[i] + "번에서 " + input + "을 찾았습니다.");
                    break;
                }
                else {
                    Console.WriteLine("1에서 6까지의 수를 입력해주세요");
                }

                Console.Write("숫자입력: ");
                input = int.Parse(Console.ReadLine());

                ++i;
            }

            
        }
    }
}
*/