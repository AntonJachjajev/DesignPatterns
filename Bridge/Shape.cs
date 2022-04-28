namespace DesignPatterns.Bridge
{
    public abstract class Shape
    {
        protected DrawAPI DrawApi;

        protected Shape(DrawAPI drawApi)
        {
            this.DrawApi = drawApi;
        }
        public abstract void Draw();
    }
}