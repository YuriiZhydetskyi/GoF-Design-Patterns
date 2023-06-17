using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory;

public abstract class Dish : IDish
{
    public abstract string GetName();
    public void Serve()
        => Console.WriteLine($"Here is your {GetName()}");
}
