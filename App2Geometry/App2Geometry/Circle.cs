namespace App2Geometry
{
    public class Circle
    {
        private int _radius = 0;
        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value > 0 && value <= 100)
                {
                    _radius = value;
                    calcArea();
                }
            }
        }

        private int _area = 0;
        public int Area //Readonly property
        {
            get
            {
                return _area;
            }
        }

        public Circle()
        {

        }

        public Circle(int radius)
        {
            _radius = radius;
            calcArea();
        }

        private void calcArea()
        {
            _area = (int)(_radius * (Math.PI * 2));
        }

    }
}
