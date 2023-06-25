using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class PizzaQuattroFormaggi : Dish
    {
        public PizzaQuattroFormaggi() 
        {
            Description = "topped with a combination of four kinds of cheese";
            Ingredients = new List<string>()
            {
                "Pizza body",
                "4 kinds of cheese"
            };
        }
        public PizzaQuattroFormaggi(List<string> ingredients) 
        {
            Description = "topped with a combination of four kinds of cheese";
            Ingredients = ingredients;
        }
        public static List<string> GetEssentialIngredients()
        {
            return new List<string>
            {
                "Pizza body",
                "4 kinds of cheese"
            };
        }
        public override void Eat()
        {
            Console.WriteLine("You can eat it by your hands");
        }

        public override string GetUaName()
        {
            return "Піца 4 сири";
        }
    }
}
