using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.FirstDish;

public class Borscht : Dish, IFirstDish
{
    public override string GetName()
    {
        return "Borsch";
    }
}
