using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace Array_Dictionary
{

    internal class Array_Example
    {
        // 제일 큰 수 뽑기
        static int GetHighestScore(int[] scores)
        {
            int maxValue = 0;
            
            foreach (int score in scores)
            {
                if(score >= maxValue)
                    maxValue = score;
            }
            return maxValue;
        }


        // 평균 뽑기
        static int GetAverageScore(int[] scores)
        {
            int sum = 0;
            foreach(int score in scores)
            {
                sum += score;
            }
            if(scores.Length == 0)
            {
                return 0;
            }

            return sum / scores.Length;
        }

        // 배열 안에서 value가 있으면 value의 인덱스를 리턴, 없으면 -1 리턴
        static int GetIndex0f(int[] scores, int value)
        {
            for(int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == value) 
                    return i;
            }
            return -1;
        }

        // 오름차순정렬
        static void Sort(int[] scores)
        {
            for (int i = 0; i < scores.Length; i++)
            {
                // i ~ scores.Length - 1까지 제일 작은 숫자가 있는 index를 찾음
                int minIndex = i;
                for ( int j = i; j < scores.Length; j++)
                {
                    if (scores[j] < scores[minIndex])
                        minIndex = j;
                }

                // swap
                int temp = scores[i];
                scores[i] = scores[minIndex];
                scores[minIndex] = temp;
            }
        }

        static void Main(string[] args)
        {
            int[] scores = new int[6] { 10, 30, 40, 20, 60, 50 };

            int highestnum = GetHighestScore(scores);
            Console.WriteLine("제일 큰 수는 " + highestnum + "입니다.");

            int averageNum = GetAverageScore(scores);
            Console.WriteLine("배열의 평균은 " + averageNum + "입니다.");

            int index = GetIndex0f(scores, 60);
            Console.WriteLine("60은 " + index + "번째에 있습니다.");

            Sort(scores);

        }
    }
}
