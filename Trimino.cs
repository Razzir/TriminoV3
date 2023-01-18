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
        internal List<Edge> edges = new List<Edge>();
        public bool charge;
        int krenPoint;

        public Trimino(int point1, int point2, int point3, bool charge = true) => points = new int[] { point1, point2, point3 } ;
      
        public void RollLeft(int count = 1)
        {
            for(int i = 0; i < count;i++) krenPoint++;
        }
        public void RollRight() =>RollLeft(2);

        public void PrepareToPlace(bool isPositive)// isPositive - it's charge of trimino's to assing
        {
            krenPoint = krenPoint % 3;
            int _firstIndex = krenPoint;
            int _secondIndex = krenPoint+1;
            if (isPositive) _firstIndex+= 2;
            for(int i = 0;i<3;i++,_firstIndex++,_secondIndex++)
            {
                Edge createdEdge = new Edge(points[_firstIndex%3].ToString(), points[_secondIndex%3].ToString(), (Direction)i,isPositive);
                edges.Add(createdEdge);
            }


            /* if (isPositive) charge = false; else charge = true;
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
            */

        } 
    }
}
