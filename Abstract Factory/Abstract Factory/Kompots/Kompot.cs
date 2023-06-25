using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Kompots;

public class Kompot : Dish, IKompot
{
    public override string GetName()
    {
        return "Kompot";
    }
}
