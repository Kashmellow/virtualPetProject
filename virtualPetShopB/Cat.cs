using System;
using System.Collections.Generic;
using System.Text;

namespace virtualPetShopB
{

    public class Cat : VirtualPetShelter
    {
        public List<Cat> myPets = new List<Cat>();

        public void SetPet()
        {
            myPets.Add(new Cat());

            int count = myPets.Count - 1;
            myPets[count].Name = Name;

            myPets[count].FurColor = FurColor;

            myPets[count].Age = Age;

            myPets[count].Lives = Lives;

            myPets[count].Id += myPets.Count;

            myPets[count].Hunger = 3;

            myPets[count].Boredom = 9;

            myPets[count].Health = 1;


        }

        public Cat()
        {

        }

        public void ViewInfo()
        //move to new virtualpetshelter class
        {
            Console.WriteLine("|   I D   |  | Cat Name |  | Cat Color |");
            foreach (Cat cat in myPets)
            {

                Console.WriteLine("    " + cat.Id +   "       " + cat.Name +    "         " + cat.FurColor);

            }
        }

        public void CheckLevelsNumber()
        {
            foreach (Cat cat in myPets)
            {
                if (cat.Health > 9) cat.Health = 9;
                if (cat.Health < 1) cat.Health = 1;

                if (cat.Boredom > 9) cat.Boredom = 9;
                if (cat.Boredom < 1) cat.Boredom = 1;

                if (cat.Hunger > 9) cat.Hunger = 9;
                if (cat.Hunger < 1) cat.Hunger = 1;
            }
        }
        public void ExitProgram()
        {
            Console.WriteLine("Come back later. Bye!");
            Environment.Exit(0);
        }
        public void EditInfo()
        {
            Console.WriteLine(" Press ( 1 ) to edit the cat info:  ");
            Console.WriteLine(" Press ( 2 ) to remove the cat: ");

            string editInformation = Console.ReadLine();

            ViewInfo();
            Console.WriteLine("write the number next to the cat you would like to edit:");
            int catIdNumber = Convert.ToInt32(Console.ReadLine());

            if (editInformation == "1")
            {
                for (int i = 0; i < myPets.Count; i++)
                {
                    if (myPets[i].Id == catIdNumber)
                    {
                        Console.Write("What will you name your new cat?   ");
                        myPets[i].Name = Console.ReadLine();

                        Console.Write("What color will your cat be?   ");
                        myPets[i].FurColor = Console.ReadLine();

                        Console.Write("How many years old is the cat?  ");
                        myPets[i].Age = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Cats can have nine lives, how many lives will yours have?   ");
                        myPets[i].Lives = Convert.ToInt32(Console.ReadLine());
                        ViewInfo();

                    }
                    CheckLevelsNumber();
                }
            }

            else if (editInformation == "2")
            {
                for (int i = 0; i < myPets.Count; i++)
                {
                    if (myPets.Count == 1)
                        myPets.Clear();

                    else if (myPets[i].Id == catIdNumber)
                    {
                        myPets.RemoveAt(catIdNumber);
                        ViewInfo();
                    }
                }
            }
                }

        public void PlayWithCat()
        {
            for (int i = 0; i < myPets.Count; i++)
            {
                myPets[i].Health += 1;
                myPets[i].Hunger -= 4;
                myPets[i].Boredom -= 2;

                CheckLevelsNumber();
            }
        }


        public void PlayWithSpecificCat()
                {
                    Console.WriteLine("Press the number of the cat to play with on this list");
                    ViewInfo();
                    int userChoice = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < myPets.Count; i++)
                    {
                        if (myPets[i].Id == userChoice)
                        {
                            myPets[i].Health += 2;
                            myPets[i].Hunger += 3;
                            myPets[i].Boredom -= 3;

                        }
                        CheckLevelsNumber();
                    }
                }

                public void FeedSpecificCat()
                {
                    Console.Write("Press the number for the cat you would like to feed:   ");
                    ViewInfo();
                    int userChoice = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < myPets.Count; i++)
                    {
                        myPets[i].Health += 2;
                        myPets[i].Hunger += 3;
                        myPets[i].Boredom -= 3;
                    }
                    CheckLevelsNumber();
                }

            
   
            public void GoToDr()
            {
                for (int i = 0; i < myPets.Count; i++)
                {
                    myPets[i].Health += 4;
                    myPets[i].Boredom += 2;

                    CheckLevelsNumber();
                }
            }

            public void FeedCat()

            {
                for (int i = 0; i < myPets.Count; i++)
                {
                    myPets[i].Health += 1;
                    myPets[i].Hunger -= 4;
                    myPets[i].Boredom -= 2;

                    CheckLevelsNumber();
                }
            }


            


            public void CheckStatus()
            {
                foreach (Cat cat in myPets)
                {



                    CheckLevelsNumber();

                    Console.WriteLine("The Status levels between [1 to 9] \n");

                    Console.WriteLine("\n");
                    Console.WriteLine("The hunger level for " + " " + cat.Name + " is " + cat.Hunger);

                    Console.WriteLine("\n");
                    Console.WriteLine("The boredom level for " + " " + cat.Name + " is " + cat.Boredom);

                    Console.WriteLine("\n");
                    Console.WriteLine("The Health level for " + " " + cat.Name + " is " + cat.Health);
                }
            }







        }

    


   }
