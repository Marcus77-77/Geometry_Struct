namespace App2Geometry
{
    public class Rectangle
    {
        private int _width = 0;
        public int Width
        { 
            get { return _width; }
            set 
            { 
                _width = value;
                calcArea();
            }
        }

        private int _height = 0;
        public int Height
        {
            get { return _height; }
            set
            {
                _height = value;
                calcArea();
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

        public Rectangle()
        {

        }

        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
            calcArea();
        }

        private void calcArea()
        { 
            _area = _width * _height;
        }
    }
}
