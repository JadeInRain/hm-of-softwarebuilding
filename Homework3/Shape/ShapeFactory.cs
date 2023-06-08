using System;

namespace Shape
{
    public class ShapeFactory
    {
        //随机生成长宽高边长等属性
        private Random rand;

        public ShapeFactory()
        {
            rand = new Random();
        }
        public Shape GetShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }

            if (shapeType.Equals("RECTANGLE", StringComparison.OrdinalIgnoreCase))
            {
                return new Rectangle(rand.Next(21), rand.Next(21));
            }
            else if (shapeType.Equals("SQUARE", StringComparison.OrdinalIgnoreCase))
            {
                return new Square(rand.Next(21));
            }
            else if (shapeType.Equals("TRIANGLE", StringComparison.OrdinalIgnoreCase))
            {
                return new Triangle(rand.Next(21), rand.Next(21), rand.Next(21));
            }

            return null;
        }
    }
}
