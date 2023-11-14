using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_dies_779
{
    internal class PermanentPass : IPass
    {
        public DateTime DATA { get; set; }
        public bool Val { get; set; }
        public PermanentPass()
        {
            Val = true;DATA = new DateTime(2050, 12, 12);
        }

        public bool Validate()
        {
            return Val;
        }
        public void PrintInfo()
        {
            Console.WriteLine(" Постоянный пропуск ");
            if (Val) Console.WriteLine(" Не имеет срока окончания");
            else throw new Exception();
        }
    }
}
