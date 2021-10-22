using System.Collections.Generic;
using SecureCoreAPI.Models;

namespace SecureCoreAPI.Data
{
    public interface IEmployeeInfo
    {
        IEnumerable<EmployeeInfo> GetEmployeeDetails();
        int AddEmployeeDetails();
        int DeleteEmployee(int empId);
    }
}