using System;

namespace BridgeLabz_Training._2_Employee_Wage.UC_10
{

    public class Emp_Wage_Builder_Array
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }

        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                CompanyEmpWage companyEmpWage = this.companyEmpWageArray[i];
                int totalWage = this.computeEmpWage(companyEmpWage);
                companyEmpWage.setTotalEmpWage(totalWage);
                Console.WriteLine(companyEmpWage.ToString());
            }
        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            // Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            // Computation
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;

                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHrs += empHrs;
                Console.WriteLine("Day#: " + totalWorkingDays + " Emp Hrs : " + empHrs);
            }

            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
    }
}