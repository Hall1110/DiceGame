using System.Reflection.Metadata.Ecma335;

namespace DiceGame
{
    public class Dice
    {
        public int Sides { get; set; }

        
        
        public Dice()
        {
            Sides = 6;
        }

        
        
        public Dice ChangeDefaultDiceSize(int sides)
        {
            Sides = sides;
            return this;
        }


        
        public int Roll()
        {
            int sides = new Dice().Sides;
            int diceRoll = new Random().Next(1, sides + 1);
            return diceRoll;
        }
    }
}
