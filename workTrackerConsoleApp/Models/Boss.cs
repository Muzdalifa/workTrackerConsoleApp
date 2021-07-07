using System;
using System.Collections.Generic;
using System.Text;

namespace workTrackerConsoleApp.Models
{
    class Boss:Employee
    {
        Employee[] manageEmployees;
        public Boss(int id, string name, int salary, Employee[] manageEmployees) :  base(id, name, salary)
        {
            this.manageEmployees = manageEmployees;
        }

        public override string[] WorkTodo()
        {
            string[] workTodo = new string[workLoad.Length];
            workLoad.CopyTo(workTodo, 0); //copy array from index 0
            Array.Resize(ref workTodo, manageEmployees.Length + workTodo.Length);

            int index = workLoad.Length;
            foreach (Employee employee in manageEmployees)
            {
                workTodo[index] = "Manage: " + employee.Name;
                index++;
            }
            return workTodo;
        }
    }
}
