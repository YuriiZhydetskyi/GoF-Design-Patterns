using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Oven
    {
        public Dish CookDish(List<string> ingredients)
        {
            if (Borscht.GetEssentialIngredients().All(s => ingredients.Contains(s)))
            {
                return new Borscht(ingredients);
            }
            else if (PizzaQuattroFormaggi.GetEssentialIngredients().All(s => ingredients.Contains(s)))
            {
                return new PizzaQuattroFormaggi(ingredients);
            }
            else
            {
                return new Solyanka(ingredients);
            }
        }
    }
}

