namespace TriminoV3
{
    internal class Menu
    {    
        static void Main(string[] args)
        {
            Trimino example = new  Trimino(1, 2, 3, true);
            example.RollLeft();
            example.PrepareToPlace(false);
            Trimino example2 = new Trimino(1, 2, 3, true);
            example2.RollLeft(2);
            example2.PrepareToPlace(false);
            Trimino example3 = new Trimino(1, 2, 3, true);
            example3.RollLeft(3);
            example3.PrepareToPlace(false);
            Console.WriteLine("Hello");
        }
    }
}