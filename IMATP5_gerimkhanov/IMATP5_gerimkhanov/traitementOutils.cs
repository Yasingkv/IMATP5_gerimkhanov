using System;
using System.Collections.Generic;
using System.Text;

namespace IMATP5_gerimkhanov
{
    class traitementOutils
    {
        public void LireReel(string question, out int n)
        {
            string nUser;
            Console.Write(question);
            nUser = Console.ReadLine();
            while (!int.TryParse(nUser, out n))
            {
                Console.WriteLine("Attention ! vous devez taper un nombre réel !");
                nUser = Console.ReadLine();
            }
        }
        public void matrice(int nb,int nb1,int n, out int[,] m )
        {
            m = new int[n, n];
            for (int i = 0; i < n +1; i++)
            {
                nb1 = i;
                for (int j = 0; j < n +1; j++)
                {
                    nb = i + nb1;
                }
            }
        }
        
        public void String_Tableau(int[,] m, out string stringTab)
        {

            stringTab = "";
            for (int ligne = 0; n < m.GetLength(0); n++)
            {
                for (int n = 0; n < m.GetLength(1); n++)
                {
                    stringTab += m[n, n] + "  |  ";
                }
                stringTab += "\n";
            }


        }
        public void coefficients()
        {

            for (int i = 0; i < m.GetLength(0); i++)
            {
                nb2 = nb + a +^n
                nb2 = nb + "a" + ^"n"
                if (n == 0)
                {
                    nb2 = nb + a + b+^n
                    nb2 = nb + a + b + ^n -1
                }
                else
                {
                    ""
                }
            }
        }
    }
}
