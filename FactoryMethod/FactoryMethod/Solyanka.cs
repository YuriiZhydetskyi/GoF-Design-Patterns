using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Solyanka : Dish
    {
        public Solyanka()
        {
            Description = "Solyanka is a thick and sour soup of Russian origin that is common in Russia, Ukraine, Belarus";
            Ingredients = new List<string>()
            {
                "Water",
                "Carrot",
                "Pork",
                "Onion",
                "Lemon"
            };
        }
        public Solyanka(List<string> ingredients)
        {
            Description = "Solyanka is a thick and sour soup of Russian origin that is common in Russia, Ukraine, Belarus";
            Ingredients = ingredients;
        }
        public override void Eat()
        {
            Console.WriteLine("You need spoon to eat solyanka");
        }

        public static List<string> GetEssentialIngredients()
        {
            return new List<string>();
        }

        public override string GetUaName()
        {
            return "Солянка";
        }
    }
}
