namespace MarkovLibraryCSharp
{
    public abstract class AArc
    {
        public double Pay { get; set; }
        public AVertex? Neighbor { get; set; }
        public double Probability { get; set; }
    }
}