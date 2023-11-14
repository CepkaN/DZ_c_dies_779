namespace DZ_c_dies_779
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("123000", "Абаков", "Андрей", "программист", "AbraAnad1", "111111");
            Employee emp2 = new Employee("123111", "Варламов", "Константин", "бухгалтер", "Varvar2", "111111");
            Employee emp3 = new Employee("123222", "Кузькина", "Мария", "финансист", "Kyky33", "111111");
            Employee emp4 = new Employee("123333", "Солодуха", "Анна", "техничка", "Solod7", "111111");

            PassSystem PS = new PassSystem();
            //emp1.PROPOUSK();
            PS.RegisterEmployee(emp1);
            PS.RegisterEmployee(emp2);
            PS.RegisterEmployee(emp3);
            PS.RegisterEmployee(emp4);
            //PS.RegisterEmployee();  // регистрация нового сотрудника

            PS.IssuePass();
            try
            {
                PS.AccessControl();
            }catch(Exception ex) { Console.WriteLine(ex.ToString()); }
            //Employee emp5 = new Employee("123444", "Полный", "Иван", "сисадмин", "Poliv", "111111");
            DateTime drrr = DateTime.Now.Date;
            //emp5.MyPass.DATA = drrr; // Тут что-то не то, но я не знаю что 	(￣～￣;)

            PS.PrintEmployeeList();

            
            var B = PS.Sotrudniki.Where(s => Convert.ToString(s.MyPass.GetType()) == "DZ_c_dies_779.TemporaryPass").Select(s => s);

            var W= B.Where(s => s.MyPass.DATA==DateTime.Now.Date).Select(s => s);

            Console.WriteLine(" Сотрудники с временным пропуском : ");
            foreach(var b in W)
            {
                b.Mostrare();
            }
            var D= PS.Sotrudniki.Where(s => Convert.ToString(s.MyPass.GetType()) == "DZ_c_dies_779.PermanentPass").Select(s => s);
            Console.WriteLine(" Сотрудники с постоянным пропуском : ");
            foreach (var d in D)
            {
                d.Mostrare();
            }
        }
    }
}