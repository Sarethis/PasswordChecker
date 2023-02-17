using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string upperLettersS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerLettersS = upperLettersS.ToLower();
            string numbersS = "0123456789";
            string specialS = "~!@#$%^&*()";
            Console.WriteLine("Witaj w sprawdzaczu siły hasła!");
            Console.WriteLine("Hej, podaje swoje hasło do analizy: ");
            var passwordInput = Console.ReadLine();
            bool upperLetters = false, lowerLetters = false, numbers = false , specialChars = false, passwordLenght = false;
            string passwordLenghtS = null;
            int passwordSrenght = 0;

            foreach (char letter in passwordInput)
            {
                Console.WriteLine(letter);
                if (upperLettersS.Contains(letter))
                    upperLetters = true;
                if (lowerLettersS.Contains(letter))
                    lowerLetters = true;
                if (numbersS.Contains(letter))
                    numbers = true;
                if (specialS.Contains(letter))
                    specialChars = true;
                if (passwordInput.Length >= 8)
                    passwordLenght = true;
            }

            if (upperLetters == true)
                passwordSrenght++;
            if (lowerLetters == true)
                passwordSrenght++;
            if (numbers == true) 
                passwordSrenght++;
            if (specialChars == true)
                passwordSrenght++;
            if (passwordLenght == true)
                passwordLenghtS = "Hasło jest odpowiednio długie.";
            else
                passwordLenghtS = "Hasło jest za krótkie.";


            Console.WriteLine("Punkty zdobyte przez hasło: " + passwordSrenght);

            switch (passwordSrenght)
            {
                case 1: Console.WriteLine("Twoje hasło jest słabe. " + passwordLenghtS); break;
                case 2: Console.WriteLine("Twoje hasło jest średnie. " + passwordLenghtS); break;
                case 3: Console.WriteLine("Twoje hasło jest silne. " + passwordLenghtS); break;
                case 4: Console.WriteLine("Twoje hasło jest bardzo mocne. " + passwordLenghtS); break;
            }

        }
    }
}
