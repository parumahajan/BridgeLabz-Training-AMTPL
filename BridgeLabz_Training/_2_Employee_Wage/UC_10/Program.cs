using System;

namespace BridgeLabz_Training._2_Employee_Wage.UC_10
{

    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);

            empWageBuilder.computeEmpWage();
        }
    }
}