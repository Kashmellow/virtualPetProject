using System;
using System.Collections.Generic;
using System.Text;

namespace virtualPetShopB
{
    public class OrganicCat : Cat
    {
        public int Hunger { get; set; }
        public int Health { get; set; }

        public OrganicCat()
        {
            Hunger = 5;
            Health=1;
        }

        public OrganicCat(int Hunger  , int Health) : base(Hunger , Health)
            {
            //Hunger = 5;
            //Health = 1;
                                   
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

        public override void PlayWithCat()
        {

            HungerNeedFuel += 1;
            HealthMaintenanceCondition += 1;
            Boredom -= 3;
            Console.WriteLine("hhhhhhhhhhhhhhhhhhhhhhhhhh");
             CheckLevelsNumber();
        }

        public override void FeedSpecificCat()
        {
            Health += 2;
            Hunger -= 3;
            CheckLevelsNumber();
        }

        public override void GoToDr()
        {
            Health += 4;

            CheckLevelsNumber();
        }

        //public CheckStatusOrganic()
        //{
        //    for (int i = 0; i < myPets.Count; i++)
        //    {

        //        Console.WriteLine("The Status levels between [1 to 9] \n");

        //        Console.WriteLine("\n");
        //        Console.WriteLine("The hunger level for " + " " + myPets[i].Name + " is " + myPets[i].Hunger);

        //        Console.WriteLine("\n");
        //        Console.WriteLine("The boredom level for " + " " + myPets[i].Name + " is " + myPets[i].Boredom);

        //        Console.WriteLine("\n");
        //        Console.WriteLine("The Health level for " + " " + myPets[i].Name + " is " + myPets[i].Health);
        //    }

    }
    
}