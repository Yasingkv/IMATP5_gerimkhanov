using System;

namespace IMATP5_gerimkhanov
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix;
            int nb1;
            int n;
            int nb;
            nb1 = 0;
            nb = 0;
            int[,] m;
            string stringTab;

            traitementOutils mesOutils = new traitementOutils();
            do
            {
                mesOutils.LireReel("voici le tableau de pascal  \n   1 = tableau de pascal \n  ", out choix);

                if (choix == 1)
                {
                    mesOutils.LireReel("le coefficient :", out n);
                    mesOutils.matrice(nb, nb1, n, out m);
                    mesOutils.String_Tableau(m, out stringTab);


                }
                
            } while (true);
        }
    }
}
