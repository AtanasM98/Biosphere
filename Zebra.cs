using System;
using System.Drawing;

namespace Biosphere
{
    public class Zebra : Animal
    {
        public Zebra(float speed, float metabolism, bool male, Point initialPos, Rectangle rect) 
            : base(Color.WhiteSmoke, speed, metabolism, male, FeedingType.Herbivorous, initialPos, rect)
        {
        }

        public override float Feed()
        {
            throw new NotImplementedException();
        }

        public override Animal Mate()
        {
            throw new NotImplementedException();
        }

        public override float Move()
        {
            throw new NotImplementedException();
        }
    }
}
