//IGTMarkovMath.h
////////////////////////////////////////////
//IGT Markov Math Library				////
//Original Author: Dustin Stewart		////

namespace MarkovLibraryCSharp
{
    //Arc class that also includes a pay variable 
    public class ArcPay : AArc
    {
        //Constructor 
        public ArcPay(AVertex? neighbor, double probability = 0, double pay = 0)
        {
            //CHECK PROBABILITY IS >=0 and <=1
            if (probability is >= 0 and <= 1)
            {
                Neighbor = neighbor;
                Probability = probability;
                Pay = pay;
            }
            else
            {
                Console.WriteLine($"Probability not in range: {probability}");
            }
        }
    }
}