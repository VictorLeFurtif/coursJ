using System;

namespace ExerciceJ1
{
    public class Tableur2
    {
        public int Choose_n()
        {
            Console.Write("Veuillez entrer une valeur n : ");
            int n1 = int.Parse(Console.ReadLine());
            return n1;
        }

        public int [] Create_Tab(int n1)
        {
            int[] tableau2 = new int[n1];
            return tableau2;
        }

        public void AddContenuToTab(int[]tableau2)
        {
            /* for(int i =0; i< tableau.Length; i++ )
             {
                 tableau[i] = tableau.Length - i;
                 Console.WriteLine(tableau[i]);

             }
             */
            int v = tableau2.Length -1;
            foreach (int element in tableau2)
            {
               
                tableau2[v] = tableau2.Length - v;
                Console.WriteLine(tableau2[v]);
                v = v - 1;
            } 
           
        }
        
    }
}