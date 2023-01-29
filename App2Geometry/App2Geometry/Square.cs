using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2Geometry
{
    public class Square
    {
        private int _side = 0;
        public int Side
        { 
            get 
            { 
                return _side;
            }
            set 
            {
                if (value > 0 && value <= 100)
                {
                    _side = value;
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

        public Square()
        {

        }

        public Square(int side)
        {
            _side = side;
            calcArea();
        }

        private void calcArea()
        {
            _area = _side * _side;
        }

        public void SetSide(int side)
        {
            _side = side;
            calcArea();
        }
    }
}
