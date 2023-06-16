using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal abstract class Dish
    {
        public string Description { get; set; }
        public List<string> Ingredients { get; set; }

        public abstract void Eat();
        public abstract string GetUaName();

    }
}
