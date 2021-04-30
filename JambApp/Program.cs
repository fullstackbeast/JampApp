using System;

namespace JambApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Registration registration = new Registration();

            bool continueReg = true;

            while (continueReg)
            {
                Aspirant aspirant = registration.Register();
                
                Console.WriteLine(aspirant.RegistrationNumber);
                
                Console.Write("Do you want to continue(y/n): ");
                string answer = Console.ReadLine().ToLower().Trim();

                if (answer == "n") continueReg = false;

            }
        }
    }
}
