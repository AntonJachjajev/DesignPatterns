namespace DesignPatterns.Builder
{
    public class VegBurger : Burger
    {
        public override float Price()
        {
            return 25.0f;
        }

        public string Name()
        {
            return "Veg Burger";
        }

    }
}