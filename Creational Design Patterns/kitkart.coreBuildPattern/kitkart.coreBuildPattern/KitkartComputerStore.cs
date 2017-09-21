using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitkart.coreBuildPattern
{
    public class KitkartComputerStore
    {
        public Computer Build(ComputerBuilder builder)
        {
            builder.SetCores();
            builder.SetCpuFrequency();
            builder.SetRam();
            builder.SetDriveType();

            return builder.GetComputer();
        }
    }
}
