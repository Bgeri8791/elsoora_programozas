using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elsoora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Összegzés tétel:
            int osszeg = 0;
            int[] tomb = new int[] { 1, 6, 32, 65, 10 };
            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg = osszeg + tomb[i];kbjk
            }
            Console.WriteLine("A tömb összege: " + osszeg);
            Console.ReadLine();
            */
            /*//Eldöntés tétele:
            int i = 0;
            bool van = false;
            int[] tomb = new int[] { 23,43,-2,3,2 };
            while (i <= tomb.Length && !(tomb[i] > 0)) 
            {
                i++;
            }
            if (i<= tomb.Length)
            {
                van = true;
            }
            */
            /*
            int i = 0;
            int idx = 0;
            bool van = false;
            int[] tomb = new int[] { 23, 43, -2, 3, 2 };
            while (i <= tomb.Length && !(tomb[i] % 2 == 0))
            {
                i++;
            }
            idx = i;
            if (i > tomb.Length)
            {
                van = false;
            }
            else 
            {
                van = true;
                Console.WriteLine("Van ilyen elem a tömbben, és indexe "+idx);
                Console.ReadLine();
            }*/
            /*
            //Megszámlálás tétel:
            int db = 0;
            int[] tomb = new int[] { 23, 43, 31, 3, 41 };
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]%2 == 0)
                {
                    db++;
                }
                
            }
            Console.WriteLine("Ennyi 2-vel osztható szám van a tömbben: "+db);
            Console.ReadLine();
            */
            /*
            int db = 0;
            string[] tomb = new string[] {"alma","sárgaalma","körte","zöldalma"};
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i].Contains("alma"))
                {
                    db++;
                }

            }
            Console.WriteLine("Ennyi 'alma' szó van a tömbben: " + db);
            Console.ReadLine();
            */
            /*
            //Maximum kiválasztás tétel:
            int[] tomb = new int[] {10,2003,300, 43,587};
            int max = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > tomb[max])
                {
                    max = i;
                }
            }
            Console.WriteLine("A legnagyobb érték a tömbben: "+tomb[max]);
            Console.WriteLine("A legnagyobb érték indexxe a tömbben: "+max);
            Console.ReadLine();
            */
            //Másolás programozás tétel:
            int[] tomb = new int[] { 10, 2003, 300, 43, 587 };
            int[] tomb2 = new int[tomb.Length];
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb2[i] = tomb[i]*2;
            }
            Console.WriteLine("A tömb elemei:");
            for (int i = 0; i < tomb.Length; i++)
            {
                
                Console.Write(tomb[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("A tömb2 elemei:");
            for (int y = 0; y < tomb2.Length; y++)
            {
                Console.Write(tomb2[y] + " ");
            }
            Console.WriteLine();
        }
    }
}
