using System;

namespace WindowsFormsApplication1
{
    public class Particle
    {
        public Vector2d position = new Vector2d(0, 0);
        public Vector2d size = new Vector2d(10, 10);
        public Vector2d speed = new Vector2d(0, 0);
        public Particle(Vector2d pos) {
            Random rand = new Random();
            position = pos;
            //position = pos.Sum(new Vector2d(Convert.ToSingle(rand.NextDouble() * 10 - 0.5), Convert.ToSingle(rand.NextDouble() * 10 - 0.5)));
            speed = new Vector2d(Convert.ToSingle(rand.NextDouble()*2 - 0.5), Convert.ToSingle(rand.NextDouble()*2-0.5));
            //speed = new Vector2d(0, -5);


        }
    }
}