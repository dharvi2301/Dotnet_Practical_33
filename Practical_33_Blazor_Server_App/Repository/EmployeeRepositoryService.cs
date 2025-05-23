using Practical_33_Blazor_Server_App.Data;
using Practical_33_Blazor_Server_App.Model;

namespace Practical_33_Blazor_Server_App.Repository
{
    public class EmployeeRepositoryService : IEmployeeRepository
    {
        private readonly AppDbContext _context;
        public EmployeeRepositoryService(AppDbContext context)
        {
            _context = context;
        }
        // Get all employees
        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        // Get employee by ID
        public EmployeeModel? GetEmployeeById(int id)
        {
            return _context.Employees.Find(id);
        }

        // Add new employee
        public void AddEmployee(EmployeeModel employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        // Update existing employee
        public void UpdateEmployee(EmployeeModel employee)
        {
            var existing = _context.Employees.Find(employee.Id);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(employee);
                _context.SaveChanges();
            }
        }

        // Delete employee by ID
        public void DeleteEmployee(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
        }
    }

}
