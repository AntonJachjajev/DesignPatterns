namespace DesignPatterns.Builder
{
    public abstract class Burger: IItem
    {
        public string Name()
        {
            return this.GetType().Name;
        }

        public IPacking Packing()
        {
            return new Wrapper();
        }
        public abstract float Price();
    }
}