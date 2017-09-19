using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitkart.core
{
    public abstract class KitkartManufacturingCompany
    {
        public abstract IFactory GetComputer(string clientName);
    }
}
