using System;

namespace BridgeLabz_Training._4_Employee_Management.Interfaces
{
    public interface IEmployeeService
    {
        void AddEmployee();

        void UpdateEmployee();

        void DeleteEmployee();

        void DisplayEmployees();
    }
}