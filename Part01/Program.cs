namespace Part01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region take the size of array
            int Size;
            bool Flag =true;
            do
            {
                Console.WriteLine("Enter the Size of Employees Array ");
                Flag = int.TryParse(Console.ReadLine(), out Size);
            }
            while (!Flag);
            #endregion

            Employee[] Employees =new Employee[Size];

            #region fill array
            for (int i = 0; i < Size; i++) 
            {
                Employees[i] = new Employee();
                Console.WriteLine($"Fill  Employee {i+1}Data");

                Console.WriteLine($"Enter Employee{i+1} ID ");
                Employees[i].Id = int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter Employee{i + 1} Salary ");
                Employees[i].Salary = int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter Employee{i + 1} Gender ");
                Employees[i].Gender = Console.ReadLine().ToLower();

                HireDate Hire=new HireDate();

                Console.WriteLine($"Enter Employee{i + 1} Hiring Date Day ");
                Hire.Day = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter Employee{i + 1} Hiring Date Month ");
                Hire.Month = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter Employee{i + 1} Hiring Date year ");
                Hire.Year = int.Parse(Console.ReadLine());

                Employees[i].HiringDate=Hire;

            }
            #endregion

            #region SortingArray
            Employees.SortBasedOnHiringDate();
            #endregion

            #region printSortedArray
            foreach (Employee employee in Employees) 
            {
                Console.WriteLine(employee.ToString());
            }
            #endregion
        }
    }
}
