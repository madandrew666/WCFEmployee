using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
public class EmployeeService : IEmployeeService
{
    Entities db = new Entities();
    public List<CEmployee> ListEmployee()
    {
        var rawList = from emp in db.Employees
                      select emp;
        List<CEmployee> result = new List<CEmployee>();
        foreach(var raw in rawList)
        {
            CEmployee turn = new CEmployee();
            turn.ID = raw.ID;
            turn.Name = raw.Name;
            turn.HireDate = raw.HireDate;
            turn.Salary = raw.Salary;
            turn.DepartmentName = db.Departments.ToList<Department>().ElementAt(raw.DepartmentID-1).DepartmentName;
            turn.Address = raw.Address;
            result.Add(turn);
        }

        return result;
    }
    public Boolean CreateEmployee(string nName,DateTime nDate,int nSalary,int nDepID,string nAddress)
    {
        Employee nEmp = new Employee();
        nEmp.ID = db.Employees.Count()+1;
        nEmp.Name = nName;
        nEmp.HireDate = nDate;
        nEmp.Salary = nSalary;
        nEmp.DepartmentID = nDepID;
        nEmp.Address = nAddress;
        db.Employees.Add(nEmp);
        db.SaveChanges();
        return true;
    }
    public Boolean UpdateEmployee(int nID,string nName,DateTime nDate,int nSalary,int nDepID,string nAddress)
    {
        Employee nEmp = db.Employees.Find(nID);
        nEmp.Name = nName;
        nEmp.HireDate = nDate;
        nEmp.Salary = nSalary;
        nEmp.DepartmentID = nDepID;
        nEmp.Address = nAddress;
        db.SaveChanges();
        return true;
    }

    public Boolean DeleteEmployee(int nID)
    {
        Employee nEmp = db.Employees.Find(nID);
        db.Employees.Remove(nEmp);
        db.SaveChanges();
        return true;
    }
}
