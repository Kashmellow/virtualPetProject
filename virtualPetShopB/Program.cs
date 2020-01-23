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

                    //Console.WriteLine("What will you name your new cat?");
                    //string firstCatName = Console.ReadLine();

                    //Console.WriteLine("What color will your cat be?");
                    //string firstCatColor = Console.ReadLine();

                    //Console.WriteLine("How many years old is the cat?");
                    //Console.WriteLine("The age between 1 to 9 ");
                    //int firstCatAge = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine("Cats can have nine lives, how many will yours have?");
                    //int firstCatLives = Convert.ToInt32(Console.ReadLine());
                
                    
                do
                {
                    Console.WriteLine("Main_Menu \n");
                    Console.WriteLine("Press ( 1 ) if you like to play with " + cat.Name);
                    Console.WriteLine("Press ( 2 ) if you like to Feed " + cat.Name);
                    Console.WriteLine("Press ( 3 ) if you like to go to the Dr ");
                    Console.WriteLine("Press ( 4 ) if you like to check the Status ");
                    Console.WriteLine("Press ( 5 ) if you like to Exit ");
                    //add option to add another cat 
                    usingProgram = Console.ReadLine();
                    cat.MainMenu(usingProgram);
                } while (usingProgram != "5");
                

            }

        }
    }
}
