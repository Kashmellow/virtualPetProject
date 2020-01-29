using System;
using System.Collections.Generic;
using System.Text;

namespace virtualPetShopB
{
    public class VirtualPetShelter
    {
        //Cat cat = new Cat();

        public List<Cat> myPets = new List<Cat>();

        //public void SetPet()
        //{
        //    myPets.Add(new Cat());

        //    int count = myPets.Count - 1;
        //    myPets[count].Name = cat.Name;

        //    myPets[count].FurColor = cat.FurColor;

        //    myPets[count].Age = cat.Age;

        //    myPets[count].Lives = cat.Lives;

        //    myPets[count].Hunger = 3;

        //    myPets[count].Boredom = 9;

        //    myPets[count].Health = 1;

        //}

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

                    myPets[i].CheckLevelsNumber();
                }
        }
        public void GoToDrAll()
        {
            for (int i = 0; i < myPets.Count; i++)
            {
        
                myPets[i].GoToDr();

                myPets[i].CheckLevelsNumber();
            }
        }

        public void FeedCat()

        {
            for (int i = 0; i < myPets.Count; i++)
            {
                myPets[i].FeedSpecificCat();

                myPets[i].CheckLevelsNumber();
            }
        }
        public void CheckStatusAll()
        {
            for (int i = 0; i < myPets.Count; i++)
            {

                Console.WriteLine("The Status levels between [1 to 9] \n");

                Console.WriteLine("\n");
                Console.WriteLine("The hunger level for " + " " + myPets[i].Name + " is " + myPets[i].Hunger);

                Console.WriteLine("\n");
                Console.WriteLine("The boredom level for " + " " + myPets[i].Name + " is " + myPets[i].Boredom);

                Console.WriteLine("\n");
                Console.WriteLine("The Health level for " + " " + myPets[i].Name + " is " + myPets[i].Health);
            }

        }
    }

}