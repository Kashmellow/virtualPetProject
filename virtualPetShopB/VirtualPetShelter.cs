using System;
using System.Collections.Generic;
using System.Text;

namespace virtualPetShopB
{
    public class VirtualPetShelter
    {
    
        public List<Cat> myPets = new List<Cat>();
        public void ViewInfoAll()

        {
            int Id = 1;
            Console.WriteLine("|   I D   |  | Cat Name |  | Cat Color |");
            for (int i = 0; i < myPets.Count; i++)
            {

                Console.WriteLine("    " + Id + "         " + myPets[i].Name + "          " + myPets[i].FurColor);
                Id++;
            }
        }
    public Cat ChoosePet()
            {
                ViewInfoAll();
                Console.WriteLine("Press the number of the pet to which this applies:");
                int userChoice = Convert.ToInt32(Console.ReadLine());
            int index = userChoice - 1;
                return myPets[index];
            }

        public void PlayWithAllCats()
        {
                for (int i = 0; i < myPets.Count; i++)
                {

                    myPets[i].PlayWithCat();

                }
        }
        public void GoToDrAll()
        {
            for (int i = 0; i < myPets.Count; i++)
            {
        
                myPets[i].GoToDr();

            }
        }

        public void FeedCat()

        {
            for (int i = 0; i < myPets.Count; i++)
            {
                myPets[i].FeedSpecificCat();

            }
        }
        public void CheckStatusAll()
        {for (int j= 0; j< 1000;j++)
            {
                Console.Write("     ^   ^       ^   ^        ^   ^        ^   ^        ^   ^        ^   ^   CAT  ^   ^    "); 
                Console.Write("    ( o.o ) CAT ( o.o )      ( o.o )      ( o.o )      ( o.o )      ( o.o )      ( o.o )   ");
                Console.Write("     > ^ <       > ^ <        > ^ < CAT    > ^ <        > ^ <        > ^ <        > ^ <    ");
            }
            Console.WriteLine("");
            Console.WriteLine("                                 The status levels are between 1 (low) to 9 (high) \n");
           
            Console.WriteLine("   |    Cat Name      |        |   Energy Need   |       |   Physical Condition   |       |  Boredom Level  |");

            for (int i = 0; i < myPets.Count; i++)
            {

              
                Console.WriteLine("\n");
             //   Console.WriteLine("" + myPets[i].Name + "        " + myPets[i].HungerNeedFuel +"     " + myPets[i].HealthMaintenanceCondition + "     "+ myPets[i].Boredom);
                string stdata = string.Format("{0,10 }  {1,20}  {2,20} {3,20} ", myPets[i].Name, myPets[i].HungerNeedFuel, myPets[i].HealthMaintenanceCondition, myPets[i].Boredom);

                Console.WriteLine(stdata);
            }

        }

        public void AdoptCat()
          {
            

            ViewInfoAll();
            Console.WriteLine("\n^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^\n");
            Console.Write("write the number next to the cat you would like to adopt:");
            int catIdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Congratulations! You have just adopted "+ myPets[catIdNumber - 1].Name);
            Console.WriteLine("\n");

            myPets.RemoveAt(catIdNumber-1);
            ViewInfoAll();

            Console.WriteLine("\n^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ \n");
        }
               


    }

}