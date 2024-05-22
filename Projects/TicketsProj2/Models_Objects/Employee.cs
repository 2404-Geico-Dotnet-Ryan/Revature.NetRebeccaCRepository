class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public string EmpPassword { get; set; }
    public string EmpRole { get; set; }

    public Employee()
    {
        EmpName = "";
        EmpPassword = "";
        EmpRole = "";
    }

    public Employee (int empid, string empname, string emppassword, string emprole)
    {
        EmpId = empid;
        EmpDriverName = empname;
        EmpPassword = emppassword;
        EmpRole = emprole;
    }

    public override string ToString()
    {
        return "{EmployeeId:" + EmpId
        + ", Employee Name:'" + EmpName
        + "', Employee Password:'" + EmpPassword
        + "', Employee Role:'" + EmpRole + "'}";
    }
}