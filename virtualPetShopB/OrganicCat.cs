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
            Health = 1;
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

        public   void PlayWithCat()
        {
           
            Hunger = 5;
            Health = 1;
            Boredom -= 3;
          
            //  CheckLevelsNumber();
        }

    }
    
}
