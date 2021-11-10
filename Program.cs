using System;



namespace propertiesdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee{id=10001, Ename="krishna",Salary=98000};
            Console.Write(employee);
        }
    }
}
