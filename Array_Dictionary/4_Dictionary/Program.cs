using System;
using System.Collections.Generic;

namespace _4_Dictionary
{

    class Monster
    { 
        public int id;
        public Monster(int id) { this.id = id; }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 딕셔너리？
            // 100만마리의 몬스터 중 103번 몬스터를 찾으려면 어떻게 해야하나 

            Dictionary<int, Monster> dic = new Dictionary<int, Monster>(); 
            // 키를 알면 뒤의 value를 굉장히 빨리 찾을 수 있다.      but value를 안다고 키를 찾을 순 없음

            // 딕셔너리에 몬스터 생성하는 법
            // dic.Add(1, new Monster(1));
            // dic[5] = new Monster(5);

            for(int i = 0; i < 10000; i++) { 
                dic.Add(i, new Monster(i));
            }

            Monster mon;
            bool found = dic.TryGetValue(1500, out mon);

            dic.Remove(1000);   // 1000번 몬스터 삭제
            dic.Clear();        // 딕셔터리 내용 Clear



            // 딕셔너리는 HashTable 기법을 사용한다.
            /*  해시테이블？
             * 1. 아주 큰 박스에 공이 1만개 있다. 각자 인덱스도 존재함. 1~1만
             * 2. 박스 여러개로 소분한다. [1~100] [ 101~200 ] ... 
             * 3. 결과적으로 만개 중에서 찾는거보단 찾기 쉽다.
             * 결과 : 메모리를 많이 사용하지만, 데이터가 정렬되고, 찾기 쉬워짐
             * 
             * && 메모리를 내주고, 성능을 취한다. 
             */
        }
    }
}
