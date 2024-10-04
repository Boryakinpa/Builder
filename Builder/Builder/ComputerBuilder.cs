using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal abstract class ComputerBuilder
    {
        public Computer Computer { get; private set; }
        public void CreateComputer()
        {
            Computer = new Computer();
        }
        public abstract void SetProcessor();
        public abstract void SetVideocard();
        public abstract void SetMotherboard();
        public abstract void SetRam();
        public abstract void SetRom();
    }
}
