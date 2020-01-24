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
        public int Hunger { get; set; }
        public int Health { get; set; }
        public int Boredom { get; set; }

        public Cat()
        {
            Hunger = 9;
            Boredom = 9;
            Health = 1;
        }

        List<Cat> myCats = new List<Cat>();

        public void CreateCat()
        {

            myCats.Add(new Cat());

            Console.WriteLine("What will you name your new cat?");
            string newCatName = Console.ReadLine();

            int count = myCats.Count - 1;

            myCats[count].Name = newCatName;
       

            Console.WriteLine("What color will your cat be?");
            string newCatColor = Console.ReadLine();

            myCats[count].FurColor = newCatColor;

            Console.WriteLine("How many years old is the cat?");
            Console.WriteLine("The age between 1 to 9 ");
            int newCatAge = Convert.ToInt32(Console.ReadLine());

            myCats[count].Age = newCatAge;

            Console.WriteLine("Cats can have nine lives, how many will yours have?");
            int newCatLives = Convert.ToInt32(Console.ReadLine());

            myCats[count].Lives = newCatLives;

            myCats[count].Hunger = 2;
            myCats[count].Boredom = 9;
            myCats[count].Health = 1;

            //Name = newCatName;
            //FurColor = newCatColor;
            //Age = newCatAge;
            //Lives = newCatLives;



        }

        public void PrintValue()
        {
            foreach (Cat cat in myCats)
            {
                Console.WriteLine(cat.Name + " " + cat.FurColor + " " + cat.Hunger);
            }
        }
        public void ExitProgram()
        {
            Console.WriteLine("Come back later if you change your mind. Bye!");
            Environment.Exit(0);
        }

        public void MainMenu(string user_selection)
        {


            switch (user_selection)
            {
                case "1":
                    CreateCat();
                    break;

                case "2":
                    PlayWithCat();
                    break;

                case "3":
                    FeedCat();
                    break;

                case "4":
                    GoToDr();
                    break;

                case "5":
                    CheckStatus();
                    break;

                case "6":
                    ExitProgram();
                    break;

                default:
                    break;
            }

        }
        public void PlayWithCat()
        {
            myCats[myCats.Count-1].Health += 2;
            myCats[myCats.Count-1].Hunger += 3;
            myCats[myCats.Count-1].Boredom -= 3;

            CheckLevelsNumber();
        }

        public void GoToDr()
        {
            Health += 4;
            Boredom += 2;

            CheckLevelsNumber();
        }
        public void FeedCat()
        {
            myCats[myCats.Count-1].Health += 1;
            myCats[myCats.Count-1].Hunger -=4;
            myCats[myCats.Count-1].Boredom -= 2;

            CheckLevelsNumber();


        }
        public void CheckLevelsNumber()
        {
            if (Health > 9) Health = 9;
            if (Health < 1) Health = 1;

            if (Boredom > 9) Boredom = 9;
            if (Boredom < 1) Boredom = 1;

            if (Hunger > 9) Hunger = 9;
            if (Hunger < 1) Hunger = 1;
        }
        

        public void CheckStatus()
        {

            CheckLevelsNumber();

            Console.WriteLine("The Status levels between [1 to 9]");
           
            Console.WriteLine("(Hunger First level  ) From [1] to [3] = Not Hungry");
            Console.WriteLine("(Hunger Second level) From [4] to [6] = Hungry");
            Console.WriteLine("(Hunger Third level  ) From [7] to [9] = Starving");
            Console.WriteLine("\n");
            Console.WriteLine("The hunger level for " + " " + Name +" is "+ Hunger );

            Console.WriteLine("\n");
            Console.WriteLine("(Boredom First level  )  From [7] to [9] = Sad");
            Console.WriteLine("(Boredom Second level)  From [4] to [6] = It is Ok");
            Console.WriteLine("(Boredom Third level  )  From [1] to [3] = Happy");
            Console.WriteLine("\n");
            Console.WriteLine("The Happy level for " + " " + Name + " is " + Boredom);

            Console.WriteLine("\n");
            Console.WriteLine("(Health First level  )  From [1] to [3] = Bad");
            Console.WriteLine("(Health Scecond level)  From [4] to [6] = Good");
            Console.WriteLine("(Health Third level  )  From [7] to [9] = Healthy");
            Console.WriteLine("\n");
            Console.WriteLine("The Health level for "+" " + Name + " is " + Health);
        }


    }


}
