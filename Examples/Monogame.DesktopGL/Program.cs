using System;

namespace Extended
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            using (var game = new ExtendedGame())
            {


                object o = new object();
               var th = o.GetType().TypeHandle;
               var s = sizeof(System.RuntimeTypeHandle);
               // var s1 = sizeof(Type);
                game.Run();
            }
        }
    }
}
