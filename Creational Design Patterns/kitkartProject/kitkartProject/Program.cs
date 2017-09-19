using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kitkart.core;
namespace kitkartProject
{
    class Program
    {
        static void Main(string[] args)
        {
            KitkartManufacturingCompany factoryCompany = new ConcreteKitkart();

            IFactory clientAComputer = factoryCompany.GetComputer("A");
            clientAComputer.CreateCompute();

            IFactory clientBComputer = factoryCompany.GetComputer("B");
            clientBComputer.CreateCompute();

            Console.ReadKey();
        }
    }
}
