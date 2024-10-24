using Microsoft.EntityFrameworkCore;
using StaffServices.Models;

public class EmployeeRepository : IEmployeeRepository {
    private readonly StaffsContext staffsContext;

    public EmployeeRepository(StaffsContext staffsContext){
        this.staffsContext = staffsContext;
    }

    public async Task<Employee> GetEmployee(int id){
        return await staffsContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == id);
    }

    public async Task<IEnumerable<Employee>> GetEmployees(){
        return await staffsContext.Employees.ToListAsync();
    }

    public async Task<Employee> AddEmployee(Employee employee){
        var result = await staffsContext.Employees.AddAsync(employee);
        await staffsContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<Employee> UpdateEmployee(Employee employee){
        var result = await staffsContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employee.EmployeeId);
        
        if(result != null){
            result.EmployeeId = employee.EmployeeId;
            result.FirstName = employee.FirstName;
            result.LastName = employee.LastName;
            result.Email = employee.Email;
            result.DateOfBirth = employee.DateOfBirth;
            result.GenderId = employee.GenderId;
            result.DepartmentId = employee.DepartmentId;
            return result;
        }

        return null;
    }

    public async Task<Employee> DeleteEmployee(int id){
        var result = await staffsContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == id);

        if(result != null){
            staffsContext.Employees.Remove(result);
            await staffsContext.SaveChangesAsync();
            return result;
        }

        return null;
    }
}
