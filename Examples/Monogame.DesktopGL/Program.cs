using System;

namespace Extended
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            using (var game = new ExtendedGame())
            {
                game.Run();
            }
        }
    }
}
