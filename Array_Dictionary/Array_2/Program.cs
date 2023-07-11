using System;

namespace Array_2
{
    class Map 
    {
        int[,] tiles =
        {
            { 1, 1, 1, 1, 1},
            { 1, 0, 0, 0, 1},
            { 1, 0, 0, 0, 1},
            { 1, 0, 0, 0, 1},
            { 1, 1, 1, 1, 1}
        };

        public void Render()
        {
            var defaultColor = Console.ForegroundColor;
            for (int y = 0; y < tiles.GetLength(1); y++)
            {
                for (int x = 0; x < tiles.GetLength(0); x++)
                {
                    if (tiles[y, x] == 1)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write('\u25cf');
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ForegroundColor = defaultColor;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Map map = new Map();
                map.Render();
            }


            // 비규칙적 배열
            int[][] a = new int[2][];   // 두번째거 안채우는 이유는, 유동적으로 사이즈가 정해질 수 있기 때문. 
        }
    }
}
