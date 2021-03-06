﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitkart.core
{
    public class ClientBFactory:IFactory
    {
        public IComputer CreateComputer()
        {
            return  new ClientBComputer();
        }

        public ITablet CreateTablet()
        {
            return new ClientBTablet();
        }

        public ISmartPhone CreateSmartPhone()
        {
           return new ClientBSmartPhone();
        }
    }
}
