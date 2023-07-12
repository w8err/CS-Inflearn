namespace _5_Generic
{
    internal class Program
    {
        class MyList<T> where T : struct // 제너릭 클래스(일반화 클래스). Template 또는 Type의 약자다.
                                         // 여기엔 어떤 타입의 자료형이든 넣으면 작동한다. 
        {               // where T : struct == T는 struct형이어야 한다는 조건

            T[] arr = new T[10];    // 타입이 상관없음

            public T GetItem(int i)
            {
                return arr[i];
            }
        }

        static void Test<T>(T input)      // 제너릭 메소드. 
        {
            Test<int>(3);
        }

        static void Main(string[] args)
        {
            // object 자료형 == 모든 타입을 소화 가능. var도 마찬가지임.
            // 그럼 var랑 object는 무슨 차이가 있는가
            // var는 string을 명시적으로 입력하지 않아도 컴파일러가 때려맞춤
            // object는 컴파일러가 맞출 필요가 없음. 찐 타입이기 때문.


            object obj = 3;
            object obj2 = "hello world";

            int num = (int)obj;
            string str = (string)obj2;  // object로 박싱, 특정 자료형으로 언박싱 -> 많은 시간과 자원 소모        }
    }
}