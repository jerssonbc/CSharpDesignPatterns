using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitkart.core
{
    public class KitkartManufacturingCompany
    {
        private readonly IFactory _factory;
        private readonly List<IComputer> _computers;
        private readonly List<ITablet> _tablets;
        private readonly List<ISmartPhone> _smartPhones;


        public IEnumerable<IComputer> Computers { get { return _computers.ToArray(); } }
        public IEnumerable<ITablet> Tablets { get { return _tablets.ToArray(); } }
        public IEnumerable<ISmartPhone> SamSmartPhones { get { return _smartPhones.ToArray(); } }

        public KitkartManufacturingCompany(IFactory factory)
        {
            _factory = factory;
            _computers = new List<IComputer>();
            _tablets = new List<ITablet>();
            _smartPhones = new List<ISmartPhone>();
        }

        public void Produce(Order order)
        {
            CreateComputers(order.Computers);
            CreateTablets(order.Tablets);
            CreateSmartPhones(order.SmartPhones);
        }

        public void CreateComputers(int count)
        {
            while (_computers.Count < count)
            {
                _computers.Add(_factory.CreateComputer());
            }
        }

        public void CreateTablets(int count)
        {
            while (_tablets.Count < count)
            {
                _tablets.Add(_factory.CreateTablet());
            }
        }

        public void CreateSmartPhones(int count)
        {
            while (_smartPhones.Count < count)
            {
                _smartPhones.Add(_factory.CreateSmartPhone());
            }
        }
    }
}
