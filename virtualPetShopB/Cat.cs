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


        public void Create_Cat(string name, string furcolor, int age, int lives)
        {
            Name = name;
            FurColor = furcolor;
            Age = age;
            Lives = lives;

        }
        public void Exit_program()
        {
            Console.WriteLine("Come back later if you change your mind. Bye!");
            Environment.Exit(0);
        }

        public void Main_Menu(string user_selection)
        {


            switch (user_selection)
            {
                case "1":
                    Play_With_Cat();
                    break;

                case "2":
                    Feed_Cat();
                    break;

                case "3":
                    Go_To_Dr();
                    break;

                case "4":
                    Check_Status();
                    break;

                case "5":
                    Exit_program();
                    break;

                default:
                    break;
            }

        }
        public void Play_With_Cat()
        {
            Health += 2;
            Hunger += 3;
            Boredom -= 3;

            Check_Levels_Number();
        }

        public void Go_To_Dr()
        {
            Health += 4;
            Boredom += 2;

            Check_Levels_Number();
        }
        public void Feed_Cat()
        {
            Health += 1;
            Hunger -=4;
            Boredom -= 2;

            Check_Levels_Number();


        }
        public void Check_Levels_Number()
        {
            if (Health > 9) Health = 9;
            if (Health < 1) Health = 1;

            if (Boredom > 9) Boredom = 9;
            if (Boredom < 1) Boredom = 1;

            if (Hunger > 9) Hunger = 9;
            if (Hunger < 1) Hunger = 1;
        }
        

        public void Check_Status()
        {

            Check_Levels_Number();

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
