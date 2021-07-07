using System;
using System.Collections.Generic;
using System.Text;

namespace workTrackerConsoleApp.Models
{
    class Employee : Person
    {
        int salary;
        public int Salary { get { return salary; } set { salary = value; } }

        protected string[] workLoad;
        public Employee(int id, string name, int salary): base(id ,name) //set id and name to the base class first
        {                                                                //when it done, child will set my workload and salary here
            workLoad = new string[0];
            this.salary = salary;
        }

        public virtual string[] WorkTodo()
        {
            return workLoad;
        }

        public void AddworkTask(string newTask)
        {
            Array.Resize(ref workLoad, workLoad.Length + 1);
            workLoad[workLoad.Length - 1] = newTask;
        }
        public new string Info()  //new keyword override the info() from base class
        {
            return base.Info() + $"Salary: {salary} per/month\n";
        }
    }
    
}
