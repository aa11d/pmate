using System;

class Gaming{
    static int szelesseg = 80;

    static int[] map = new int[szelesseg];

    static double p = 0.5;

    static int[] BJ = [1, 3, 5, 6, 9];
    static int[] JB = [2, 4, 7, 8, 10];

    static void PalyaRajz(){
        for (int x = 0; x < szelesseg; x++)
        {
            if(map[x] == -1){
                Console.Write(' ');
            }
            else{
                Console.Write(map[x]%10);
            }
        }
        System.Console.WriteLine();
        System.Console.WriteLine("--------------------------------------------------------------------------------");
    }
    static void General(){
        for (int x = 0; x < szelesseg; x++)
        {
            map[x] = -1;        
        }
    }
    static void SpawnRNG(string irany){
        Random rnd = new Random();
        int szamRNG = rnd.Next(0, 5);
        int szam;
        if(irany == "balroljobb"){
            szam = BJ[szamRNG];
            if(map[0] == -1)
                map[0] = szam;
        
        }
        if(irany == "jobbrolbal"){
            szam = JB[szamRNG];
            if(map[szelesseg-1] == -1)
                map[szelesseg-1] = szam;
        }

    }
    static void Mozog(){
        for (int x = 0; x < szelesseg; x++)
        {
            if(map[x] != -1){
                if(BJ.Contains(map[x])){
                    
                }
            }
        }
    }
    static void Main(){
        Random rnd = new Random();
        General();
        PalyaRajz();
        int t = 0;
        while(! Console.KeyAvailable){
            Thread.Sleep(10);
            t++;
            PalyaRajz();
            if(map[79] == -1){
                double q = rnd.NextDouble();
                if(q < p){
                    SpawnRNG("jobbrolbal");
                }
            }
            if(map[0] == -1){
                double q = rnd.NextDouble();
                if(q < p){
                    SpawnRNG("balroljobb");
                }
            }
            
        }
        Console.ReadLine();
    }
}