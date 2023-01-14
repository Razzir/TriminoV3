using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriminoV3
{
    public struct PlaceDataContainer
    {
        public readonly Trimino encapsulatedTrimino;
        public readonly Direction encapsulatedDirection;
        public PlaceDataContainer(Trimino enkapTrimino, Direction enkapDirection)
        {
            encapsulatedTrimino= enkapTrimino;
            encapsulatedDirection= enkapDirection;
        }
    }
}
