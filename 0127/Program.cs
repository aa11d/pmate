using System;

class BillentyuzetValami
{
    const int N = 60;
    const int M = 30;

    static int[,] palya = new int[N, M]; // N oszlop M sor 

    static void KajaElhelyez(int db)
    {
        Random rnd = new(); // new Random(); - érdekes megoldás
        for (int i = 0; i < db; i++)
        {
            int kajax = rnd.Next(0, N);
            int kajay = rnd.Next(0, M);
            int kajaErtek = rnd.Next(5, 10);
            palya[kajax, kajay] = kajaErtek;
        }
    }
    static void KajaRajz()
    {
        for (int x = 0; x < N; x++)
        {
            for (int y = 0; y < M; y++)
            {
                if (palya[x, y] > 0)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(palya[x, y]);
                }
            }
        }
    }

    static void KajaFogy()
    {
        for (int x = 0; x < N; x++)
        {
            for (int y = 0; y < M; y++)
            {
                if (palya[x, y] > 0) palya[x, y]--;
                else if (palya[x, y] == 0)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(' ');
                }
            }
        }
    }

    static void Main()
    {
        Console.SetWindowSize(N, M);
        KajaElhelyez(30);
        KajaRajz();
        Console.SetCursorPosition(N / 2, M / 2);
        Console.Write('X');
        bool exit = false;
        int timer = 0;

        int babux = N / 2;
        int babuy = M / 2;
        int teleHas = 10;

        while (!exit)
        { //gaming
            timer++;

            Console.SetCursorPosition(0, 0);
            Console.Write(teleHas);

            if (timer % 50 == 0)
            {
                KajaFogy();
            }
            if (timer % 70 == 0)
            {
                teleHas--;
                if (teleHas == 0) exit = true;
            }
            
            KajaRajz();
            
            Thread.Sleep(100);  
            
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressed = Console.ReadKey(true);
                if (pressed.Key == ConsoleKey.Escape)
                {
                    exit = true;
                }
                else if (pressed.Key == ConsoleKey.UpArrow && babuy > 0)
                {
                    Console.SetCursorPosition(babux, babuy);
                    Console.Write(' ');
                    babuy--;
                    Console.SetCursorPosition(babux, babuy);
                    Console.Write("X");
                }
                else if (pressed.Key == ConsoleKey.DownArrow && babuy < M - 1)
                {
                    Console.SetCursorPosition(babux, babuy);
                    Console.Write(' ');
                    babuy++;
                    Console.SetCursorPosition(babux, babuy);
                    Console.Write("X");
                }
                else if (pressed.Key == ConsoleKey.LeftArrow && babux > 0)
                {
                    Console.SetCursorPosition(babux, babuy);
                    Console.Write(' ');
                    babux--;
                    Console.SetCursorPosition(babux, babuy);
                    Console.Write("X");
                }
                else if (pressed.Key == ConsoleKey.RightArrow && babux < N - 1)
                {
                    Console.SetCursorPosition(babux, babuy);
                    Console.Write(' ');
                    babux++;
                    Console.SetCursorPosition(babux, babuy);
                    Console.Write("X");
                }

                if (palya[babux, babuy] > 0)
                {
                    teleHas += palya[babux, babuy];
                    palya[babux, babuy] = 0;
                }
            }
        }


        Console.ReadKey();

    }
}