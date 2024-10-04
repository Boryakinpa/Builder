using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Computer
    {
        public Motherboard Motherboard {  get; set; }
        public RAM RAM {  get; set; }
        public ROM ROM { get; set; }
        public Processor Processor { get; set; }
        public Videocard Videocard { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Motherboard != null)
            {
                sb.Append("Motherboard:\n");
                sb.Append($"-Name: {Motherboard.Name}\n");
                sb.Append("\n");
            }
            if (ROM != null)
            {
                sb.Append("ROM:\n");
                sb.Append($"-Name: {ROM.Name}\n");
                sb.Append($"-Memory: {ROM.Memory}\n");
                sb.Append("\n");
            }
            if (RAM != null)
            {
                sb.Append("RAM:\n");
                sb.Append($"-Name: {RAM.Name}\n");
                sb.Append($"-Memory: {RAM.Memory}\n");
                sb.Append($"-Frequency: {RAM.Frequency}\n");
                sb.Append("\n");
            }
            if (Processor != null)
            {
                sb.Append("Processor:\n");
                sb.Append($"-Name: {Processor.Name}\n");
                sb.Append($"-Frequency: {Processor.Frequency}\n");
                sb.Append("\n");
            }
            if (Videocard != null)
            {
                sb.Append("Videocard:\n");
                sb.Append($"-Name: {Videocard.Name}\n");
                sb.Append($"-Memory: {Videocard.Memory}\n");
                sb.Append($"-Frequency: {Videocard.Frequency}\n");
                sb.Append("\n");
            }

            return sb.ToString();
        }
    }
}
