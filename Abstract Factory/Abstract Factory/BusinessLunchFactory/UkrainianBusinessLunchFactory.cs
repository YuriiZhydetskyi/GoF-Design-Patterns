using Abstract_Factory.FirstDish;
using Abstract_Factory.Kompots;
using Abstract_Factory.SecondDish;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.BusinessLunchFactory;

public class UkrainianBusinessLunchFactory : IBusinessLunchAbstractFactory
{
    public IFirstDish CreateFirstDish()
    {
        return new Borscht();
    }

    public IKompot CreateKompot()
    {
        return new Kompot();
    }

    public ISecondDish CreateSecondDish()
    {
        return new Varenyky();
    }
}
