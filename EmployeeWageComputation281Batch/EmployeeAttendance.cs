using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation281Batch
{
    internal class EmployeeAttendance
    {
        const int IS_PRESENT = 1;
        public void attendance()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == IS_PRESENT)
                Console.WriteLine("Employee Is Present");
            else
                Console.WriteLine("Employee Is Absent");
        }

    }
}
