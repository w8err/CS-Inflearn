using System;
using System.Collections.Generic;

namespace List_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 배열의 크기를 유동적으로 늘릴 수 있는 동적 배열 = List
            List<float> list = new List<float>();   // float 형태의 List를 생성

            for (int i = 0; i < 5; i++)
            { 
                list.Add(i);
                Console.WriteLine(list[i]);
            }

            //or

            foreach(int num in list)
            {
                Console.WriteLine(num);
            }

            // 만약 배열의 중간 인덱스에 값을 넣고 싶다면(add)
            list.Insert(2, 999);

            foreach(int num in list)
                Console.WriteLine(num);
             
            // remove
            bool success = list.Remove(3);             // 괄호 안의 값을 삭제해줌. 만약 3이 여러개라면 인덱스가 제일 작은 값을 삭제함
                                                       // 3이 지워졌기 때문에 success는 true로 바뀜

            // removeat
            list.RemoveAt(0);                           // 괄호 안의 인덱스 위치에 있는 값을 삭제함.

            // clear. 말 그대로 리스트를 비움
            list.Clear();
        }
    }
}
