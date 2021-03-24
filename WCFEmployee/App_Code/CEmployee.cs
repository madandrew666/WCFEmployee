using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for CEmployee
/// </summary>
[DataContract]
public class CEmployee
{
    [DataMember]
    public int ID { get; set; }
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public System.DateTime HireDate { get; set; }
    [DataMember]
    public int Salary { get; set; }
    [DataMember]
    public string DepartmentName { get; set; }
    [DataMember]
    public string Address { get; set; }

}