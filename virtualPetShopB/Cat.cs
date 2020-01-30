using System;
using System.Collections.Generic;
using System.Text;



namespace virtualPetShopB
{

    public class Cat
    {
        

        public string Name { get; set; }
        public string FurColor { get; set; }
        public int Age { get; set; }
        public int Lives { get; set; }
        
        public int Boredom { get; set; }
       public int HungerNeedFuel { get; set; }
       public int HealthMaintenanceCondition { get; set; }
        

        
        public Cat()
        {
           
            
            Boredom = 9;
        }

        public Cat(int X ,int Y)
        {
            HungerNeedFuel = X;
            HealthMaintenanceCondition = Y;
            Boredom = 9;
           
        }
       
        public void ExitProgram()
        {
            Console.WriteLine("Come back later. Bye!");
            Environment.Exit(0);
        }

        public void CreatePet()
        {
     //       OrganicCat cat = new OrganicCat();
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



        public virtual  void PlayWithCat()
        {

           
            Boredom -= 3;

        }

        public virtual void FeedSpecificCat()
        {
            Boredom -= 3;
        }


        public virtual void GoToDr()
        {
               Boredom -= 2;
        }







    }
}
    


