namespace MarkovLibraryCSharp
{
    public abstract class AVertex
    {
        public double Pay { get; set; }
        public double TempPay { get; set; }
        public double Probability { get; set; }
        public double TempProbability { get; set; }
        public List<AArc> Neighborhood { get; set; }

        //Set the pay value virtual gives the option of the derived class to override, abstract forces the derived class to implement
        public virtual void SetPay(double pay)
        {
            Pay = pay;
        }

        public abstract void AddArcToNeighborhood(AVertex neighbor, double probability, double pay);

        //Get the pay value
        public virtual double GetPay()
        {
            return Pay;
        }

        public abstract void Reset();
    }
}