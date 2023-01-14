using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TriminoV3
{
    public class Trimino
    {
        private int[] points;
        private List<Edge> edges;
        private bool charge;
        private int[] orderEdge = new int[] { 0, 1, 2 };

        public Trimino(int point1, int point2, int point3) => points = new int[]{point1,point2,point3};
      
        public void RollLeft(int count = 1)
        {
            while (count-- > 0)
            {
                orderEdge = new int[] { orderEdge[1], orderEdge[2], orderEdge[0] };
            }
        }
        public void RollRight() =>RollLeft(2);

        public void PrepareToPlace(bool charge = true)
        {
            foreach(var order in orderEdge)
            {
                string _value1, _value2;
                if(order==2)
                {
                    _value1 = new string( points[order].ToString());
                    _value2 = new string (points[0].ToString());
                }
                else
                {
                    _value1= new string(points[order].ToString());
                    _value2= new string(points[order+1].ToString());
                }
                Edge _edgeToAdd = new Edge(_value1, _value2, charge, order);
                edges.Add(_edgeToAdd);
            }
        }

        public bool TryToAssing(Trimino otherTrimino, Direction choosedDirection)
        {
            this.PrepareToPlace(!(otherTrimino.charge));
            foreach(var edge in edges)
            {
                foreach(var edgeThis in this.edges)
                {
                   if( edgeThis.CompareForAssing(edge, choosedDirection)) return true;
                }
            }
            return false;
        }
        public void DeleteEdgeByDirection(Direction vectorToDelete)
        {
            foreach(var edge in edges) 
            {
                if(edge.vector==vectorToDelete) edges.Remove(edge);
            }
        }
    }
}
