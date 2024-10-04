using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class ConcreteComputer : ComputerBuilder
    {
        public override void SetMotherboard()
        {
            this.Computer.Motherboard = new Motherboard { Name = "BestMother" };
        }

        public override void SetProcessor()
        {
            this.Computer.Processor = new Processor { Name = "CPU1", Frequency = "3.0Ghz" };
        }

        public override void SetRam()
        {
            this.Computer.RAM = new RAM { Name = "BaseRAM", Frequency = "2400Mhz", Memory = "32gb" };
        }

        public override void SetRom()
        {
            this.Computer.ROM = new ROM { Name = "AllNeedSSD", Memory = "1024gb", Type = "SSD" };
        }

        public override void SetVideocard()
        {
            this.Computer.Videocard = new Videocard { Name = "RTX9090", Memory = "72gb", Frequency = "1.0Ghz" };
        }
    }
}
