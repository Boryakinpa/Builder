using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Master
    {
        public Computer Build(ComputerBuilder computerBuilder)
        {
            computerBuilder.CreateComputer();
            computerBuilder.SetMotherboard();
            computerBuilder.SetProcessor();
            computerBuilder.SetRam();
            computerBuilder.SetRom();
            computerBuilder.SetVideocard();
            return computerBuilder.Computer;
        }
    }
}
