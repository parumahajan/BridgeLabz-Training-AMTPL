using System;

namespace BridgeLabz_Training._2_Employee_Wage.UC_9
{

    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);

            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());

            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}