using System;

namespace playingwithcubes
{
    class Program
    {
        static void Main(string[] args)
        {
            var tmp = new Cube(-1*-9);
        }
    }
    public class Cube
    {
        private int Side;

        public Cube()
        {
            Side = 0;
        }

        public Cube(int side)
        {
            Side = side < 0 ? side * -1 : side;
        }

        //This cube needs your help. 
        //Define a constructor which takes one integer and assignes its value to 'Side'

        public int GetSide()
        {
            return this.Side;
        }

        public void SetSide(int s)
        {
            this.Side = s < 0 ? s * -1 : s;
        }
    }
}
