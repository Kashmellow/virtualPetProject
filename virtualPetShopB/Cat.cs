using System;
using System.Collections.Generic;
using System.Text;



namespace virtualPetShopB
{

    public class Cat
    {
        VirtualPetShelter pet = new VirtualPetShelter();

        public string Name { get; set; }
        public string FurColor { get; set; }
        public int Age { get; set; }
        public int Lives { get; set; }
        public int Hunger { get; set; }
        public int Health { get; set; }
        public int Boredom { get; set; }

        public Cat()
        {

        }
        public void ExitProgram()
        {
            Console.WriteLine("Come back later. Bye!");
            Environment.Exit(0);
        }

        public void CreatePet()
        {
            Console.Write("What will you name your new cat?    ");
            string newCatName = Console.ReadLine();

            Name = newCatName;

            Console.Write("What color will your cat be?    ");
            string newCatColor = Console.ReadLine();

            FurColor = newCatColor;


            Console.Write("How many years old is the cat?   ");
            int newCatAge = Convert.ToInt32(Console.ReadLine());

            Age = newCatAge;

            Console.Write("Cats can have nine lives, how many will yours have?    ");

            int newCatLives = Convert.ToInt32(Console.ReadLine());

            Lives = newCatLives;

        }

        public void CheckLevelsNumber()
        {
            //foreach (Cat cat in pet.myPets)

            if (Health > 9) Health = 9;
            if (Health < 1) Health = 1;

            if (Boredom > 9) Boredom = 9;
            if (Boredom < 1) Boredom = 1;

            if (Hunger > 9) Hunger = 9;
            if (Hunger < 1) Hunger = 1;

        }

        /*  public void EditInfo()
          {
              Console.WriteLine(" Press ( 1 ) to edit the cat info:  ");
              Console.WriteLine(" Press ( 2 ) to remove the cat: ");

              string editInformation = Console.ReadLine();

              pet.ViewInfo();
              Console.WriteLine("write the number next to the cat you would like to edit:");
              int catIdNumber = Convert.ToInt32(Console.ReadLine());

              if (editInformation == "1")
              {
                  for (int i = 0; i < pet.myPets.Count; i++)
                  {
                      if (pet.myPets[i].Id == catIdNumber)
                      {
                          Console.Write("What will you name your new cat?   ");
                         pet.myPets[i].Name = Console.ReadLine();

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
                  */



        public void PlayWithCat()
        
            
        {
            
            Health += 2;
            Hunger += 3;
            Boredom -= 3;
        }


        //public void PlayWithSpecificCat()
        //{
        //    Console.WriteLine("Press the number of the cat to play with on this list");
        //    pet.ViewInfo();
        //    int userChoice = Convert.ToInt32(Console.ReadLine());



        //    pet.myPets[userChoice - 1].Health += 2;
        //    pet.myPets[userChoice - 1].Hunger += 3;
        //    pet.myPets[userChoice - 1].Boredom -= 3;


        //    CheckLevelsNumber();

        //}

        public void FeedSpecificCat()
        {
            Health += 2;
            Hunger += 3;
            Boredom -= 3;
            CheckLevelsNumber();
        }

        public void CheckStatus()
        {

            CheckLevelsNumber();

            Console.WriteLine("The Status levels between [1 to 9] \n");

            Console.WriteLine("\n");
            Console.WriteLine("The hunger level for " + " " + Name + " is " + Hunger);

            Console.WriteLine("\n");
            Console.WriteLine("The boredom level for " + " " + Name + " is " + Boredom);

            Console.WriteLine("\n");
            Console.WriteLine("The Health level for " + " " + Name + " is " + Health);

        }

        public void GoToDr()
        {
               Health += 4;
               Boredom += 2;

               CheckLevelsNumber();
        }







    }
}
    


