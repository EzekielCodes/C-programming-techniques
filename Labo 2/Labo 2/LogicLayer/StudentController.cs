using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labo_2.Logica;
using SharpRepository.EfCoreRepository;
namespace Labo_2.LogicLayer;

public class StudentController : BaseController
{
    protected EfCoreRepository<Student> repoStudent;
    public StudentController()
    {
        repoStudent = new EfCoreRepository<Student>(m);
    }

    public List<Student> GetStudents()
    {
        return (List<Student>)repoStudent.GetAll();
    }

    public void AddStudent(Student s)
    {
        repoStudent.Add(s);
    }
    
    public void Addopo(Student student, Opo opo)
    {
        repoStudent.Get(student.Id).VoegOPOToe(opo);
        repoStudent.Update(student);
    }

    public void RemoveOpo(Student student, Opo opo)
    {
        repoStudent.GetAll();
        repoStudent.Get(student.Id).VerwijderOPO(opo);
        repoStudent.Update(student);
    }

   
 

}



    
