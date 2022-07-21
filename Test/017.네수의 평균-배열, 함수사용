/'
프로그램 명: average
네 정수를 입력 받아 평균을 출력하는 프로그램을 작성하세요.
정수 입력 사이에는 공백으로 구분되며 , 평균은 소수 2 째 자리까지 출력하세요.(소수 3 번째 자리에서 반올림)

입출력 예

입력
7 7 7 7

출력
7.00

입력
2 5 9 5

출력
5.25
'/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp_Quiz16
{
    class Average
    {
        public void Input(ref int[] a)
        {
            for (int i = 0; i < a.Length; i++) {
                Console.Write($"{i+1}번쨰 숫자를 입력하세요 : ");
                a[i] = Int32.Parse(Console.ReadLine());
            }
        }
        public double avg(ref int[] a)
        {
            double sum = 0;
            for(int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            return sum / a.Length;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[4];
            Average avg = new Average();
            avg.Input(ref num);
            Console.WriteLine(string.Format("{0:F2}",avg.avg(ref num)));
        }
    }
}
