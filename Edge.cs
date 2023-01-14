using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TriminoV3
{
    public enum Direction {Left, Right, Down}
    public struct Edge
    {
        readonly string value;
        public readonly Direction vector;
        readonly bool isPositive;

        public Edge(string  value1,string value2,bool isPositiveTrimino, int numberEdge)
        {
            isPositive = isPositiveTrimino;
            if(isPositiveTrimino)
            {
                switch(numberEdge)
                {
                    case 1:
                        value = new string(value1 + value2);
                        vector= Direction.Right;
                        break;
                    case 2:
                        value = new string(value1 + value2);
                        vector = Direction.Down;
                        break;
                    case 3:
                        value = new string(value1 + value2);
                        vector = Direction.Left;
                        break;
                }
            }
            else
            {
                switch(numberEdge)
                {
                    case 1:
                        value = new string(value2 + value1);
                        vector= Direction.Left;
                        break;
                    case 2:
                        value= new string(value2 + value1);
                        vector= Direction.Right;
                        break;
                    case 3:
                        value = new string(value2 + value1);
                        vector= Direction.Down;
                        break;
                }
            }
        }
        public bool CompareForAssing(Edge otherEdge, Direction vectorToAssing)
        {
            if (otherEdge.value == value && (otherEdge.vector == vector)&&(vector==vectorToAssing)&&otherEdge.isPositive!=isPositive) return true;

            return false;
        }
    }
}
