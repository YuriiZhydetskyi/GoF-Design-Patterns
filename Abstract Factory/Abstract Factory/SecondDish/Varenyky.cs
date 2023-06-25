using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.SecondDish;

public class Varenyky : Dish, ISecondDish
{
    public override string GetName()
    {
        return "Varenyky";
    }
}
