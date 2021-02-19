using System;

namespace PhysicsExampleA
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new PhysicsExampleAGame())
                game.Run();
        }
    }
}
