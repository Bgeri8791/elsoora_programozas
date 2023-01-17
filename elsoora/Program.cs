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
            Console.WriteLine("Ennyi darab megfelelő elem van: " + db);
            */
            /*
            int db = 0;
            string[] tomb = new string[] { "alma","zöldalma","körte","sárgaalma"};
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i].Contains("alma"))
                {
                    db++;
                }

            }
            Console.WriteLine("Hány 'alma' szó szerepel a tömbben: " + db);
            Console.ReadLine();
            */
        }
    }
}
