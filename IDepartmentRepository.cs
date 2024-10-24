using StaffServices.Models;

public interface iDepartmentRepository{
    IEnumerable<Department> GetDepartments();

    Department GetDepartment(int id);
}