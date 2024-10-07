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
            
                
            }

        public void SecondToMinuteOrMinuteToHeure(int valeurInitial)
        {
            valeurInitial = valeurInitial / 60;  
        }
        public void HeureToMinuteOrMinuteToSeconde(int valeurInitial)
        {
            valeurInitial = valeurInitial * 60;  
        }
        public void SecondToHeure(int valeurInitial)
        {
            valeurInitial = valeurInitial / 3600;  
        }
        public void HeureToSeconde(int valeurInitial)
        {
            valeurInitial = valeurInitial * 3600;  
        }

        public void FromSeconde(string time, string time2, int valeurInitial)
        {
            if (time2 =="minute")
            {
                SecondToMinuteOrMinuteToHeure();
                
            }
            if (time2 =="heure")
            {
                HeureToSeconde();
            }
        }
    } 
        
        
        
        
    }
