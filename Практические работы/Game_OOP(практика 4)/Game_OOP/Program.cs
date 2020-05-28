using System;

namespace Game_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Game g1 = new Game(player);
            g1.Greetings();
        }
    }
}
