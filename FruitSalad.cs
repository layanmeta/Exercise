using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class FruitSalad
    {
        public FruitBase[] _fruit;

        public int GetTotalCalories()
        {

            int sum = 0;
            for (int i = 0; i < _fruit.Length; i++)
            {
                sum = sum + _fruit[i]._calories;
            }

            return sum;

        }
        public bool ContainsMyFavoriteFruit()
        {
            for (int i = 0; i < _fruit.Length; i++)
            {
                if (_fruit[i].IsThisMyFavorite())
                {

                    return true;
                }

            }
            return false;

           
        }

        public override string ToString()
        {
            String result = "\n";
            for (int i = 0; i < _fruit.Length; i++)
            {
                result = result + _fruit[i].ToString() + "\n";
            }
            return result;
        }
    }
}
