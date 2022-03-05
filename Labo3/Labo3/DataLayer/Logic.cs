using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labo3.Global;
using MongoDB.Driver;
using SharpRepository.MongoDbRepository;

namespace Labo3.DataLayer;


public class Logic : ILogicstudent, ILogic
{
    private readonly IModel _model;
    protected MongoDbRepository<Student> repoStudent;
    protected MongoDbRepository<Docent> repoDocent;
    protected MongoDbRepository<Opo> repoOpo;
    public const string _connectionString = "mongodb://127.0.0.1:27017/Labo";
    public Logic(IModel model)
    {
        _model = model;
        repoDocent = new MongoDbRepository<Docent>(_connectionString);
        repoOpo = new MongoDbRepository<Opo>(_connectionString);
        repoStudent = new MongoDbRepository<Student>(_connectionString);
    }

    public void AddStudent(Student s)
    {
        repoStudent.Add(s);
    }

    public List<Student> GetStudents()
    {
        return (List<Student>)repoStudent.GetAll().ToList();
    }
    public void Addopo(Student student, Opo opo)
    {
        repoStudent.Get(student.Id).VoegOPOToe(opo);
        repoStudent.Update(student);
        repoStudent.GetAll();
    }

    public void RemoveOpo(Student student, Opo opo)
    {
        repoStudent.Get(student.Id).VerwijderOPO(opo);
        repoStudent.Update(student);
        repoStudent.GetAll();
    }

    public void DeleteStudent(Student s)
    {
        repoStudent.Delete(s);
        repoStudent.Update(s);
    }

    public List<Docent> GetDocent()
    {
        return (List<Docent>)repoDocent.GetAll();
    }

    public void AddDocent(Docent s)
    {
        repoDocent.Add(s);
    }

    public void Addopo(Docent docent, Opo opo)
    {
        repoDocent.Get(docent.Id).VoegOPOToe(opo);
        repoDocent.Update(docent);
    }

    public void RemoveOpo(Docent docent, Opo opo)
    {
        repoDocent.Get(docent.Id).VerwijderOPO(opo);
        repoDocent.Update(docent);
    }

    public void DeleteDocent(Docent d)
    {
        repoDocent.Delete(d);
        repoDocent.Update(d);
    }
    public List<Opo> GetOpo()
    {
        return (List<Opo>)repoOpo.GetAll();
    }

    public void AddOpo(Opo s)
    {
        repoOpo.Add(s);
    }

    public void DeleteOpo(Opo s)
    {
        repoOpo.Delete(s);
        repoOpo.Update(s);
    }
}
