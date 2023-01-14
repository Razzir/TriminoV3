namespace TriminoV3
{
    internal class Menu
    {
        static void Main(string[] args)
        {
            Trimino exaple = new Trimino(1, 2, 3);
            exaple.RollLeft();
            exaple.RollRight();

            Console.WriteLine("Hello, World!");
            
        }
    }
}