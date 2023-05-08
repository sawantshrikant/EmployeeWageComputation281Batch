using System;

namespace EmployeeWageComputation281Batch
{
    internal class EmployeeAttendance
    {
        const int IS_PRESENT = 1;
        const int WAGE_PER_HR = 20;
        const int FULL_TIME_HRS = 8;
        const int PART_TIME_HRS = 4;
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;

        public int Attendance()
        {
            Random random = new Random();
            int check = random.Next(0, 3);
            return check;
        }

        public void DailyWage(int attendance)
        {
            int wage = 0;
            int workingHrs = 0;

            if (attendance == IS_PRESENT)
            {
                int empType = new Random().Next(0, 3);

                switch (empType)
                {
                    case IS_FULL_TIME:
                        Console.WriteLine("Employee Is Full-Time");
                        workingHrs = FULL_TIME_HRS;
                        break;
                    case IS_PART_TIME:
                        Console.WriteLine("Employee Is Part-Time");
                        workingHrs = PART_TIME_HRS;
                        break;
                    default:
                        Console.WriteLine("Invalid Employee Type");
                        break;
                }

                wage = WAGE_PER_HR * workingHrs;
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
            }

            Console.WriteLine("Daily wage of an employee is: " + wage);
        }
    }
}
