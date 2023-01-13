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
        public string Value;
        readonly Direction Vector;
        public Edge(string  value1,string value2,bool isPositiveTrimino, int numberEdge)
        {
            if(isPositiveTrimino)
            {
                switch(numberEdge)
                {
                    case 1:
                        Value = new string(value1 + value2);
                        Vector= Direction.Right;
                        break;
                    case 2:
                        Value = new string(value1 + value2);
                        Vector = Direction.Down;
                        break;
                    case 3:
                        Value = new string(value1 + value2);
                        Vector = Direction.Left;
                        break;
                }
            }
            else
            {
                switch(numberEdge)
                {
                    case 1:
                        Value = new string(value2 + value1);
                        Vector= Direction.Left;
                        break;
                    case 2:
                        Value= new string(value2 + value1);
                        Vector= Direction.Right;
                        break;
                    case 3:
                        Value = new string(value2 + value1);
                        Vector= Direction.Down;
                        break;
                }
            }
        }
        public bool CompareForEquals(Edge otherEdge)
        {
            if (otherEdge.Value == Value && otherEdge.Vector == Vector) return true;

            return false;
        }
    }
}
