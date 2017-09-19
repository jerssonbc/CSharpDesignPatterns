using System;

namespace kitkart.core
{
    public class ClientAFactory:IFactory
    {
        public void CreateCompute()
        {
            Console.WriteLine("ClientA Computer is created.");
        }
    }
}
