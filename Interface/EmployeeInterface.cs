using FirstWebAPI.Model;

namespace FirstWebAPI.Interface
{
    public interface EmployeeInterface
    {
        List<EmployeeClass> GetEmployees();
        EmployeeClass GetEmployee(int id);

    }
}
