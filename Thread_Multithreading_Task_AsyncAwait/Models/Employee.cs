using System;
namespace Thread_Multithreading_Task_AsyncAwait.Models
{
	public class Employee
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id}\n Name:{Name}\n Salary:{Salary}");
        }
    }
}

