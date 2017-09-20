using System;

namespace kitkart.core
{
    public class ClientAFactory:IFactory
    {
        public IComputer CreateComputer()
        {
            return new ClientAComputer();
        }

        public ITablet CreateTablet()
        {
            return new ClientATablet();
        }

        public ISmartPhone CreateSmartPhone()
        {
            return new ClientASmartPhone();
        }
    }
}
