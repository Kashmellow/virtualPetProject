using System;
using System.Collections.Generic;
using System.Text;

namespace virtualPetShopB
{
    public class VirtualPetShelter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FurColor { get; set; }
        public int Age { get; set; }
        public int Lives { get; set; }
        public int Hunger { get; set; }
        public int Health { get; set; }
        public int Boredom { get; set; }

        public VirtualPetShelter()
        {
            Id = 0;
            Hunger = 9;
            Boredom = 9;
            Health = 1;
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
    }

}
