/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pc_기반_제어_22._03._22
{
    internal class 버블정렬
    {
        static void Main(string[] args)
        {
            int i, j;
            int[] arr = { 42, 456, 3, 73, 10, 22 };
            int temp;

            for (i = 0; i < 6 - 1; ++i)  // step
            {
                for(j = 0; j < 6 - i - 1; ++j)  // step에서 실질적으로 비교를 수행함
                {
                    if (arr[j] > arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
            for (i = 0; i < 6; ++i)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
*/