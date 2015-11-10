using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollingDice8_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DiceRoll.MessageIntro());

            bool loop = true;
            while(loop == true)
            {
            Console.ReadLine();
            DiceRoll RollingDice = new DiceRoll();

            Console.WriteLine("Lets roll the dice {0} times & see the result!", RollingDice.MaxRoll);
            RollingDice.TallyRoll();
            Console.WriteLine(RollingDice.ToString());
            Console.Read();
            }
            
            
        }
    }
}
