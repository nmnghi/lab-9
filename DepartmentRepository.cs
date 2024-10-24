using StaffServices.Models;

public class DepartmentRepository : iDepartmentRepository{
    private readonly StaffsContext staffsContext;

    public DepartmentRepository(StaffsContext staffsContext){
        this.staffsContext = staffsContext;
    }

    public IEnumerable<Department> GetDepartments(){
        return staffsContext.Departments;
    }

    public Department GetDepartment(int id){
        return staffsContext.Departments.FirstOrDefault(d => d.DepartmentId == id);
    }
}