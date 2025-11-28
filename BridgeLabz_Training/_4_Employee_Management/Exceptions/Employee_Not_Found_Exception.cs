using System;

namespace BridgeLabz_Training._4_Employee_Management..Exceptions
{
    public class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException(string message) : base(message)
        {
        }
    }
}
