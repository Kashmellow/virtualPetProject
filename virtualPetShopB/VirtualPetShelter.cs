
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Timers;


namespace virtualPetShopB
{
    
    public class VirtualPetShelter
    {

        public static int stdata;
        private static int seconds = 0;
        public  List<Cat> myPets = new List<Cat>();
        public static List<Cat> myPets2 = new List<Cat>();
        public static  int[] t = new int[5];
        public void ViewInfoAll()

        {
            int Id = 1;

            Console.WriteLine("___________________________________________________________________");
            Console.WriteLine("|   I D   |               | Cat Name |                | Cat Color |");
            Console.WriteLine("___________________________________________________________________");

            for (int i = 0; i < myPets.Count; i++)
            {

                Console.WriteLine("     " + Id + "                       " + myPets[i].Name + "                         " + myPets[i].FurColor);
                Console.WriteLine("-------------------------------------------------------------------");
                Id++;
            }
            Console.WriteLine("___________________________________________________________________");

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
            Console.WriteLine("\n \n \n");
            Console.WriteLine("                                 The status levels are between 1 (low) to 9 (high) \n");
            Console.WriteLine("___________________________________________________________________________________________________________________");

            Console.WriteLine("   |    Cat Name      |        |   Energy Need   |       |   Physical Condition   |       |  Boredom Level  | ");

            Console.WriteLine("___________________________________________________________________________________________________________________");

            for (int i = 0; i < myPets.Count; i++)
            {

              
                Console.WriteLine("\n");
           
                Console.WriteLine("\n");
                Console.WriteLine( "         " + myPets[i].Name + "                            " + myPets[i].HungerNeedFuel + "                            " + myPets[i].HealthMaintenanceCondition + "                            " + myPets[i].Boredom);
                Console.WriteLine("___________________________________________________________________________________________________________________");




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
          //  ViewInfoAll();

            Console.WriteLine("\n^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ \n");
        }
               
        public void TimerRun()
        {
            ViewInfoAll();
            Console.WriteLine("\n^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^\n");
            Console.Write("write the number next to the cat you would like to check the status:");
            int catIdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            stdata = catIdNumber;
            myPets2 = myPets;
         

            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 1000;
            aTimer.Enabled = true;

            seconds = 0;
            Console.WriteLine("Press \'q\' to quit the sample.");
            while (Console.Read() != 'q') ;

            Console.WriteLine("\n " );
        }

        public  void TimerEffect()
        {
            myPets = myPets2;
        }
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            
            if (seconds<20)
            seconds++;
                    
                      
                if (seconds > 2 && seconds < 6)
                {
                    if(seconds==3)
                    {
                        Console.WriteLine("\n "); Console.WriteLine("\n ");
                    
                    Console.WriteLine("____________________________________________________________________________________________________________________________________");

                        Console.WriteLine("  |   Timer      |        |    Cat Name      |        |   Energy Need   |       |   Physical Condition   |       |  Boredom Level  |");
                        Console.WriteLine("____________________________________________________________________________________________________________________________________");
                        Console.WriteLine("\n ");
                    

                        Console.WriteLine("\n");
                           Console.WriteLine("          " + seconds + "                       " + myPets2[stdata - 1].Name + "                         " + myPets2[stdata - 1].HungerNeedFuel + "                          " + myPets2[stdata - 1].HealthMaintenanceCondition + "                             " + myPets2[stdata - 1].Boredom);
                    

                        myPets2[stdata -1].HungerNeedFuel += 1;
                        myPets2[stdata - 1].HealthMaintenanceCondition -= 1;
                        myPets2[stdata - 1].Boredom += 1;
                    if (myPets2[stdata - 1].HungerNeedFuel < 1) myPets2[stdata - 1].HungerNeedFuel = 1;
                    if (myPets2[stdata - 1].HungerNeedFuel > 9) myPets2[stdata - 1].HungerNeedFuel = 9;
                    if (myPets2[stdata - 1].HealthMaintenanceCondition < 1) myPets2[stdata - 1].HealthMaintenanceCondition = 1;
                    if (myPets2[stdata - 1].HealthMaintenanceCondition > 9) myPets2[stdata - 1].HealthMaintenanceCondition = 9;
                    if (myPets2[stdata - 1].Boredom < 1) myPets2[stdata - 1].Boredom = 1;
                    if (myPets2[stdata - 1].Boredom > 9) myPets2[stdata - 1].Boredom = 9;

                }

                Console.WriteLine("\n");
                Console.WriteLine("          " + seconds + "                       " + myPets2[stdata - 1].Name + "                         " + myPets2[stdata - 1].HungerNeedFuel + "                          " + myPets2[stdata - 1].HealthMaintenanceCondition + "                             " + myPets2[stdata - 1].Boredom);
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------");
                
            }

                           
            if (seconds > 7 && seconds < 12)
                {
                    //if (i == 0)
                    //{
                        myPets2[stdata - 1].HungerNeedFuel += 1;
                        myPets2[stdata - 1].HealthMaintenanceCondition -= 1;
                        myPets2[stdata - 1].Boredom += 1;
                if (myPets2[stdata - 1].HungerNeedFuel < 1) myPets2[stdata - 1].HungerNeedFuel = 1;
                if (myPets2[stdata - 1].HungerNeedFuel > 9) myPets2[stdata - 1].HungerNeedFuel = 9;
                if (myPets2[stdata - 1].HealthMaintenanceCondition < 1) myPets2[stdata - 1].HealthMaintenanceCondition = 1;
                if (myPets2[stdata - 1].HealthMaintenanceCondition > 9) myPets2[stdata - 1].HealthMaintenanceCondition = 9;
                if (myPets2[stdata - 1].Boredom < 1) myPets2[stdata - 1].Boredom = 1;
                if (myPets2[stdata - 1].Boredom > 9) myPets2[stdata - 1].Boredom = 9;


                Console.WriteLine("\n");
                Console.WriteLine("          " + seconds + "                       " + myPets2[stdata - 1].Name + "                         " + myPets2[stdata - 1].HungerNeedFuel + "                          " + myPets2[stdata - 1].HealthMaintenanceCondition + "                             " + myPets2[stdata - 1].Boredom);
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------");


            }
            if (seconds > 13 && seconds < 20)
            {
                
                myPets2[stdata - 1].HungerNeedFuel += 1;
                myPets2[stdata - 1].HealthMaintenanceCondition -= 1;
                myPets2[stdata - 1].Boredom += 1;
                if (myPets2[stdata - 1].HungerNeedFuel < 1) myPets2[stdata - 1].HungerNeedFuel = 1;
                if (myPets2[stdata - 1].HungerNeedFuel > 9) myPets2[stdata - 1].HungerNeedFuel = 9;
                if (myPets2[stdata - 1].HealthMaintenanceCondition < 1) myPets2[stdata - 1].HealthMaintenanceCondition = 1;
                if (myPets2[stdata - 1].HealthMaintenanceCondition > 9) myPets2[stdata - 1].HealthMaintenanceCondition = 9;
                if (myPets2[stdata - 1].Boredom < 1) myPets2[stdata - 1].Boredom = 1;
                if (myPets2[stdata - 1].Boredom > 9) myPets2[stdata - 1].Boredom = 9;


                Console.WriteLine("\n");
                Console.WriteLine("          " + seconds + "                       " + myPets2[stdata - 1].Name + "                         " + myPets2[stdata - 1].HungerNeedFuel + "                          " + myPets2[stdata - 1].HealthMaintenanceCondition + "                             " + myPets2[stdata - 1].Boredom);
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------");


            }


            // TimerEffect();

        }


        }

    }

