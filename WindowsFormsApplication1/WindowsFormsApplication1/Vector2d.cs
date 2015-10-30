namespace WindowsFormsApplication1
{
    public class Vector2d
    {
        public float X = 0;
        public float Y = 0;

        public Vector2d (float x, float y) {
            X = x;
            Y = y;
        }

        public Vector2d Sum(Vector2d aVector) {
            return new Vector2d(X + aVector.X, Y + aVector.Y);
        }
        public Vector2d Dif(Vector2d aVector)
        {
            return new Vector2d(X - aVector.X, Y - aVector.Y);
        }
    }
}