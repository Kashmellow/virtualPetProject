using System;

namespace virtualPetShopB
{
    class Program
    {
        public static object Exit { get; private set; }
        static void Main(string[] args)
        {
            Cat cat = new Cat();

            Console.WriteLine("Would you like to add a cat to the shelter?  \n" +
                 "press 1 if you would like to add a cat \n" +
                 "press 2 if you don't want to");
            int userOption = Convert.ToInt32(Console.ReadLine());

            if (userOption == 2)
            cat.ExitProgram();


            else
            {
                string usingProgram = "0";

                cat.CreateCat();
               

                    
                do
                {
                    Console.WriteLine("Main_Menu \n");
                    Console.WriteLine("Press ( 1 ) if you would like to add another cat");
                    Console.WriteLine("Press ( 2 ) if you would like to view cat info");
                    Console.WriteLine("Press ( 3 ) to play with the cats");
                    Console.WriteLine("Press ( 4 ) to feed the cats");
                    Console.WriteLine("Press ( 5 ) to take the cats to doctor");
                    Console.WriteLine("Press ( 6 ) to check the Status ");
                    Console.WriteLine("Press ( 7 ) if you'd like to Exit ");
                  
                    usingProgram = Console.ReadLine();
                    cat.MainMenu(usingProgram);
                } while (usingProgram != "7");
                

            }

        }
    }
}
