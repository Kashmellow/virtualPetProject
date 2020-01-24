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
            int newCatAge = Convert.ToInt32(Console.ReadLine());

            myCats[count].Age = newCatAge;

            Console.WriteLine("Cats can have nine lives, how many will yours have?");
            int newCatLives = Convert.ToInt32(Console.ReadLine());

            myCats[count].Lives = newCatLives;

            myCats[count].Hunger = 3;
            myCats[count].Boredom = 9;
            myCats[count].Health = 1;

            //Name = newCatName;
            //FurColor = newCatColor;
            //Age = newCatAge;
            //Lives = newCatLives;



        }

        public void ViewInfo()
        {
            Console.WriteLine("| Cat Name |  | Cat Color |");
            foreach (Cat cat in myCats)
            {

                Console.WriteLine("    "+cat.Name + "         " + cat.FurColor);

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
                    ViewInfo();
                    break;

                case "3":
                    PlayWithCat();
                    break;

                case "4":
                    FeedCat();
                    break;

                case "5":
                    GoToDr();
                    break;

                case "6":
                    CheckStatus();
                    break;

                case "7":
                    ExitProgram();
                    break;

                default:
                    break;
            }

        }
        public void PlayWithCat()
        {
            for (int i = 0; i < myCats.Count; i++)
            {
                myCats[myCats.Count - 1].Health += 2;
                myCats[myCats.Count - 1].Hunger += 3;
                myCats[myCats.Count - 1].Boredom -= 3;

                CheckLevelsNumber();
            }
        }

        public void GoToDr()
        {
            for (int i = 0; i < myCats.Count; i++)
            {
                myCats[i].Health += 4;
                myCats[i].Boredom += 2;

                CheckLevelsNumber();
            }
        }
        public void FeedCat()
        {
            //foreach (Cat cat in myCats)
            for (int i=0;i<myCats.Count;i++)
               // myCats.Count = 1;
            {
                myCats[i].Health += 1;
                myCats[i].Hunger -= 4;
                myCats[i].Boredom -= 2;

                CheckLevelsNumber();
            }

        }
        public void CheckLevelsNumber()
        {
            foreach (Cat cat in myCats)
            {
                if (cat.Health > 9) cat.Health = 9;
                if (cat.Health < 1) cat.Health = 1;

                if (cat.Boredom > 9) cat.Boredom = 9;
                if (cat.Boredom < 1) cat.Boredom = 1;

                if (cat.Hunger > 9) cat.Hunger = 9;
                if (cat.Hunger < 1) cat.Hunger = 1;
            }
        }
        

        public void CheckStatus()
        {
            foreach(Cat cat in myCats)
                {



                CheckLevelsNumber();

                Console.WriteLine("The Status levels between [1 to 9]");

                Console.WriteLine("From [1] to [3] = Not Hungry");
                Console.WriteLine("From [4] to [6] = Hungry");
                Console.WriteLine("From [7] to [9] = Starving");
                Console.WriteLine("\n");
                Console.WriteLine("The hunger level for " + " " +cat.Name + " is " + cat.Hunger);

                Console.WriteLine("\n");
                Console.WriteLine("From [7] to [9] = Bored");
                Console.WriteLine("From [4] to [6] = It is Ok");
                Console.WriteLine("From [1] to [3] = Not bored at all");
                Console.WriteLine("\n");
                Console.WriteLine("The boredom level for " + " " + cat.Name + " is " + cat.Boredom);

                Console.WriteLine("\n");
                Console.WriteLine("From [1] to [3] = Bad");
                Console.WriteLine("From [4] to [6] = Good");
                Console.WriteLine("From [7] to [9] = Healthy");
                Console.WriteLine("\n");
                Console.WriteLine("The Health level for " + " " + cat.Name + " is " + cat.Health);
            }
        }


    }


}
