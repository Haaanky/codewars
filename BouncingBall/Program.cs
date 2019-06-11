using System;

namespace BouncingBall
{
    class Program
    {
        static void Main(string[] args)
        {
            BouncingBall.bouncingBall(3.0, 0.66, 1.5);
            BouncingBall.bouncingBall(30.0, 0.66, 1.5);
        }
    }
    public class BouncingBall
    {
        public static int bouncingBall(double h, double bounce, double window)
        {
            var i = 1;
            if (h > 0)
                if (bounce > 0 && bounce < 1)
                    if (window < h)
                    {
                        do
                        {
                            h *= bounce;
                            if (h > window)
                                i += 2;
                        } while (h > window);
                        return i;
                    }
            return -1;
        }
    }
}
