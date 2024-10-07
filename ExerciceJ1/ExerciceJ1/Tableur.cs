using System;

namespace ExerciceJ1
{
    public class Tableur
    {
        public int Choose_n()
        {
            Console.Write("Veuillez entrer une valeur n : ");
            int n = int.Parse(Console.ReadLine());
            return n;
        }

        public int [] Create_Tab(int n)
        {
            int[] tableau = new int[n];
            return tableau;
        }

        public void AddContenuToTab(int[]tableau)
        {
           /* for(int i =0; i< tableau.Length; i++ )
            {
                tableau[i] = tableau.Length - i;
                Console.WriteLine(tableau[i]);
               
            }
            */
           int v = 0;
           foreach (int element in tableau)
           {
               
               tableau[v] = tableau.Length - v;
               Console.WriteLine(tableau[v]);
               v = v + 1;
           } 
           
        }
        
    }
}