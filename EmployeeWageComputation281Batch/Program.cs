using System;
namespace EmployeeWageComputation281Batch
{
    public class Program
    {
        static void Main(String[] args)
        {
            
            Console.WriteLine("Welcome to Employee Wage Computation Problem ");
            EmployeeAttendance employee = new EmployeeAttendance();

            int attendance = employee.Attendance();
            employee.DailyWage(attendance);

            Console.ReadLine();

        }
    }
}