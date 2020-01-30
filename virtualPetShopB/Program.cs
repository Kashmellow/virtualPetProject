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

            Console.WriteLine("     ^   ^  ");
            Console.WriteLine("    ( o.o ) ");
            Console.WriteLine("     > ^ <  ");
            Console.WriteLine("Welcome to the shelter! Which type of cat would you like to add?  \n");
            Console.WriteLine("Press ( 1 ) if you would like to add a robotic cat");
            Console.WriteLine("Press ( 2 ) if you would like to add an organic cat");
            Console.WriteLine("Press ( 3 ) if you're not a cat a person and want to leave \n");

            String userOption = Console.ReadLine();
            Console.WriteLine("");
            switch (userOption)
            {
                case "1":
                    cat = new RoboticCat(5, 1);
                    cat.CreatePet();
                    shelter.myPets.Add(cat);
                    break;

                case "2":
                    cat = new OrganicCat(5, 1);
                    cat.CreatePet();

                    shelter.myPets.Add(cat);
                    break;

                case "3":
                    cat.ExitProgram();
                    break;

                default:
                    break;

            }



          //  if (userOption ==1)
          //  {
          //      cat = new RoboticCat(5, 1);
          //      cat.CreatePet();
          //      shelter.myPets.Add(cat);

                        //  }

                        //else  if (userOption == 2)
                        //  {
                        //      cat = new OrganicCat(5, 1);
                        //      cat.CreatePet();
                        //      shelter.myPets.Add(cat);


                        //  }

                        //  else if (userOption == 3)
                        //  cat.ExitProgram();


            //        else
            //{
                string userChoice = "0";
                //// cat = cat.SelectCatType();
                //cat.CreatePet();
                //shelter.myPets.Add(cat);
                    
                do
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("             Main Menu     ");
                    Console.WriteLine("               ^   ^       ");
                    Console.WriteLine("              ( o.o )      ");
                    Console.WriteLine("               > ^ <       ");
                    Console.WriteLine("Press ( 1 ) if you would like to add a robotic cat");
                    Console.WriteLine("Press ( 2 ) if you would like to add an organic cat");
                    Console.WriteLine("Press ( 3 ) if you would like to view all cat info");
                    Console.WriteLine("Press ( 4 ) to play with all of the cats");
                    Console.WriteLine("Press ( 5 ) to play with a specific cat");
                    Console.WriteLine("Press ( 6 ) to feed all of the cats");
                    Console.WriteLine("Press ( 7 ) to feed one of the cats");
                    Console.WriteLine("Press ( 8 ) to take the all cats to doctor");
                    Console.WriteLine("Press ( 9 ) to take one cat to the doctor");
                    Console.WriteLine("Press ( 10 ) to check the status ");
                    Console.WriteLine("Press ( 11 ) if you would like to adopt a cat  ");
                    Console.WriteLine("Press ( 12 ) if you'd like to exit ");
                    userChoice = Console.ReadLine();

                    switch(userChoice)
                    {
                        case "1":
                            cat = new RoboticCat(5,1);
                            cat.CreatePet();
                            shelter.myPets.Add(cat);
                            break;

                        case "2":
                            cat = new OrganicCat(5,1);
                            cat.CreatePet();
                            
                            shelter.myPets.Add(cat);
                            break;
                                                  
                        case "3":
                            shelter.ViewInfoAll();
                            break;

                        case "4":
                            shelter.PlayWithAllCats();
                            break;

                        case "5":
                            cat = shelter.ChoosePet();
                            cat.PlayWithCat();
                            break;

                        case "6":
                            shelter.FeedCat();
                            break;

                        case "7":
                            cat = shelter.ChoosePet();
                            cat.FeedSpecificCat();
                            break;

                        case "8":
                            shelter.GoToDrAll();
                            break;

                        case "9":
                            cat = shelter.ChoosePet();
                            cat.GoToDr();
                            break;

                        case "10":
                            shelter.CheckStatusAll();
                            break;

                        case "11":
                            shelter.AdoptCat();
                            break;

                        case "12":
                            cat.ExitProgram();
                            break;

                        default:
                            break;
                    }

                    
                } while (userChoice != "12");
                

            }

        }
       
    }

