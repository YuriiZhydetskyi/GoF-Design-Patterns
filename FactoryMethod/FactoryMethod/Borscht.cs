using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Borscht : Dish
    {
        public Borscht()
        {
            Description = "Borscht is a sour soup common in Eastern Europe and Northern Asia.";
            Ingredients = new List<string>()
            {
                "Red beetroot",
                "Water",
                "Carrot",
                "Pork",
                "Onion",
                "Potatos"
            };
        }
        public Borscht(List<string> ingredients)
        {
            Description = "Borscht is a sour soup common in Eastern Europe and Northern Asia.";
            Ingredients = ingredients;
        }
        public override void Eat()
        {
            Console.WriteLine("You need spoon to eat borscht");
        }

        public static List<string> GetEssentialIngredients()
        {
            return new List<string>
            {
                "Red beetroot",
                "Water",
                "Pork"
            };
        }

        public override string GetUaName()
        {
            return "Борщ";
        }

    }
}
