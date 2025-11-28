using System;

namespace BridgeLabz_Training._2_Employee_Wage.UC_2
{

    class Program
    {
        static void Main(string[] args)
        {
            int isFullTime = 1;

            int EmpRatePerHour = 20;

            int EmpHours = 0;
            int EmpWage = 0;

            Random rndm = new Random();

            int EmpCheck = rndm.Next(0, 1);

            if (EmpCheck == isFullTime)
            {
                EmpHours = 8;
            }
            else
            {
                EmpHours = 4;
            }

            EmpWage = EmpHours * EmpRatePerHour;

            Console.WriteLine("Employee wage is: " + EmpWage); //
        }
    }
}