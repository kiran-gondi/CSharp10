namespace ManyToOne
{
  /// <summary>
  /// Employee class
  /// </summary>
  public class Employee
  {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }

        public Department Dept { get; set; }

      public override string ToString()
      {
      return "EmployeeId: " + EmployeeId + ", Employee Name: " + EmployeeName + ", " + "Employee Email"
              + EmployeeEmail + "\nDept details: Department is " + Dept.DeptName + ", Dept Id: " + Dept.DeptId;
      }
  }
}
