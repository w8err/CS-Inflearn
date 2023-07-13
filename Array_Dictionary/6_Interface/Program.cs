namespace CSharp
{
    class Program
    {
        abstract class Monster          // abstract = 추상 클래스. 여기선 개념적으로만 존재함. 반드시 구현해야 하기 때문에 버그를 찾기 용이
        {
            public abstract void Shout();
        }

        abstract class Flayble
        {
            public abstract void Fly();

    }
}