using System;

namespace 배열__while__for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };  // 최조 입력값, 이를 자릿수를 계산하는데 사용
            int[] arr2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };  // 자릿수 누적합을 위한 합계를 임시 저장, 각 자릿수의 최종 합을 저장함
            int[] arr3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };  // 각 자릿수의 합을 구하기 위해 입력값을 저장함
            int[] arr4 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };  // 각 자릿수의 합을 구하기 위해 필요한 자릿수를 저장 
            int[] pow_arr = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };  // 10의 n승을 저장하는 변수

            int i, j, k;  // 반복을 위한 변수
            int cnt = 1;  // 자릿수
            int pow = 1; // 승수를 계산하기 위한 변슈
            int temp = 0;  // 자릿수 합을 위한 변수

            for (i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());  // 입력 받음
                arr3[i] = arr1[i];  // arr1을 자릿수를 저장하는 용도로 다시 사용할거라 arr3에 입력본을 복사함
            }

            for (i = 0; i < arr1.Length; i++)
            {
                // 자릿수 확인
                while (true)
                {
                    if ((arr1[i] / 10) >= 1)
                    {
                        arr1[i] = (arr1[i] / 10);
                        cnt++;
                    }
                    else
                    {
                        arr1[i] = cnt;
                        arr4[i] = cnt;
                        cnt = 1;
                        break;
                    }
                }
            }

// arr1은 자릿수
            for (j = 0; j < arr1.Length; j++)
            {
                while (arr1[j] > 1) // pow의 초기값은 1, 여기 통과 못하면 한자릿 수
                {
                   pow *= 10;
                   arr1[j]--;
                }

                pow_arr[j] = pow;  // while 통과 못하면 한자릿 수라서 1대입 
                pow = 1;
            }

// pow_arr은 10의 n승, arr3은 입력값이 들어가 있음, arr2에는 합을 넣고 싶음
            for (i = 0; i < pow_arr.Length; i++)  // 입력 받은 수의 개수 만큼 반복함 
            {
                for (k = 0; k < arr4[i]; k++)  // 자릿수 만큼 돌면서 10의 n승으로 나누고 그 누적 합을 구함
                {
                    arr2[i] = (arr3[i] / pow_arr[i]);  // 입력 수를 10의 n승으로 나누면서 각 자릿수 별 수를 arr2에 임시 저장, 
                    arr3[i] = arr3[i] % pow_arr[i];  // 입력 수를 10의 n승으로 나눈 나머지(나머지 자리들의 수)를 구해 다시 arr3에 저장,
                    pow_arr[i] = pow_arr[i] / 10;  // 10의 n-1승으로 만듦
                    temp = temp + arr2[i];  // 자릿수의 누적 합을 구함
                }
                arr2[i] = temp;  // arr2에 누적 합을 넣음
                temp = 0;
            }

            // for (i = 0; i < arr2.Length; i++)  // 누적 합들을 출력
            // {
            //     Console.WriteLine(arr2[i]);
            // }

            

        }
    }
}
