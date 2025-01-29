using System;

class Hoeses
{

    const int playLength = 100;
    const int N = 30;
    const int M = 30;

    static Random rnd = new Random();

    static string[,] map = new string[N, M];

    static void Gen()
    {
        for (int y = 0; y < map.GetLength(0); y++)
        {
            for (int x = 0; x < map.GetLength(1); x++)
            {
                map[y, x] = " ";
                int srnd = rnd.Next(0, 2);
                if (y == 0 && srnd == 1)
                {
                    map[y, x] = "*";
                }
                map[y, x] = "X";
            }
        }
    }
    static void Fall()
    {
        string[,] New = map.Clone() as string[,];
        for (int i = 0; i < playLength; i++)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    if(map[y,x] == "*"){
                        New[y+1,x] = "*";
                        map[y,x] = " ";
                    }
                }
                
            }
        }
    }
    static void Draw()
    {
        for (int y = 0; y < map.GetLength(0)-1; y++)
        {
            //Console.SetCursorPosition(0, y);
            for (int x = 0; x < map.GetLength(1)-1; x++)
            {

                Console.Write(map[y, x]);
            }
            //Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        //Console.SetWindowSize(M + 1, N + 1);
        Gen();
        for (int i = 0; i < playLength; i++)
        {
            Draw();
            Fall();
        }
    }
}