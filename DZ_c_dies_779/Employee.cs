using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_dies_779
{
    internal class Employee
    {
        public string EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public IPass MyPass { get; set; } 
        public Employee(string ID,string LN,string FN,string P,string L,string Pass)
        {
            EmployeeId= ID;LastName= LN;FirstName= FN;Position= P;Login= L;Password = Pass;
            
        }
        public void PROPOUSK()
        {
            Random rn = new Random();
            int a = rn.Next(1, 100);
            if (a % 2 != 0)
            {
                Random random = new Random();
                int n1 = rn.Next(1, 30);
                int n2 = rn.Next(1, 12);
                DateTime Dt = new DateTime(2023, n2, n1);
                MyPass = new TemporaryPass(Dt);
            }
            else { MyPass = new PermanentPass(); }
        }
        public void Mostrare()
        {
            Console.WriteLine("----------\n ID : " + EmployeeId + "\n Фамилия : " + LastName + "\n Имя : " + FirstName + "\n Должность : " + Position + "\n Пароль : " + Password + "\n-------");
        }

    }
}
