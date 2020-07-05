using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    abstract class FruitBase
    {
        public string _name;
        public int _calories;

        public abstract bool IsThisMyFavorite(); 

        public override string ToString()
        {
            return $"Name of the fruit is {_name}, It has {_calories} amount of calories.";
        }
    }

}
