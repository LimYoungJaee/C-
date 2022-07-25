/*
프로그램 명: big_clock
성당의 종을 울리는 시계가 몇 주전 부터 고장이 나서 고쳤더니 이 시계가 종을 이상하게 울리네요. 1 시에 13 번 , 2 시에 14 번 , ... , 12 시에 24 번 , 13 시에 1 번,14 시에 2 번, ..., 0 시에 12 번
시각이 주어질 때 울리는 종의 횟수를 출력하는게 문제이다.

입력
입력은 두 개의 정수 H,M 이 : 로 구분되어 입력된다. (0 <= H < 24, 0 <= M < 60)

출력
종의 횟수를 출력한다.

입력
1:00

출력
13

입력
01:01

출력
0

입력
00:00

출력
12
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp_Quiz_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str_time = Console.ReadLine();
            string[] arr_time = str_time.Split(':');

            int num = 12;

            if (arr_time[1] == "00")
            {
                num = num + Int32.Parse(arr_time[0]);
                if (num == 24){
                    Console.WriteLine(num);
                }
                else
                Console.WriteLine(num%24);
            }
            else Console.WriteLine("0");
        }
    }
}
