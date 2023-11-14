using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_dies_779
{
    internal class TemporaryPass: IPass
    {
        public DateTime DATA { get; set; }
        public bool Val { get; set; }
        public TemporaryPass(DateTime dATA)
        {
            DATA = dATA;Val = false;
        }
        public bool Validate()
        {
            DateTime dt= DateTime.Now;
            if (DATA > dt)
            {
                Val= true;
            }
            return Val;
        }
        public void PrintInfo()
        {
            Console.WriteLine(" Временный пропуск , дата окончания : " + DATA.ToString());
            if (Validate())
            {
                Console.WriteLine(" Пропуск действует ");
            }else
                Console.WriteLine(" Пропуск не действует ");

        }
    }
}
