using System;

namespace ExerciceJ1
{
    public class TimeExercice
    {
        public string ChooseTime()
        {
            Console.Write("Veuillez choisir entre seconde, minute ou heure : ");
            string time = (Console.ReadLine());
            return time;
        }

        public int valueTime()
        {
            Console.Write("Veuillez entrer une valeur : ");
            int valeurInitial = int.Parse(Console.ReadLine());
            return valeurInitial;
        }

        public string Choose_convert_time()
        {
            Console.Write("Veuillez choisir entre seconde, minute ou heure pour votre conversion : ");
            string time2 = (Console.ReadLine());
            return time2;
        }

        public void Calcul(string time, string time2, int valeurInitial)
        {
            if (time == time2)
            {
                Console.Write("C'est la même");
            }

            if (time == "seconde")
            {
                FromSeconde(time2,valeurInitial);
            }
            if (time == "minute")
            {
                FromSeconde(time2,  valeurInitial);
            }
            if (time == "heure")
            {
                FromSeconde(time2, valeurInitial);
            }

        }

        public int SecondToMinuteOrMinuteToHeure(int valeurInitial)
        {
            valeurInitial = valeurInitial / 60;
            return valeurInitial;
        }

        public int HeureToMinuteOrMinuteToSeconde(int valeurInitial)
        {
            valeurInitial = valeurInitial * 60;
            return valeurInitial;
        }

        public int SecondToHeure(int valeurInitial)
        {
            valeurInitial = valeurInitial / 3600;
            return valeurInitial;
        }

        public int HeureToSeconde(int valeurInitial)
        {
            valeurInitial = valeurInitial * 3600;
            return valeurInitial;
        }

        public void FromSeconde(string time2, int valeurInitial)
        {
            if (time2 == "minute")
            {
                SecondToMinuteOrMinuteToHeure(valeurInitial);
                Console.Write(valeurInitial);
            }

            if (time2 == "heure")
            {
                HeureToSeconde(valeurInitial);
                Console.Write(valeurInitial);
            }
        }

        public void FromMinute(string time2, int valeurInitial)
        {
            if (time2 == "seconde")
            {
                HeureToMinuteOrMinuteToSeconde(valeurInitial);
                Console.Write(valeurInitial);
            }

            if (time2 == "heure")
            {
                SecondToMinuteOrMinuteToHeure(valeurInitial);
                Console.Write(valeurInitial);
            }


        }

        public void FromHeure(string time2, int valeurInitial)
        {
            if (time2 == "seconde")
            {
                HeureToSeconde(valeurInitial);
                Console.Write(valeurInitial);
            }

            if (time2 == "minute")
            {
                HeureToMinuteOrMinuteToSeconde(valeurInitial);
                Console.Write(valeurInitial);
            }
        }




    }
}
