using System;

namespace ExerciceJ1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            algo1 algo = new algo1();
           int value = algo.Create_Value();
            algo.SolveExercice(value);
            Tableur algory1 = new Tableur();
            int n = algory1.Choose_n();
            int[] tableau = algory1.Create_Tab(n);
            algory1.AddContenuToTab(tableau);
        }
    }
}