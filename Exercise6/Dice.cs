using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6
{
    class Dice
    {
        private int sidesOfDie;
        private Random randomNumber = new Random();

        public Dice(int sides)
        {

            if (4 <= sides && sides <= 20)
            {
                this.sidesOfDie = sides;
            }
            else
            {
                Console.WriteLine("Unable to process request");
            }
        }

        public int rollDie()
        {
            return randomNumber.Next(1, 6 + 1);
        }

    }
}