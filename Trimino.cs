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
        private Edge[] positiveEdges;
        private Edge[] reversEdges;

        private int[] orderEdge = new int[] { 1, 2, 3 };

        public Trimino(int point1, int point2, int point3) => points = new int[]{point1,point2,point3};
      
        public void RollLeft(int count = 1)
        {
            while (count-- > 0)
            {
                orderEdge = new int[] { orderEdge[1], orderEdge[2], orderEdge[0] };
            }
        }
        public void RollRight() =>RollLeft(2);
    }
}
