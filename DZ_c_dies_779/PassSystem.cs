using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_dies_779
{
    public delegate void PPPPPP(Object OOO);
    internal class PassSystem
    {
        public List<Employee> Sotrudniki;
        public event PPPPPP Prrr;
        public PassSystem()
        {
            Sotrudniki= new List<Employee>();
        }
        public void RegisterEmployee(Employee emp)
        {
            Prrr?.Invoke(this);
            Sotrudniki.Add(emp);
        }
        public void RegisterEmployee()
        {
            Console.WriteLine(" Введите ID : ");
            string? ID = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" Введите фамилию : ");
            string? LN = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" Введите имя : ");
            string? FN = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" Введите должность : ");
            string? P = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" Введите логин : ");
            string ?L = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" Введите пароль : ");
            string? Pass = Convert.ToString(Console.ReadLine());
            Employee emp = new Employee(ID, LN, FN, P, L, Pass);
            emp.PROPOUSK();
            RegisterEmployee(emp);
            Console.WriteLine(" Сотрудник зарегистрирован .");
        }

        public void IssuePass()
        {
            foreach(var SOT in Sotrudniki)
            {
                SOT.PROPOUSK();
            }
        }
        public void AccessControl()
        {
            foreach(var S in Sotrudniki)
            {
                Console.WriteLine(S.FirstName + "  " + S.LastName);
                S.MyPass.PrintInfo();
                Console.WriteLine();
            }
        }
        public void PrintEmployeeList()
        {
            foreach(var S in Sotrudniki)
            {
                S.Mostrare();
            }
        }
    }
}
