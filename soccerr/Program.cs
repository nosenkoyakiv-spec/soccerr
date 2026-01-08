using System;

namespace Soccer
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int a; int b;
            Random rnd = new Random();
            int squadraAgol = 0; int squadraBgol = 0;
            double chance = 2;
            int[] squadraA = { 50, 85, 45, 55, 70, 25, 45, 20, 45, 70 };
            int[] squadraB = { 50, 45, 85, 75, 75, 45, 40, 20, 45, 10 };
            int squadraa = 0;
            int squadrab = 0; // int a e int b serve per scegliere un giocatore a caso da ogni squadra, quindi vanno da 1 a 9 (perchè l'array parte da 0)

            for (int i = 0; i < 90; i++)
            {
                a = rnd.Next(1, 10);
                b = rnd.Next(1, 10);
                // qua scegliamo un giocatore a caso da ogni squadra
                squadraa = squadraA[a];
                squadrab = squadraB[b];




                double chancegol = rnd.Next(1, 101);

                if (chancegol > chance) // se il numero random è maggiore della chance non succede nulla
                {
                    continue;
                }
                else // altrimenti segna una delle due squadre
                {
                    if (squadraa > squadrab) // se il giocatore della squadra A ha una statistica maggiore segna la squadra A
                    {

                        squadraAgol++;
                    }
                    else // altrimenti segna la squadra B
                    {

                        squadraBgol++;
                    }
                }


            }
            Console.WriteLine("Goli: " + squadraBgol + " SquadraB " + squadraAgol + " SquadraA");


        }
    }
}

