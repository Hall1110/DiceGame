namespace DiceGame
{
    public class Dice
    {
        public int Sides { get; set; }

        
        
        public Dice()
        {
            Sides = 6;
        }

        
        
        public int Roll()
        {
            int sides = new Dice().Sides;
            int diceRoll = new Random().Next(1, sides + 1);
            return diceRoll;
        }



        
    }
}
