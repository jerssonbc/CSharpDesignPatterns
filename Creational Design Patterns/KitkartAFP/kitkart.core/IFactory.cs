using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitkart.core
{
    public interface IFactory
    {
        IComputer CreateComputer();
        ITablet CreateTablet();
        ISmartPhone CreateSmartPhone();
    }
}
