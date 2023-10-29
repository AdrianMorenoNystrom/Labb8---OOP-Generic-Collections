namespace Labb8___OOP_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapar 5 employees

            Employee E1 = new Employee(146,"Adrian","M",27500);
            
            Employee E2 = new Employee(212,"Agnes","F",36000);

            Employee E3 = new Employee(353,"Andreas","M",30000);

            Employee E4 = new Employee(434,"Oliver","M",21000);

            Employee E5 = new Employee(567,"William","M",50000);

            //Skapar en stack med Employee som datatyp(?) då det som skapas kommer använda de som Employee använder.
            Stack<Employee> employees = new Stack<Employee>();
            employees.Push(E1);
            employees.Push(E2);
            employees.Push(E3);
            employees.Push(E4);
            employees.Push(E5);

            Console.WriteLine("Skapat med stack och push\n" +
                "*************************");
            foreach (var employee in employees)
            {
                Console.WriteLine($"Totalt antal anställda i stacken = {employees.Count}");
                Console.WriteLine($"ID: {employee.Id} \nName: {employee.Name} \nGender: {employee.Gender} \nSalary: {employee.Salary}");
                Console.WriteLine("*************************\n");
            }


            Console.WriteLine("Hämtat med POP-metoden\n" +
                "*************************");
            while (employees.Count > 0)
            {
                var employee = employees.Pop();
                Console.WriteLine($"ID: {employee.Id} \nName: {employee.Name} \nGender: {employee.Gender} \nSalary: {employee.Salary}");
                Console.WriteLine($"Totalt antal anställda kvar i stacken = {employees.Count}");
                Console.WriteLine("*************************\n");
            }

            //Lägger tillbaka employees i stacken efter pop-metoden
            employees.Push(E1);
            employees.Push(E2);
            employees.Push(E3);
            employees.Push(E4);
            employees.Push(E5);

            Console.WriteLine("Hämtat med Peek-metoden\n" +
                "*************************");
            int count = 0;
            while (employees.Count > 0)
            {
                var employee = employees.Pop();
                count++;
                Console.WriteLine($"ID: {employee.Id} \nName: {employee.Name} \nGender: {employee.Gender} \nSalary: {employee.Salary}");
                Console.WriteLine($"Totalt antal anställda kvar i stacken = {employees.Count}");
                Console.WriteLine("*************************");
                if (count == 2)
                {

                    if (employees.Peek() == E3)
                    {
                        Console.WriteLine("Objekt nummer 3 finns i stacken\n");
                        var thirdEmployee = employees.Pop();
                        Console.WriteLine($"ID: {thirdEmployee.Id} \nName: {thirdEmployee.Name} \nGender: {thirdEmployee.Gender} \nSalary: {thirdEmployee.Salary}");
                        Console.WriteLine($"Totalt antal anställda kvar i stacken = {employees.Count}");
                        Console.WriteLine("*************************\n");
                    }
                    break;
                }

            }

            Console.WriteLine("Hämtat och utskrivet med list\n" +
                "*************************");
            List<Employee> employees1 = new List<Employee>();
            employees1.Add(E1);
            employees1.Add(E2);
            employees1.Add(E3);
            employees1.Add(E4);
            employees1.Add(E5);

            if (employees1.Contains(E2))
            {
                Console.WriteLine("Employee 2 finns i listan\n");
            }
            else
            {
                Console.WriteLine("Employee 2 finns inte i listan\n");
            }

            var male1 = employees1.Find(employee => employee.Gender == "M");

            if (male1 != null)
            {
                Console.WriteLine($"Första mannen i listan:\n" +
                    $"ID: {male1.Id} \nName: {male1.Name} \nGender: {male1.Gender} \nSalary: {male1.Salary}\n");
            }


            var allMale = employees1.FindAll(employee => employee.Gender == "M");
            Console.WriteLine("Alla män i listan:");
            foreach(var males in allMale)
            {
                Console.WriteLine($"ID: {males.Id} \nName: {males.Name} \nGender: {males.Gender} \nSalary: {males.Salary}\n");


            }
        }
    }
}