using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3.Global;

[BsonDiscriminator("Opo")]
public class Opo : IComparable<Opo>, IEquatable<Opo>
{
    public string Code { get; set; }
    public Fase fase { get; set; }
    public Semester Semester { get; set; }
    private int _stp;
    public int Stp
    {
        get { return _stp; }
        set { _stp = value; }
    }
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    private string _id;
    public string Id
    {
        get { return _id; }
        set { _id = value; }
    }
    private string _naam;
    public string Naam
    {
        get { return _naam; }
        set { _naam = value; }
    }

    public virtual List<Student> StudentList { get; set; }
    public virtual List<Docent> DocentList { get; set; }
    public Opo(string id, string code, string naam, int stp, Fase fase, Semester semester)
    {
        _id = id;
        Code = code;
        _naam = naam;
        this.fase = fase;
        Stp = stp;
        Semester = semester;
        StudentList = new List<Student>();
        DocentList = new List<Docent>();
    }

    public Opo(string code, string naam, int stp, Fase fase, Semester semester)
    {
        Code = code;
        _naam = naam;
        this.fase = fase;
        Stp = stp;
        Semester = semester;
        StudentList = new List<Student>();
        DocentList = new List<Docent>();
    }

    public Opo()
    {

    }

    public override string ToString()
    {
        return Code + ": " + _naam + "(" + Stp + " stp, " + fase + "," + Semester + ")";
    }

    public void VoegStudentToe(List<Student> stu)
    {
        foreach (var s in stu)
        {
            if (!StudentList.Contains(s))
            {
                StudentList.Add(s);
            }
        }
        StudentList.Sort();
    }

    public void VoegDocentToe(List<Docent> doc)
    {
        foreach (var d in doc)
        {
            if (!DocentList.Contains(d))
            {
                DocentList.Add(d);
            }
        }
        DocentList.Sort();

    }

    public int CompareTo(Opo? other)
    {

        if (other as Opo != null)
            return Code.CompareTo((other as Opo).Code);
        else
            throw new ArgumentException("");
    }

    public  bool Equals(Opo? other)
    {
        if (other is null)
            return false;
        return Code == other.Code && fase == other.fase && Naam == other.Naam;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Opo);
    }
}
