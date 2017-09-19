using System;

namespace kitkart.core
{
    public class ClientBFactory:IFactory
    {
        public void CreateCompute()
        {
            Console.WriteLine("ClientB Computer is created");
        }
    }
}
