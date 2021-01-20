using System;

namespace Menghi.Massimo._4H.Orario
{
    class Program
    {
        static void Main(string[] args)
        {
            Orario Partenza = new Orario(8, 100, 65);
            Orario Arrivo = new Orario(11, 70, 58);
            Partenza.Correggi();
            Arrivo.Correggi();
            Console.Write("Orario di partenza: ");
            Console.WriteLine("\n" + Partenza.Out());
            Console.WriteLine("Orario di arrivo: ");
            Console.WriteLine(Arrivo.Out());
            Console.WriteLine(Partenza.Tempo(Partenza, Arrivo));

        }
    }

    class Orario
    {

        public int O
        {
            get;
            set;
        }

        public int M
        {
            get;
            set;
        }

        public int S
        {
            get;
            set;
        }

        public Orario(int ore, int minuti, int secondi)
        {
            O = ore;
            M = minuti;
            S = secondi;
        }

        public void Mod(int ore, int minuti, int secondi)
        {
            O = ore;
            M = minuti;
            S = secondi;
        }

        public void Correggi()
        {
            while (M >= 60)
            {
                if (M >= 60)
                {
                    O++;
                    M -= 60;
                }
            }

            while (S >= 60)
            {
                if (S >= 60)
                {
                    M++;
                    S -= 60;
                }
            }

        }

        public string Tempo(Orario Partenza, Orario Arrivo)
        {
            M = Partenza.O * 60 + Partenza.M;
            O = Arrivo.O * 60 + Arrivo.M;
            O -= M;
            S = Arrivo.S - Partenza.S;


            M = 0;
            while (O >= 60)
            {
                O -= 60;
                M++;
            }
            return $"Tempo totale viaggio: {M.ToString()}:{O.ToString()}:{S.ToString()}";
        }

        public string Out()
        {
            return $"{O.ToString()}:{M.ToString()}:{S.ToString()}";
        }
    }
}