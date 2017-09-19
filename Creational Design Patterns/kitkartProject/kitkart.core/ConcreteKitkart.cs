using System;

namespace kitkart.core
{
    public class ConcreteKitkart:KitkartManufacturingCompany
    {
        public override IFactory GetComputer(string clientName)
        {
            switch (clientName)
            {
                case "A":
                     return new ClientAFactory();
                case "B":
                    return new ClientBFactory();
                default:
                    throw new ApplicationException("Sorry, we cannot create computer");
            }
        }
    }
}
