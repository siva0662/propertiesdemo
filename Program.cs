using System;

using System.Collections.Generic;

namespace propertiesdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee{id=10001, Ename="krishna",Salary=98000};
            Console.Write(employee);

            List<Employee> employees =new List<Employee>{
                      new Employee{id =1002,Ename="siva",Salary=69000},
                new Employee{id=1003,Ename="karnati",Salary=96000}
            };
            foreach(Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
            
    }
}
