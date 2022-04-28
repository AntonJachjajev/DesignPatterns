namespace DesignPatterns.Bridge
{
    public class Circle : Shape
    {
        private readonly int _x;
        private readonly int _y;
        private readonly int _radius;

        public Circle(int x, int y, int radius, DrawAPI drawAPI)
            : base(drawAPI)
        {
            ;
            this._x = x;
            this._y = y;
            this._radius = radius;
        }

        public override void Draw()
        {
            DrawApi.DrawCircle(_radius, _x, _y);
        }
    }
}