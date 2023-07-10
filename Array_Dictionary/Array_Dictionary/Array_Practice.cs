using System;
using System.Security.Cryptography;

namespace Array_Dictionary
{
    internal class Array_Practice
    {
        static void Main(string[] args)
        {
            // 배열
            int   a;
            int[] scores = new int[5];        // b라는 배열은 int 형식의 여러 데이터를 갖고 있다. 그리고 꼭 new 선언해줘야 함
           
            int[] scores2 = scores; // -- >scores2 는 scores의 배열을 참조하게 됨

            // new int[5] { 10, 20, 30, 40, 50}; 처럼 명시적으로 선언도 가능


            // 0 1 2 3 4 ... index는 0부터
            for(int i = 0; i < scores.Length; i++)
            {
                scores[i] = (i+1) * 10;
            }

            for(int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }    

            //foreach 예문
            foreach(int score in scores)        // scores 안의 int score 하나하나에 밑의 코드를 전부 적용한다
            {
                Console.WriteLine(score);               
            }
        }
    }
}
