using Abstract_Factory.FirstDish;
using Abstract_Factory.Kompots;
using Abstract_Factory.SecondDish;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.BusinessLunchFactory;

public class JapanBusinessLunchFactory : IBusinessLunchAbstractFactory
{
    public IFirstDish CreateFirstDish()
    {
        return new JapanSoup();
    }

    public IKompot CreateKompot()
    {
        return new Water();
    }

    public ISecondDish CreateSecondDish()
    {
        return new Sushi();
    }
}
