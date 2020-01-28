using System;
using System.Collections.Generic;
using System.Text;

namespace virtualPetShopB
{
    public List<Cat> myPets = new List<Cat>();

    public void SetPet()
    {
        myPets.Add(new Cat());

        int count = myPets.Count - 1;
        myPets[count].Name = Name;

        myPets[count].FurColor = FurColor;

        myPets[count].Age = Age;

        myPets[count].Lives = Lives;

        myPets[count].Id += myPets.Count;

        myPets[count].Hunger = 3;

        myPets[count].Boredom = 9;

        myPets[count].Health = 1;


    }
    public void ViewInfo()
    //move to new virtualpetshelter class
    {
        Console.WriteLine("|   I D   |  | Cat Name |  | Cat Color |");
        foreach (Cat cat in myPets)
        {

            Console.WriteLine("    " + cat.Id + "       " + cat.Name + "         " + cat.FurColor);

        }
    }
    public void PlayWithCat()
    {
        for (int i = 0; i < myPets.Count; i++)
        {
            myPets[i].Health += 1;
            myPets[i].Hunger -= 4;
            myPets[i].Boredom -= 2;

            CheckLevelsNumber();

            //myPets[userChoice - 1].PlayWithCat();
        }
    }
    public void GoToDr()
    {
        for (int i = 0; i < myPets.Count; i++)
        {
            myPets[i].Health += 4;
            myPets[i].Boredom += 2;

            CheckLevelsNumber();
        }
    }

    public void FeedCat()

    {
        for (int i = 0; i < myPets.Count; i++)
        {
            myPets[i].Health += 1;
            myPets[i].Hunger -= 4;
            myPets[i].Boredom -= 2;

            CheckLevelsNumber();
        }
    }


}