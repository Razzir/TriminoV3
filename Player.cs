using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriminoV3
{
    internal class Player
    {
        public string Name { get; set; }
        List<Trimino> hand;
        public Trimino selectedTrimino;

        public void SelectTrimino(int index)
        {
            selectedTrimino = hand[index];
        }

        public void LinkStartHand(List<Trimino> createdHand)
        {
            hand = createdHand;
        }

        public bool Place(PlaceDataContainer[] triminoNerbyPosition)
        {
            foreach(PlaceDataContainer container in triminoNerbyPosition)
            {
                bool chargeOfContainer = container.encapsulatedTrimino.charge;
                selectedTrimino.PrepareToPlace(chargeOfContainer);
                bool result = TryToAssing(selectedTrimino, container.encapsulatedTrimino, container.encapsulatedDirection);
                if (result) return true;
            }
            return false;
        }
        public bool TryToAssing(Trimino selectedTrimino,Trimino otherTrimino, Direction choosedDirection)
        {
            foreach (Edge edge in otherTrimino.edges)
            {
                foreach (Edge edgeThis in selectedTrimino.edges)
                {
                    if (CompareForAssing(edgeThis, edge, choosedDirection)) return true;
                }
            }
            selectedTrimino.edges.Clear();
            return false;
        }

        public void DeleteEdgeByDirection(Trimino manipulatedTrimino,Direction vectorToDelete)
        {
            foreach (var edge in manipulatedTrimino.edges)
            {
                if (edge.vector == vectorToDelete) manipulatedTrimino.edges.Remove(edge);
            }
        }
        public bool CompareForAssing(Edge selectedEdge, Edge otherEdge, Direction vectorToAssing)
        {
            bool CompareValueRes = selectedEdge.value.Equals(otherEdge.value);
            bool CompareVectorRes = selectedEdge.vector.Equals(otherEdge.vector);
            bool CompareDifferenceCharge;
            if (selectedEdge.isPositive != otherEdge.isPositive) CompareDifferenceCharge = true; else CompareDifferenceCharge = false;
            if (CompareDifferenceCharge && CompareValueRes && CompareVectorRes && selectedEdge.vector.Equals(vectorToAssing)) return true;
            return false;
        }
    }
}
