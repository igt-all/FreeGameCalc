using System.Diagnostics;

namespace MarkovLibraryCSharp
{
    public class BaseGraph<_NameType> : IDisposable
    {
        //vertex map type
        //vertex set type
        //map used for constructing and examining graph
        protected Dictionary<_NameType, AVertex> _vertexMap = new();

        //vector used in algorithms
        protected List<AVertex> _vertexSet = new();

        //protect constructor
        protected BaseGraph()
        {
        }

        //Destructor
        public void Dispose()
        {
            //Delete the arcs
            clearArcSet();
            //clear the sets (not really necessary but eh, why not)
            _vertexMap.Clear();
            _vertexSet.Clear();
        }

        //assign tempProbabilities to probabilities in any model
        protected void updateProbs()
        {
            foreach (var vertex in _vertexSet)
            {
                vertex.Probability = vertex.TempProbability;
            }
        }

        //Add a vertex to the graph
        public void addVertex(_NameType name, double probability = 0, double pay = 0)
        {
            Console.WriteLine("use inherited class");
        }

        //Set the probability of a vertex
        public void setVertexProb(_NameType name, double probability)
        {
            Debug.Assert(probability >= 0 && probability <= 1);
            _vertexMap[name].Probability = probability;
        }

        //Set the pay of a vertex
        public void setVertexPay(_NameType name, double pay)
        {
            _vertexMap[name].SetPay(pay);
        }

        //Get the current probability of a vertex
        public double getVertexProb(_NameType name)
        {
            return _vertexMap[name].Probability;
        }

        //Get the current pay of a vertex
        public double getVertexPay(_NameType name)
        {
            return _vertexMap[name].Pay;
        }

        //Remove all Arcs from the graph 
        public void clearArcSet()
        {
            foreach (var vertex in _vertexSet)
            {
                vertex.Neighborhood.Clear(); //Clear the neighborhood
            }
        }

        //Reset all vertex values
        public void resetVertexValues()
        {
            foreach (var vertex in _vertexSet)
            {
                vertex.Probability = 0;
                vertex.TempProbability = 0;
                vertex.TempProbability = 0;
                vertex.Pay = 0;
                vertex.TempPay = 0;
            }
        }

        //print current graph probabilities 
        public void printProbabilities(TextWriter writer, string firstSepr, string endSepr)
        {
            for (var index = 0; index < _vertexSet.Count; index++)
            {
                var vertex = _vertexSet[index];
                writer.WriteLine($" {index}  {firstSepr}  {vertex.Probability}  {endSepr}");
            }
        }

        //print current graph pays
        public void printPays(TextWriter writer, string firstSepr, string endSepr)
        {
            for (var index = 0; index < _vertexSet.Count; index++)
            {
                var vertex = _vertexSet[index];
                writer.WriteLine($" {index}  {firstSepr}  {vertex.Pay}  {endSepr}");
            }
        }

        //Reduce a multi-graph to a simple graph 
        public void simplifyGraph()
        {
            //objects
            //List<_VertexType>.Enumerator vertexItr;
            //List<_VertexType>.Enumerator endVertex = _vertexSet.end();
            //List<A>.Enumerator curArc1;
            //List<A>.Enumerator curArc2;
            //List<A>.Enumerator endArc;
            //List<_VertexType.Arc<Vertex>> tempVec = new(); //create tempNeighborhood
            //double tempPay;
            //double tempProb;
            //_VertexType tempNeighbor;
            //MarkovFunctors.ClearNeighborhood<List<_VertexType>.value_type, _VertexType.Arc<Vertex>> CNF = new MarkovFunctors.ClearNeighborhood<List<_VertexType>.value_type, _VertexType.Arc<Vertex>>();

            ////algorithm
            //for (vertexItr = _vertexSet.GetEnumerator(); vertexItr != endVertex; ++vertexItr)
            //{
            //    //sort neighborhood by neighbor to speed up algorithm
            //    //C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
            //    sort(vertexItr._neighborhood.begin(), vertexItr._neighborhood.end(), MarkovFunctors.SortArcByNeighbor<_VertexType.Arc<Vertex>>());
            //    //C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
            //    curArc1 = curArc2 = vertexItr._neighborhood.begin();
            //    //C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
            //    endArc = vertexItr._neighborhood.end();
            //    tempVec.Clear(); //init tempneighborhood
            //    //partition neighborhood into sets S1,S2,...,Sk taking advantage of sorting above
            //    while (curArc2 != endArc)
            //    {
            //        //C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
            //        while (curArc2 != endArc && curArc1._neighbor == curArc2._neighbor)
            //        {
            //            //C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
            //            ++curArc2; //advance
            //        }

            //        tempPay = tempProb = 0;
            //        //C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
            //        tempNeighbor = curArc1._neighbor;
            //        while (curArc1 != curArc2)
            //        {
            //            //C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
            //            tempProb += curArc1._probability; //set temp prob = sum_{a in Si}pa
            //            //C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
            //            ++curArc1;
            //        }

            //        //create new, equivalent simple arc in tempNeighborhood
            //        tempVec.Add(new _VertexType.Arc<Vertex>(tempNeighbor, tempProb));
            //    }

            //    //C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
            //    CNF(vertexItr); //delete all old arcs
            //    //replace neighborhood with simple arcs
            //    //C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
            //    vertexItr._neighborhood.insert(vertexItr._neighborhood.begin(), tempVec.GetEnumerator(), tempVec.end());
            //}
        }
    }
}