using System.Collections.Generic;
using Practical_33_Blazor_Server_App.Data;
using Practical_33_Blazor_Server_App.Model;

namespace Practical_33_Blazor_Server_App.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<EmployeeModel> GetAllEmployees();
        EmployeeModel GetEmployeeById(int id);
        void AddEmployee(EmployeeModel employee);
        void UpdateEmployee(EmployeeModel employee);
        void DeleteEmployee(int id);
    }
}
