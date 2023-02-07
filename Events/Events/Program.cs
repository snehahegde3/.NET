namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AudioSystem audioSystem = new AudioSystem();
            RenderingEngine renderingEngine= new RenderingEngine();

            Player p1 = new Player("Sne");
            Player p2 = new Player("Slok");

            GameEventManager.TriggerGameStart();

            Console.WriteLine("The game is tunning... press any key to stop the game");

            Console.Read();

            GameEventManager.TriggerGameOver();

        }
    }
}