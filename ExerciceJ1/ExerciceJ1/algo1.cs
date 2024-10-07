using System;
using System.Runtime.Remoting.Messaging;

namespace ExerciceJ1
{
    public class algo1
    {
        public int Create_Value()
        {
            Console.Write("Veuillez entrer une valeur entre 6 et 874 : ");
            int value = int.Parse(Console.ReadLine());
            return value;
        }

        public void SolveExercice(int value)
        {
            if (value > 6 || value < 874)
            {
                for (int i = 6; i < value; i++)
                {
                    if (CheckMultiple(i))
                    {
                        Console.Write(i + " ");
                        Console.WriteLine();
                    }
                }
            }
        }

        public bool CheckMultiple(int i)
        {
            bool hasMultiple = false;
            
            if (i % 3 == 0 || i % 4 == 0)
            {   
                Console.Write("C ");
                hasMultiple = true;
            }

            if (i % 7 == 0 || i % 18 == 0)
            {
                Console.Write("A ");
                hasMultiple = true;
            }

            if (i % 42 == 0)
            {
                Console.Write("CA ");
                hasMultiple = true;            }

            return hasMultiple;
        }
        
        
    }
}