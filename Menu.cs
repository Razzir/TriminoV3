namespace TriminoV3
{
    
    internal class Menu
    {
        public bool CompareForAssing(Edge selectedEdge, Edge otherEdge, Direction vectorToAssing)
        {
            bool CompareValueRes = selectedEdge.value.Equals(otherEdge.value);
            bool CompareVectorRes = selectedEdge.vector.Equals(otherEdge.vector);
            bool CompareDifferenceCharge;
            if (selectedEdge.isPositive != otherEdge.isPositive) CompareDifferenceCharge = true; else CompareDifferenceCharge = false;
            if (CompareDifferenceCharge && CompareValueRes && CompareVectorRes && selectedEdge.vector.Equals(vectorToAssing)) return true;
            return false;
        }
        static void Main(string[] args)
        {
           
        }
    }
}