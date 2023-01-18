using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TriminoV3
{
    public enum Direction {Right, Down, Left }
    public struct Edge
    {
        public readonly string value;
        public readonly Direction vector;
        public readonly bool isPositive;

        public Edge (string value1, string value2, Direction addedVector, bool isPositive)
        {
            value = (value1 + value2);
            vector = addedVector;
            this.isPositive = isPositive;
        }


       /* public Edge(string  value1,string value2,bool isPositiveTrimino, int numberEdge)
        {
            isPositive = isPositiveTrimino;
            if(isPositiveTrimino)
            {
                switch(numberEdge)
                {
                    case 0:
                        value = new string(value1 + value2);
                        vector= Direction.Right;
                        break;
                    case 1:
                        value = new string(value1 + value2);
                        vector = Direction.Down;
                        break;
                    case 2:
                        value = new string(value1 + value2);
                        vector = Direction.Left;
                        break;
                }
            }
            else
            {
                switch(numberEdge)
                {
                    case 0:
                        value = new string(value2 + value1);
                        vector= Direction.Left;
                        break;
                    case 1:
                        value= new string(value2 + value1);
                        vector= Direction.Right;
                        break;
                    case 2:
                        value = new string(value2 + value1);
                        vector= Direction.Down;
                        break;
                }
            }

            
        }
       */
        
    }
}
