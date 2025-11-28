using System;

namespace BridgeLabz_Training._4_Employee_Management.Exceptions

{
    public class EmployeeAlreadyExistsException : Exception
    {
        public EmployeeAlreadyExistsException(string message) : base(message)
        {
        }
    }
}
