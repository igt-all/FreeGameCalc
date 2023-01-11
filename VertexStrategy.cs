namespace MarkovLibraryCSharp
{
    public class VertexStrategy : AVertex
    {
        //public List<Arc> Neighborhood { get; }
        public VertexStrategy(double probability, double pay)
        {
            Probability = probability;
            TempProbability = 0;
            TempPay = 0;
            Strategy = true;
            OriginalPay = pay;
            Pay = (double)Convert.ChangeType(pay, typeof(double));
            Neighborhood = new List<AArc>();
        }

        public bool Strategy { get; set; }
        public double OriginalPay { get; set; }

        //Add an arc to the neighborhood vector
        public override void AddArcToNeighborhood(AVertex neighbor, double probability, double pay = 0)
        {
            Neighborhood.Add(new Arc(neighbor, probability));
        }

        //set the pay and original pay values simultaneously
        public override void SetPay(double pay)
        {
            OriginalPay = pay;
            Pay = (double)Convert.ChangeType(pay, typeof(double));
        }

        //get the original pay value
        public override double GetPay()
        {
            return OriginalPay;
        }

        //reset all values to 0 and strategy to true
        public override void Reset()
        {
            Probability = 0;
            TempProbability = 0;
            Pay = 0;
            OriginalPay = 0.0;
            TempPay = 0;
            Strategy = true;
        }
    }
}