using System;

namespace ExerciceJ1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           /* algo1 algo = new algo1();
           int value = algo.Create_Value();
            algo.SolveExercice(value);
            Tableur algory1 = new Tableur();
            int n = algory1.Choose_n();
            int[] tableau = algory1.Create_Tab(n);
            algory1.AddContenuToTab(tableau); 
            Tableur2 algory2 = new Tableur2();
            int n1 = algory2.Choose_n();
            int[] tableau2 = algory2.Create_Tab(n1);
            algory2.AddContenuToTab(tableau2);*/
           TimeExercice algoT = new TimeExercice();
           string time = algoT.ChooseTime();
           int valeurInitial = algoT.valueTime();
           string time2 = algoT.Choose_convert_time();
           algoT.Calcul(time, time2, valeurInitial);
           valeurInitial = algoT.SecondToMinuteOrMinuteToHeure( valeurInitial);
           valeurInitial = algoT.HeureToMinuteOrMinuteToSeconde( valeurInitial);
           valeurInitial = algoT.SecondToHeure(valeurInitial);
           valeurInitial = algoT.HeureToSeconde(valeurInitial);
           algoT.FromSeconde( time2, valeurInitial);
           algoT.FromMinute( time2, valeurInitial);
           algoT.FromHeure( time2, valeurInitial);
        }
    }
}