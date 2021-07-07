using System;
using System.Collections.Generic;
using workTrackerConsoleApp.Models;

namespace workTrackerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person(1, "Ulf" ));
            people.Add(new Employee( 2, "Kent", 12345 ));

            //LoopOverrideDif(people);

            EmployeeWorks();

            ////Test List
            //List<int> x = new List<int>();
            //x.Add(1);
            //x.Add(3);
            //x.Add(5);

            //foreach (int item in x)
            //{
            //    Console.WriteLine(item);
            //}
        }
           
        static void EmployeeWorks()
        {
            Employee employee = new Employee(2,"Kent",12345);

            employee.AddworkTask("Code C#");
            employee.AddworkTask("Make cofee");
            employee.AddworkTask("Drink cofee");
            employee.AddworkTask("code C# fatser/more");

            //foreach (string work in employee.WorkTodo())
            //{
            //    Console.WriteLine("Work with: " + work);
            //}
            //Console.WriteLine("----------- boss work ------------------");

            Employee[] workers = new Employee[1];
            workers[0] = employee;

            Boss boss = new Boss(2, "Jonas", 12345, workers);

            boss.AddworkTask("Code C#");
            boss.AddworkTask("Make cofee");
            boss.AddworkTask("Drink cofee");
            boss.AddworkTask("code C# fatser/more");

            //foreach (string work in boss.WorkTodo())
            //{
            //    Console.WriteLine("Work with: " + work);
            //}

            List<Employee> employees = new List<Employee>() { employee, boss };

            foreach (Employee worker in employees)
            {
                Console.WriteLine(worker.Name);

                foreach (string work in worker.WorkTodo())
                {
                    Console.WriteLine("Work with: " + work);
                }
            }
        }

        static void LoopOverrideDif(List<Person> people)
        {
                Console.WriteLine("Just loop over people and get the Info");
                foreach (Person person in people)
                {
                    Console.WriteLine(person.Info());
                }
                Console.WriteLine("\n\n Loop but check if employee ");

                foreach (Person person in people)
                {
                    if (person is Employee)
                    {
                        Console.WriteLine((person as Employee).Info());
                    }
                    else
                    {
                        Console.WriteLine(person.Info());
                    }
                }
        }

        

       
        
    }
}
