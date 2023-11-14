using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_dies_779
{
    internal interface IPass
    {
        public DateTime DATA { get; set; }

        public bool Validate();
        public void PrintInfo();
    }
}
