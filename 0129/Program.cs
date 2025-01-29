using System;

class Jegtablak
{
    const int N = 30;
    const int M = 15;
    const int K = 5;
    static char[,] palya = new char[N, M];

    static void JegGen()
    {
        Random rnd = new();
        for (int x = 0; x < palya.GetLength(1); x++)
        {
            for (int y = 0; y < palya.GetLength(0); y++)
            {
                int jegRNG = rnd.Next(0, 30);
                if(jegRNG == 1){
                    palya[y, x] = 'J';
                }
            }
        }
    }
    
    static void Fagyas(){
        Random rnd = new();
        /*
        for (int x = 0; x < palya.GetLength(1); x++)
        {
            for (int y = 0; y < palya.GetLength(0); y++)
            {   
                int jegRNG = rnd.Next(1, 4);
                if(palya[y, x] == 'J'){
                    if(jegRNG == 1 && palya[y+1, x] == 'V' && y < N-1){
                        palya[y+1, x] = 'J';
                    }
                    else if(jegRNG == 2 && palya[y-1, x] == 'V' && y > 1){
                        palya[y-1, x] = 'J';
                    }
                    else if(jegRNG == 3 && palya[y, x+1] == 'V' && x < M-1){
                        palya[y, x+1] = 'J';
                    }
                    else if(jegRNG == 4 && palya[y, x-1] == 'V' && x < 1){
                        palya[y, x-1] = 'J';
                    }
                }
            }
        }
        */
        


    }

    static void General()
    {
        for (int x = 0; x < palya.GetLength(1); x++)
        {
            for (int y = 0; y < palya.GetLength(0); y++)
            {
                palya[y, x] = 'V';
            }
        }
    }

    static void PalyaRajz()
    {
        for (int x = 0; x < palya.GetLength(1)-1; x++)
        {
            for (int y = 0; y < palya.GetLength(0)-1; y++)
            {
                Console.Write(palya[y, x]);
            }
            Console.WriteLine();
        }
        System.Console.WriteLine();
    }

    static void Main()
    {
        int SzimulacioH = 10;
        Console.SetWindowSize(N, M);
        General();
        JegGen();
        PalyaRajz();
        for (int i = 0; i < SzimulacioH; i++)
        {
            Fagyas();
            PalyaRajz();
        }
        Console.ReadLine();
    }
}