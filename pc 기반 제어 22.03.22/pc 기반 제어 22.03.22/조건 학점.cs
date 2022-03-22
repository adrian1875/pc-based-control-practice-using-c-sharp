/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pc_기반_제어_22._03._22
{
    internal class 조건_학점
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4.5 ~ 0.0 사이의 점수를 입력하세요.");
            Console.Write("당신의 점수 ");
            float input_score = float.Parse(Console.ReadLine());

            if (input_score == 4.5)
            {
                Console.WriteLine("당신의 학점은 : S");
            }
            else if (4.0 <= input_score)
            {
                Console.WriteLine("당신의 학점은 : A");
            }
            else if (3.0 <= input_score)
            {
                Console.WriteLine("당신의 학점은 : B");
            }
            else if (2.0 <= input_score)
            {
                Console.WriteLine("당신의 학점은 : C");
            }
            else
            {
                Console.WriteLine("당신의 학점은 : F");
                Console.WriteLine("정신차려 이친구야 이 각박한 세상 속에서");
            }
        }       
    }

}
*/