using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Labo1.Logica;
using System.Data;
namespace Labo1.Datalaag;

public class ConnectionAdo
{
    private MySqlConnection _connection;
    public List<Docent> docentenNaam = new();
    public List<Student> studentenNaam = new();
    public List<Opo> opoNaam = new();

    public string Naam { get; set; }
    private string _voornaam = "" ;
    private string _code = "";
    private string _naamVaak = "" ;
    private string _stp = "" ;
    private String _id = "" ;

    public Fase Fase { get; set;}
    public Semester Semester { get; set; }
    private Student _student;
    private Docent _docent;
    public Opo _opoObject;
    private readonly DataSet _Docenten = new();
    private readonly DataSet _Studenten = new();
    private readonly DataSet _Opo = new();
    private DataTable _dt = new();
    public void Initialize()
   {
       string connectionString = "SERVER=laboapplicatie01.mysql.database.azure.com;DATABASE=laboapplicatie01;UID=Ezekiel@laboapplicatie01;PASSWORD=Azerty123";
       _connection = new MySqlConnection(connectionString);
       Readdocenten();
       Readstudenten();
   }

   //open connection to database
   private bool OpenConnection()
   {
       try
       {        
           _connection.Open();
          // MessageBox.Show("Connected");
           return true;
       }
       catch (MySqlException ex)
       {
           switch (ex.Number)
           {
               case 0:
                   MessageBox.Show("Cannot connect to server.  Contact administrator");
                   break;

               case 1045:
                   MessageBox.Show("Invalid username/password, please try again");
                   break;
           }
           return false;
       }
   }

   //Close connection
   private bool CloseConnection()
   {
       try
       {
           _connection.Close();
           return true;
       }
       catch (MySqlException ex)
       {
           MessageBox.Show(ex.Message);
           return false;
       }
   }

   public void Readdocenten()
   {
        OpenConnection();
        _dt.Clear();
        String query = " SELECT persoon.naam,persoon.voornaam " +
           "FROM laboapplicatie01.persoon, docenten " +
           "Where docenten.Personeelslid_Persoon_idPersoon = persoon.idPersoon ; ";

       var cmd = new MySqlCommand(query,_connection);
       var adapter = new MySqlDataAdapter(cmd);
       adapter.Fill(_Docenten, "Docenten");
       _dt = _Docenten.Tables["Docenten"];

        foreach(DataRow dr in _dt.Rows)
        {
          Naam = dr[0].ToString();
          _voornaam = dr[1].ToString();
          _docent = new Docent(Naam, _voornaam);
          docentenNaam.Add(_docent);
        }

        /*var dataReader = cmd.ExecuteReader();

       while (dataReader.Read())
       {
          *//* Naam = dataReader[0].ToString();
           _voornaam = dataReader[1].ToString();*//*
            _docent = new Docent(Naam, _voornaam);
            docentenNaam.Add(_docent);           
       }
        Debug.WriteLine(docentenNaam[0].CompareTo(docentenNaam[2]));
        dataReader.Close();*/

        CloseConnection();
   }

   public void Readstudenten()
   {
        OpenConnection();
        _dt.Clear();
        String query = " SELECT persoon.naam,persoon.voornaam " +
           "FROM laboapplicatie01.persoon, student " +
           "Where student.Persoon_idPersoon = persoon.idPersoon ; ";

       var cmd = new MySqlCommand(query, _connection);
        var adapter = new MySqlDataAdapter(cmd);
        adapter.Fill(_Studenten, "Student");
        _dt = _Studenten.Tables["Student"];

        foreach (DataRow dr in _dt.Rows)
        {
            Naam = dr[0].ToString();
            _voornaam = dr[1].ToString();
            _student= new Student(Naam, _voornaam);
            studentenNaam.Add(_student);
        }

        /*var dataReader = cmd.ExecuteReader();

        while (dataReader.Read())
        {
            Naam = dataReader[0].ToString();
            _voornaam = dataReader[1].ToString();
            _student = new Student(Naam,_voornaam);
            studentenNaam.Add(_student);
         }
         Debug.WriteLine(String.Join(" ",studentenNaam));
         dataReader.Close ();*/
        CloseConnection();
   }

   public void ReadVakkenDocenten()
   {
        OpenConnection();
        opoNaam.Clear();
        _dt.Clear();
        String query = "select opo.code,opo.naam,opo.stp,opo.fase,opo.Semester " +
            "from opo " +
            "inner join opo_has_docenten " +
            "on opo.idOPO = opo_has_docenten.OPO_idOPO " +
            "where opo_has_docenten.Docenten_Personeelslid_Persoon_idPersoon = @id";
        var param = new MySqlParameter
        {
            ParameterName = "@id",
            Value = _id
        };
        var cmd = new MySqlCommand(query, _connection);
        cmd.Parameters.Add(param);
        var adapter = new MySqlDataAdapter(cmd);
        adapter.Fill(_Opo, "Opo");
        _dt = _Opo.Tables["Opo"];

        foreach (DataRow dr in _dt.Rows)
        {
            _code = dr[0].ToString();
            _naamVaak = dr[1].ToString();
            _stp = dr[2].ToString();

            _opoObject = new Opo(_code, _naamVaak, int.Parse(_stp), Enum.Parse<Fase>(dr[3].ToString()), Enum.Parse<Semester>(dr[4].ToString()));
            opoNaam.Add(_opoObject);
        }
        /*var dataReader = cmd.ExecuteReader();

        while (dataReader.Read())
        {
            _code = dataReader[0].ToString();
            _naamVaak = dataReader[1].ToString();
            _stp = dataReader[2].ToString();    
            
            _opoObject = new Opo(_code, _naamVaak, int.Parse(_stp), Enum.Parse<Fase>(dataReader[3].ToString()), Enum.Parse<Semester>(dataReader[4].ToString()));
            opoNaam.Add(_opoObject);
        }
        dataReader.Close();*/
        CloseConnection();
    }

    public void ReadVakkenStudenten()
    {
        OpenConnection();
        opoNaam.Clear();
        _dt.Clear();
        String query = "select opo.code,opo.naam,opo.stp,opo.fase,opo.Semester " +
            "from opo " +
            "inner join student_has_opo " +
            "on opo.idOPO = student_has_opo.OPO_idOPO" +
            " where student_has_opo.Student_Persoon_idPersoon = @id;";
        var param = new MySqlParameter
        {
            ParameterName = "@id",
            Value = _id
        };

        var cmd = new MySqlCommand(query, _connection);
        cmd.Parameters.Add(param);
        var adapter = new MySqlDataAdapter(cmd);
        adapter.Fill(_Opo, "Opo");
        _dt = _Opo.Tables["Opo"];

        foreach (DataRow dr in _dt.Rows)
        {
            _code = dr[0].ToString();
            _naamVaak = dr[1].ToString();
            _stp = dr[2].ToString();

            _opoObject = new Opo(_code, _naamVaak, int.Parse(_stp), Enum.Parse<Fase>(dr[3].ToString()), Enum.Parse<Semester>(dr[4].ToString()));
            opoNaam.Add(_opoObject);
        }
        /*var dataReader = cmd.ExecuteReader();

        while (dataReader.Read())
        {
            _code = dataReader[0].ToString();
            _naamVaak = dataReader[1].ToString();
            _stp = dataReader[2].ToString();
            _opoObject = new Opo(_code, _naamVaak, Int32.Parse(_stp), Enum.Parse<Fase>(dataReader[3].ToString()), Enum.Parse<Semester>(dataReader[4].ToString()));
            opoNaam.Add(_opoObject);
        }
        dataReader.Close();*/
        CloseConnection();
    }

    public void GetIdFromNaam(String n, String vm)
    {
        OpenConnection();
        String query = " select persoon.idPersoon " +
            "from persoon" +
            " where persoon.naam like @naam and persoon.voornaam like @vnaam; ";

        var Nparam = new MySqlParameter();
        var Vparam = new MySqlParameter();
        Nparam.ParameterName = "@naam";
        Nparam.Value = n;
        Vparam.ParameterName = "@vnaam";
        Vparam.Value = vm;

        var cmd = new MySqlCommand(query, _connection);
        cmd.Parameters.Add(Vparam);
        cmd.Parameters.Add(Nparam);
        var dataReader = cmd.ExecuteReader();

        while (dataReader.Read())
        {
            _id = dataReader[0].ToString();
        }
        dataReader.Close();
        CloseConnection();
    }
}
