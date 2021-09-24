using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biosphere
{
    public enum FeedingType
    {
        Herbivorous = 0,
        Carnivorous = 1
    }

    public abstract class Animal
    {
        public Color color { get; }
        public float Speed { get; }
        public float Metabolism { get; }
        public bool Male { get; }
        public FeedingType FeedType { get; }
        
        public Point position { get; private set; }
        public Rectangle Rect { get; }

        public Animal(Color c, float speed, float metabolism, bool male, FeedingType feedType, Point initialPos, Rectangle rect)
        {
            color = c;
            Speed = speed;
            Metabolism = metabolism;
            Male = male;
            FeedType = feedType;
            position = initialPos;
            Rect = rect;
        }

        public abstract float Feed();

        public float Drink()
        {
            return 1;
        }

        public abstract float Move();

        public abstract Animal Mate();
    }
}
