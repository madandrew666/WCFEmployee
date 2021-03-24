using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.
[ServiceContract]
public interface IEmployeeService
{
    [OperationContract]
    List<CEmployee> ListEmployee();
    [OperationContract]
    Boolean CreateEmployee(string nName, DateTime nDate, int nSalary, int nDepID, string nAddress);
    [OperationContract]
    Boolean UpdateEmployee(int nID, string nName, DateTime nDate, int nSalary, int nDepID, string nAddress);
    [OperationContract]
    Boolean DeleteEmployee(int nID);
}
