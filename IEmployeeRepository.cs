using StaffServices.Models;

public interface IEmployeeRepository {
    Task<Employee> GetEmployee(int id);

    Task<IEnumerable<Employee>> GetEmployees();

    Task<Employee> AddEmployee(Employee employee);

    Task<Employee> UpdateEmployee(Employee employee);

    Task<Employee> DeleteEmployee(int id);
}