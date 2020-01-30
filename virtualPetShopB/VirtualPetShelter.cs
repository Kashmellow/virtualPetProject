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

                Console.WriteLine("    " + Id + "       " + myPets[i].Name + "         " + myPets[i].FurColor);
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
        {
            for (int i = 0; i < myPets.Count; i++)
            {

                Console.WriteLine("The status levels are between 1 (low) to 9 (high) \n");

                Console.WriteLine("\n");
                Console.WriteLine("The energy need for " + " " + myPets[i].Name + " is " + myPets[i].HungerNeedFuel);

                Console.WriteLine("\n");
                Console.WriteLine("The boredom level for " + " " + myPets[i].Name + " is " + myPets[i].Boredom);

                Console.WriteLine("\n");
               Console.WriteLine("The physical condition for " + " " + myPets[i].Name + " is " + myPets[i].HealthMaintenanceCondition);
            }

        }

        public void AdoptCat()
          {


            ViewInfoAll();
            
            Console.WriteLine("write the number next to the cat you would like to edit:");
            int catIdNumber = Convert.ToInt32(Console.ReadLine());

            myPets.RemoveAt(catIdNumber-1);
            ViewInfoAll();


        }
               


    }

}