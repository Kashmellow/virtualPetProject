using System;
using System.Collections.Generic;
using System.Text;

namespace virtualPetShopB
{
    class RoboticCat:Cat
    {
        public int NeedsFuel { get; set; }
        public int MaintenanceCondition { get; set; }


        public RoboticCat()
        {
            NeedsFuel = 5;
            MaintenanceCondition = 1;
        }

        public RoboticCat(int X, int Y) : base(X, Y)
        {

        }
        public void CheckLevelsNumber()
        {

            if (MaintenanceCondition > 9) MaintenanceCondition = 9;
            if (MaintenanceCondition < 1) MaintenanceCondition = 1;

            if (Boredom > 9) Boredom = 9;
            if (Boredom < 1) Boredom = 1;

            if (NeedsFuel > 9) NeedsFuel = 9;
            if (NeedsFuel < 1) NeedsFuel = 1;

        }

        public override void PlayWithCat()
        {

            HungerNeedFuel += 1;
            HealthMaintenanceCondition += 1;
            Boredom -= 3;
            Console.WriteLine("tttttttttttttttttttttttt");
            CheckLevelsNumber();


            CheckLevelsNumber();
        }

        public override void FeedSpecificCat()
        {
            MaintenanceCondition += 2;
            NeedsFuel -= 3;
            CheckLevelsNumber();
        }

        public override void GoToDr()
        {
            MaintenanceCondition += 4;

            CheckLevelsNumber();
        }
    }
}
