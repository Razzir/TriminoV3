using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TriminoV3
{
    enum Direction {Left, Right, Down}
    public struct Edge
    {
        public string value;
        readonly Direction vector;
        public Edge(string  value1,string value2,bool isPositiveTrimino, int numberEdge)
        {
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
        public bool CompareForEquals(Edge otherEdge)
        {
            if (otherEdge.value == value && otherEdge.vector == vector) return true;

            return false;
        }
    }
}
