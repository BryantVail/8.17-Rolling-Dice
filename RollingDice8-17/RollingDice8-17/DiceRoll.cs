using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollingDice8_17
{
    class DiceRoll
    {

        protected int maxRoll;
         protected int[] rollValue = new int[13];

        //Constructor Default
        public DiceRoll()
        {
            maxRoll = 36000;
        }// end Constructor Default

        public DiceRoll(int rollCount)
        {
            maxRoll = rollCount;
        } //end Constructor 1 Parameter Roll Count

        //Property MaxRoll
        public int MaxRoll
        {
            get
            {
                return maxRoll;

            }
            set
            {
                if (value > 0)
                    maxRoll = value;
            } //end Property MaxRoll
        }

        //Method to get Dice Roll, Return Sum of two rolled dice
        //2 dice only
        public int RollingDice()
        {
                Random randRoll = new Random();
                Random randRoll2 = new Random();
                return randRoll2.Next(1,6) + randRoll.Next(1, 6);
          
        }//end method Rolling Dice


        //Rolling the dice MaxValue times
        //
        public void TallyRoll()
        {
            
            for(int i = 0; i <= MaxRoll; i ++ )
            {
                int sum = RollingDice();
                switch (sum)
                {
                    case 2:
                        rollValue[2] += 1;
                        break;
                    case 3:
                        rollValue[3] += 1;
                        break;
                    case 4:
                        rollValue[4] += 1;
                        break;
                    case 5:
                        rollValue[5] += 1;
                        break;
                    case 6:
                        rollValue[6] += 1;
                        break;
                    case 7:
                        rollValue[7] += 1;
                        break;
                    case 8:
                        rollValue[8] += 1;
                        break;
                    case 9:
                        rollValue[9] += 1;
                        break;
                    case 10:
                        rollValue[10] += 1;
                        break;
                    case 11:
                        rollValue[11] += 1;
                        break;
                    case 12:
                        rollValue[12] += 1;
                        break;
                    default:
                        
                        break;

                }//end Switch Statement
                }//end for loop
        }//end TallyRoll

        public override string ToString()
        {
            string explain = "For each sum of the dice roll, will be displayed the frequency of that sum during the length of the Roll Count:\n";
            string displayTable = "Total\tCount\t\n";
            string totals = "2\t" + rollValue[2] + "\n3\t" + rollValue[3] + "\n4\t" + rollValue[4] + "\n5\t" + rollValue[5] + "\n6\t" + rollValue[6] + "\n7\t" + rollValue[7] + "\n8\t" + rollValue[8] + "\n9\t" + rollValue[9] + "\n10\t" + rollValue[10] + "\n11\t" + rollValue[11] + "\n12\t" + rollValue[12];
            return explain + displayTable + totals;
        }

        public static string MessageIntro()
        {
            string messageIntro = "Welcome to the Dice Simulator! \nRoll the dice & see which sum occurs the most!";
            return messageIntro;
        }

    }
}
