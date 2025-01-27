using System;

class Hoeses{
    const int iksz = 50;
    const int ipszilon = 30;


    static string[,] map = new string[ipszilon, iksz];

    static void Gen(){
        for (int y = 0; y < map.GetLength(0); y++)
        {
            for (int x = 0; x < map.GetLength(1); x++)
            {
                map[y,x] = " ";
                if(y == ipszilon-1){
                    map[y,x] = "X";
                }
            }
        }
    }
    static void Gravity(){

    }
    static void Draw(){
        for (int y = 0; y < map.GetLength(0); y++)
        {
            for (int x = 0; x < map.GetLength(1); x++)
            {
                Console.Write(map[y, x]);
            }
            System.Console.WriteLine();
        }
    }
    static void Main(){
        Gen();
        Draw();
    }
}