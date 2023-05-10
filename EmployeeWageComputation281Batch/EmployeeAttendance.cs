using System;

namespace EmployeeWageComputation281Batch
{
    internal class EmployeeAttendance
    {
        private const int IS_PRESENT = 1;
        private const int WAGE_PER_HR = 20;
        private const int FULL_TIME_HRS = 8;
        private const int PART_TIME_HRS = 4;
        private const int IS_FULL_TIME = 1;
        private const int IS_PART_TIME = 2;
        private const int WORKING_DAYS = 20;
        private const int MAX_WORKING_HRS = 100;

        public int Attendance()
        {
            Random random = new Random();
            int check = random.Next(0, 3);
            return check;
        }

        public void DailyWage(int attendance)
        {
            int totalWage = 0;
            int workingHrs = 0;
            int totalWorkingDays = 0;
            int totalWorkingHrs = 0;

            if (attendance == IS_PRESENT)
            {
                while (totalWorkingDays < WORKING_DAYS && totalWorkingHrs < MAX_WORKING_HRS)
                {
                    totalWorkingDays++;
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

                    if (totalWorkingHrs + workingHrs <= MAX_WORKING_HRS)
                    {
                        int wage = WAGE_PER_HR * workingHrs;
                        Console.WriteLine("Daily wage of an employee on day " + totalWorkingDays + " is: " + wage);
                        totalWage += wage;
                        totalWorkingHrs += workingHrs;
                    }
                    else
                    {
                        workingHrs = MAX_WORKING_HRS - totalWorkingHrs;
                        int wage = WAGE_PER_HR * workingHrs;
                        Console.WriteLine("Daily wage of an employee on day " + totalWorkingDays + " is: " + wage);
                        totalWage += wage;
                        totalWorkingHrs += workingHrs;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
            }

            Console.WriteLine("Total wage for the month is: " + totalWage);
            Console.WriteLine("Total working hours for the month is: " + totalWorkingHrs);
            Console.WriteLine("Total working days for the month is: " + totalWorkingDays);
        }
    }
}