namespace MarkovLibraryCSharp
{
    public class Vertex : AVertex
    {
        //public List<Arc> _neighborhood;

        public Vertex(double probability, double pay)
        {
            Probability = probability;
            Pay = pay;
            TempProbability = 0;
            Neighborhood = new List<AArc>();
        }

        //Add an arc to the neighborhood vector
        public override void AddArcToNeighborhood(AVertex neighbor, double probability, double pay = 0)
        {
            Neighborhood.Add(new Arc(neighbor, probability));
        }

        //reset all values to 0
        public override void Reset()
        {
            Probability = 0;
            TempProbability = 0;
            Pay = 0.0;
        }
    }
}