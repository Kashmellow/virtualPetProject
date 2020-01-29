using System;

namespace virtualPetShopB
{
    class Program
    {
       
        public static object Exit { get; private set; }
        
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            VirtualPetShelter shelter = new VirtualPetShelter();

            Console.WriteLine("Would you like to add a cat to the shelter?  \n" +
                 "press 1 if you would like to add a cat \n" +
                 "press 2 if you don't want to");
            int userOption = Convert.ToInt32(Console.ReadLine());

            if (userOption == 2)
            cat.ExitProgram();


            else
            {
                string userChoice = "0";

                cat.CreatePet();
                shelter.myPets.Add(cat);
                    
                do
                {
                    Console.WriteLine("Main_Menu \n");
                    Console.WriteLine("Press ( 1 ) if you would like to add another cat");
                    Console.WriteLine("Press ( 2 ) if you would like to view all cat info");
                    Console.WriteLine("Press ( 3 ) to play with all of the cats");
                    Console.WriteLine("Press ( 4 ) to play with a specific cat");
                    Console.WriteLine("Press ( 5 ) to feed all of the cats");
                    Console.WriteLine("Press ( 6 ) to feed one of the cats");
                    Console.WriteLine("Press ( 7 ) to take the all cats to doctor");
                    Console.WriteLine("Press ( 8 ) to take one cat to the doctor");
                    Console.WriteLine("Press ( 9 ) to check the Status ");
                    Console.WriteLine("Press ( 10 ) if you would like to edit the info  ");
                    Console.WriteLine("Press ( 11 ) if you'd like to Exit ");
                    userChoice = Console.ReadLine();

                    switch(userChoice)
                    {
                        case "1":
                            cat = new Cat();
                            cat.CreatePet();
                            shelter.myPets.Add(cat);
                            Console.WriteLine(shelter.myPets.Count);
                            break;

                        case "2":
                            shelter.ViewInfoAll();
                            break;

                        case "3":
                            shelter.PlayWithAllCats();
                            break;

                        case "4":
                            cat = shelter.ChoosePet();
                            cat.PlayWithCat();
                            break;

                        case "5":
                            shelter.FeedCat();
                            break;

                        case "6":
                            cat = shelter.ChoosePet();
                            cat.FeedSpecificCat();
                            break;

                        case "7":
                            shelter.GoToDrAll();
                            break;

                        case "8":
                            cat = shelter.ChoosePet();
                            cat.GoToDr();
                            break;

                        case "9":
                            shelter.CheckStatusAll();
                            break;

                        case "10":
                       //     cat.EditInfo();
                            break;

                        case "11":
                            cat.ExitProgram();
                            break;

                        default:
                            break;
                    }

                    
                } while (userChoice != "11");
                

            }

        }
       
    }
}
