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
        }
    }
}