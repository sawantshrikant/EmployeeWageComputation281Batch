using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation281Batch
{
    internal class EmployeeAttendance
    {
        const int IS_PRESENT = 1, WAGE_PER_HR = 20, NO_OF_HRS = 8;
        public int attendance()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == IS_PRESENT)
                Console.WriteLine("Employee Is Present");
            else
                Console.WriteLine("Employee Is Absent");
            return check;
           
        }

        public void DailyWage(int name)
        {
            int wage = 0;
            
            if (name == IS_PRESENT)
                wage = WAGE_PER_HR * NO_OF_HRS;
            Console.WriteLine("Daily wage of an employee is: " + wage);

           
        }

    }
}
