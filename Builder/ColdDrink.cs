namespace DesignPatterns.Builder
{
    public abstract class ColdDrink : IItem
    {
        public string Name()
        {
            return this.GetType().Name;
        }

        public IPacking Packing()
        {
            return new Bottle();
        }
        public abstract float Price();
    }
}