using System;
using System.Collections.Generic;

namespace Thread_Multithreading_Task_AsyncAwait.Models
{
	public class Department
	{
        public int Id { get; set; }
        public string Name { get; set; }
        List<Employee> Employee = new List<Employee>();

        public void AddEmployee()
        {
            Convert.(Employee.Add());
        }
    }
}

