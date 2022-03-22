/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pc_기반_제어_22._03._22
{
    internal class 중첩_조건문
    {
        static void Main(string[] args)
        {
            Console.Write("지금은 아/점/저 중 언제? \n");
            int hour_now = DateTime.Now.Hour;

            switch (hour_now)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("아침 먹자!");
                    break;

                case 11:
                case 12:
                case 13:
                case 14:
                    Console.WriteLine("점심 먹자!");
                    break;

                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                    Console.WriteLine("저녁 먹자!");
                    break;
            }
        }
    }
}
*/