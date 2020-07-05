using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class Banana : FruitBase
    {
        public bool _hasBlackSpots;
        public bool _isGreen;
        public float _size;

        public override bool IsThisMyFavorite()
        {
            return true;
        }

        public override string ToString()
        {
            return base.ToString() + $"banana {_hasBlackSpots}. {_isGreen}, and size of {_size} inches.";
        }
    }
}
