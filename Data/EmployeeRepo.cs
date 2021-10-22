using System.Collections.Generic;
using SecureCoreAPI.Models;

namespace SecureCoreAPI.Data
{
    public class EmployeeRepo : IEmployeeInfo
    {
        public int AddEmployeeDetails()
        {
            throw new System.NotImplementedException();
        }

        public int DeleteEmployee(int empId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<EmployeeInfo> GetEmployeeDetails()
        {
            var emplyoee = new List<EmployeeInfo>(){
                new EmployeeInfo(){EmpId =1,EmpName="Test1",Address="India",Age=32,Gender="male"},
                new EmployeeInfo(){EmpId =2,EmpName="Test2",Address="India",Age=30,Gender="Female"},
                new EmployeeInfo(){EmpId =3,EmpName="Test3",Address="USA",Age=31,Gender="male"},
                new EmployeeInfo(){EmpId =4,EmpName="Test4",Address="UK",Age=36,Gender="male"},
                new EmployeeInfo(){EmpId =5,EmpName="Test5",Address="USA",Age=34,Gender="Female"},
            };
            return emplyoee;
        }
    }
}