namespace MarkovLibraryCSharp
{
    //Vertex class for transition graph plus
    public class VertexAp : AVertex
    {
        public VertexAp(double probability, double pay)
        {
            Probability = probability;
            Pay = pay;
            TempProbability = 0;
            TempPay = 0;
            Neighborhood = new List<AArc>();
        }

        // public List<ArcPay> Neighborhood { get; }

        //Add an arc to the neighborhood vector
        public override void AddArcToNeighborhood(AVertex neighbor, double probability, double pay)
        {
            Neighborhood.Add(new ArcPay(neighbor, probability, pay));
        }

        //reset all values to 0
        public override void Reset()
        {
            Probability = 0;
            TempProbability = 0;
            Pay = 0;
            TempPay = 0;
        }
    }
}