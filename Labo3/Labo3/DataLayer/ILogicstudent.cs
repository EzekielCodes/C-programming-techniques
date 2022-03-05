using Labo3.Global;

namespace Labo3.DataLayer;

public interface ILogicstudent
{
    void Addopo(Student student, Opo opo);
    void AddStudent(Student s);
    void DeleteStudent(Student s);
    List<Student> GetStudents();
    void RemoveOpo(Student student, Opo opo);
}