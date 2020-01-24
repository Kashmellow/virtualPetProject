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
                cat.PlayWithCat();
                cat.CreateCat();
                cat.PlayWithCat();
                cat.PrintValue();
 
                
                    
                do
                {
                    Console.WriteLine("Main_Menu \n");
                    Console.WriteLine("Press ( 1 ) if you would like to add another cat");
                    Console.WriteLine("Press ( 2 ) if you like to play with " + cat.Name);
                    Console.WriteLine("Press ( 3 ) if you like to Feed " + cat.Name);
                    Console.WriteLine("Press ( 4 ) if you like to go to the Dr ");
                    Console.WriteLine("Press ( 5 ) if you like to check the Status ");
                    Console.WriteLine("Press ( 6 ) if you like to Exit ");
                  
                    usingProgram = Console.ReadLine();
                    cat.MainMenu(usingProgram);
                } while (usingProgram != "6");
                

            }

        }
    }
}
