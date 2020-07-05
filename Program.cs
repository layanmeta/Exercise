using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class Program
    {
        static void PrintApple(Apple pinkLadyApple)
        {
            Console.WriteLine($"The Color Is {pinkLadyApple._color}");
        }
        static void PrintBanana(Banana FreshBanana)
        {
            Console.WriteLine($"The size Is {FreshBanana._size}");
        }
        static void PrintCalories(FruitSalad salad)
        {
            Console.WriteLine($"Amount of calories is {salad.GetTotalCalories()}");
        }

        static void PrintFavorite(FruitSalad salad)
        {
            Console.WriteLine($"My favorite fruit is in salad? {salad.ContainsMyFavoriteFruit()}");
        }

        static FruitSalad CreateSalad(FruitBase[] fruitArray)
        {
            FruitSalad salad = new FruitSalad()
            {
                _fruit = fruitArray
            };

            return salad;
        }

        static void Main(string[] args)
        {
            Apple pinkLadyApple = new Apple()
            {
                _color = "red",
                _pinkLady = true,
                _name = "pinkLadyApple",
                _calories = 10,
            };

            PrintApple(pinkLadyApple);

            Banana FreshBanana = new Banana()
            {
                _hasBlackSpots = false,
                _isGreen = true,
                _size = 7,
                _name = "FreshBanana",
                _calories = 30,
            };

            PrintBanana(FreshBanana);

            Orange citrusOrange = new Orange()
            {
                _name = "citrusOrange",
                _calories = 50,
                _citrus = true,

            };
            Strawberry wildStrawberry = new Strawberry ()
            {
                _name = "wildStrawberry",
                _calories = 20,
                _amount = 2,

            };

            
            FruitSalad salad = new FruitSalad()
            {
                _fruit = new FruitBase[]
                {
                    pinkLadyApple,
                    FreshBanana,
                    citrusOrange,
                    wildStrawberry
                }
            };

            
            FruitBase[] my_fruit_array = new FruitBase[]
                {
                    pinkLadyApple,
                    FreshBanana,
                    citrusOrange,
                    wildStrawberry
                };
            FruitSalad salad2 = new FruitSalad()
            {
                _fruit = my_fruit_array
            };

            PrintCalories(salad);

            PrintFavorite(salad);

            
        }
    }
}
