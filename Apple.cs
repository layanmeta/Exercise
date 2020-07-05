using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class Apple : FruitBase
    {
        public string _color;
        public bool _pinkLady;

        public override bool IsThisMyFavorite()
        {
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + $"the color is {_color} and the type is {_pinkLady}";
        }
    }

}
