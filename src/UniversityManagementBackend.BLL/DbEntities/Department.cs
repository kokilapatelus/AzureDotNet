namespace UniversityManagementBackend.BLL.DbEntities;

public class Department
{
    public long DepartmentId { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }

    public List<Student> Students { get; set; }
}