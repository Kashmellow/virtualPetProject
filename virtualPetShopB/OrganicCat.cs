﻿using System;
using System.Collections.Generic;
using System.Text;

namespace virtualPetShopB
{
    public class OrganicCat : Cat
    {
        public OrganicCat()
        {
           
        }

        public OrganicCat(int Hunger, int Health) : base(Hunger, Health)
            {
            //Hunger = 5;
            //Health = 1;
                                   
        }
        public void CheckLevelsNumber()
        {

            if (HealthMaintenanceCondition > 9) HealthMaintenanceCondition = 9;
            if (HealthMaintenanceCondition < 1) HealthMaintenanceCondition = 1;

            if (Boredom > 9) Boredom = 9;
            if (Boredom < 1) Boredom = 1;

            if (HungerNeedFuel > 9) HungerNeedFuel = 9;
            if (HungerNeedFuel < 1) HungerNeedFuel = 1;

        }

        public override void PlayWithCat()
        {

            HungerNeedFuel += 1;
            HealthMaintenanceCondition += 1;
            Boredom -= 3;
            
             CheckLevelsNumber();
        }

        public override void FeedSpecificCat()
        {
            HealthMaintenanceCondition += 2;
            HungerNeedFuel -= 3;

            CheckLevelsNumber();
        }

        public override void GoToDr()
        {
            HealthMaintenanceCondition += 4;
            Boredom -= 3;

            CheckLevelsNumber();
        }

    }
    
}