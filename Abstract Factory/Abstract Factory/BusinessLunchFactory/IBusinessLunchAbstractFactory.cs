using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.FirstDish;
using Abstract_Factory.Kompots;
using Abstract_Factory.SecondDish;

namespace Abstract_Factory.BusinessLunchFactory;

public interface IBusinessLunchAbstractFactory
{
    IFirstDish CreateFirstDish();
    ISecondDish CreateSecondDish();
    IKompot CreateKompot();
}
