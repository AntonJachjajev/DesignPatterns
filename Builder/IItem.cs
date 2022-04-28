namespace DesignPatterns.Builder
{
    public interface IItem
    {
        public string Name();
        public IPacking Packing();
        public float Price();
    }
}