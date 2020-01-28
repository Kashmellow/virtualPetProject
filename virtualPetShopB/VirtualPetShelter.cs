using System;
using System.Collections.Generic;
using System.Text;

namespace virtualPetShopB
{
    public class VirtualPetShelter
    {
        Cat cat = new Cat();

        public List<Cat> myPets = new List<Cat>();

        public void SetPet()
        {
            myPets.Add(new Cat());

            int count = myPets.Count - 1;
            myPets[count].Name = cat.Name;

            myPets[count].FurColor = cat.FurColor;

            myPets[count].Age = cat.Age;

            myPets[count].Lives = cat.Lives;

            myPets[count].Hunger = 3;

            myPets[count].Boredom = 9;

            myPets[count].Health = 1;

        }
    
    public void ViewInfo()
       
        {
           int Id = 1;
            Console.WriteLine("|   I D   |  | Cat Name |  | Cat Color |");
            foreach (Cat cat in myPets)
            {

                Console.WriteLine("    " + Id + "       " + cat.Name + "         " + cat.FurColor);
                Id++;
            }
        }
        public void PlayWithCat()
        {
            for (int i = 0; i < myPets.Count; i++)
            {
                myPets[i].Health += 1;
                myPets[i].Hunger -= 4;
                myPets[i].Boredom -= 2;

                cat.CheckLevelsNumber();

                //myPets[userChoice - 1].PlayWithCat();
            }
        }
        public void GoToDr()
        {
            for (int i = 0; i < myPets.Count; i++)
            {
                myPets[i].Health += 4;
                myPets[i].Boredom += 2;

                cat.CheckLevelsNumber();
            }
        }

        public void FeedCat()

        {
            for (int i = 0; i < myPets.Count; i++)
            {
                myPets[i].Health += 1;
                myPets[i].Hunger -= 4;
                myPets[i].Boredom -= 2;

                cat.CheckLevelsNumber();
            }
        }
    }

}