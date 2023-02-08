using FirstWebAPI.Interface;
using FirstWebAPI.Model;

namespace FirstWebAPI.Repository
{
    public class EmployeeRepository : EmployeeInterface
    {
        List<EmployeeClass> employeesList = new List<EmployeeClass> { 
            new EmployeeClass{EmployeeID=1,EmployeeName="Mukesh Kumar 1",EmployeeEmail="m@gmail.com",EmployeePhone="8695948473",EmployeeAge=21},
            new EmployeeClass{EmployeeID=2,EmployeeName="Mukesh Kumar 2",EmployeeEmail="mk@gmail.com",EmployeePhone="9695948473",EmployeeAge=21},
            new EmployeeClass{EmployeeID=3,EmployeeName="Mukesh Kumar 3",EmployeeEmail="mk2@gmail.com",EmployeePhone="7695948473",EmployeeAge=21},
            new EmployeeClass{EmployeeID=4,EmployeeName="Mukesh Kumar 4",EmployeeEmail="mk3@gmail.com",EmployeePhone="8795948473",EmployeeAge=21},
            new EmployeeClass{EmployeeID=5,EmployeeName="Mukesh Kumar 5",EmployeeEmail="mk4@gmail.com",EmployeePhone="8895948473",EmployeeAge=21},
            new EmployeeClass{EmployeeID=6,EmployeeName="Mukesh Kumar 6",EmployeeEmail="mk5@gmail.com",EmployeePhone="8995948473",EmployeeAge=21}
        };
        public EmployeeClass GetEmployee(int id)
        {
            try
            {
                return employeesList[id];
            }
            catch(Exception e)
            {
                Console.WriteLine("Employee Not Found!!!");
                return null;
            }
        }

        public List<EmployeeClass> GetEmployees()
        {
            return employeesList;
        }
    }
}
