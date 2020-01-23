using System;
using Xunit;

namespace virtualPetShopB
{
    public class CatTests
    {
        [Fact]
        public void Cat_Hunger_Check()
        {
            //Note(1) This Method created to make a test .

            //Arrange
            Cat mycat = new Cat();


            /*Note(2) after create mycat object the Hunger level will be ( 9 ) 
             and if you want read the levels chart :

             (Hunger First level  ) From [1] to [3] = Not Hungry");
             (Hunger Scecond level) From [4] to [6] = Hungry");
             (Hunger Third level  ) From [7] to [9] = Starving");

             */

            //Act
            mycat.FeedCat();

            /*Note (3) i called the method (Feed_Cat())
             and the body for this method
             
            public void Feed_Cat()
        {
            Health += 1;
            Hunger -=4;
            Happy  += 2;

            Check_Levels_Number();
        }
        That is mean the status for Hunger will Decrease -4   
        and the Hunger will be =9 - 4 = (5)

             */

            
            //Assert
            Assert.Equal(5, mycat.Hunger);
        }

        [Fact]

        public void Cat_Boredom_Check()
        {
            //Note(1) This Method created to make a test .

            //Arrange
            Cat mycat = new Cat();

            /*Note(2) after create mycat object the Boredom level will be ( 1 ) 
             and if you want read the levels chart :

             (Boredom First level  ) From [1] to [3] = Sad");
             (Boredom Scecond level) From [4] to [6] = It is Ok");
             (Boredom Third level  ) From [7] to [9] = Happy");

             */

            //Act
           mycat.PlayWithCat();

            /*Note (3) i called the method (Play_With_Cat())
             and the body for this method

            public void Play_With_Cat()
        {
            Health += 2;
            Hunger += 3;
            Boredom -= 3;

            Check_Levels_Number();
        }

        That is mean the status for 

        and the Boredom will be = 9 - 3 = (6)

             */


            //Assert
            Assert.Equal(9, mycat.Boredom);
        }
    }
    }
