using Labo_2.Logica;

namespace Labo_2.LogicLayer;

public interface IStudentController
{
    void Addopo(Student student, Opo opo);
    void AddStudent(Student s);
    List<Student> GetStudents();
    void RemoveOpo(Student student, Opo opo);
    void DeleteStudent(Student s);
}