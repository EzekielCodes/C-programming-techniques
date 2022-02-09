using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Labo1.Logica;
namespace Labo1.Datalaag;

public class Connection
{
    private MySqlConnection _connection;
    private string _server;
    private string _database;
    private string _uid;
    private string _password;
    public List<Docent> docentenNaam = new();
    

    public string Naam { get; set; }
    private string _voornaam = "" ;
    private string _code = "";
    private string _naamVaak = "" ;
    private string _stp = "" ;
    private string _opo = "" ;
    private String _id = "" ;
    private string _faseSemester = "";

    public Fase Fase { get; set;}
    public Semester Semester { get; set; }
    public List<Student> studentenNaam = new();
    public List<Opo> opoNamen = new();

    public List<String> vaakNaamDocenten = new();
    public List<String> vaakNaamStudenten= new();
    public List<String> vaakFaseenSemester = new();
    public List<String> list = new();
    private Student _student;
    private Docent _docent;
    private Opo _opoObject;
    public void Initialize()
   {
       _server = "laboapplicatie1.mysql.database.azure.com";
       _database = "laboapplicatie1";
       _uid = "Ezekiel@laboapplicatie1";
       _password = "Azerty123";
       string connectionString;
       connectionString = "SERVER=" + _server + ";" + "DATABASE=" +
       _database + ";" + "UID=" + _uid + ";" + "PASSWORD=" + _password + ";";

       _connection = new MySqlConnection(connectionString);
       OpenConnection();
       Readdocenten();
       Readstudenten();
   }

   //open connection to database
   private bool OpenConnection()
   {
       try
       {        
           _connection.Open();
           MessageBox.Show("Connected");
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
       String query = " SELECT persoon.naam,persoon.voornaam " +
           "FROM laboapplicatie1.persoon, docenten " +
           "Where docenten.Personeelslid_Persoon_idPersoon = persoon.idPersoon ; ";

       var cmd = new MySqlCommand(query,_connection);
       var dataReader = cmd.ExecuteReader();

       while (dataReader.Read())
       {
           Naam = dataReader[0].ToString();
           _voornaam = dataReader[1].ToString();
            _docent = new Docent(Naam, _voornaam);
            docentenNaam.Add(_docent);           
       }
        Debug.WriteLine(docentenNaam[0].CompareTo(docentenNaam[2]));
        dataReader.Close();
   }

   public void Readstudenten()
   {
       String query = " SELECT persoon.naam,persoon.voornaam " +
           "FROM laboapplicatie1.persoon, student " +
           "Where student.Persoon_idPersoon = persoon.idPersoon ; ";

       var cmd = new MySqlCommand(query, _connection);
       var dataReader = cmd.ExecuteReader();

       while (dataReader.Read())
       {
           Naam = dataReader[0].ToString();
           _voornaam = dataReader[1].ToString();
           _student = new Student(Naam,_voornaam);
           studentenNaam.Add(_student);
           

        }
        Debug.WriteLine(studentenNaam[0].CompareTo(studentenNaam[2]));
        dataReader.Close ();
        
   }

   public void ReadVakkenDocenten()
   {

        vaakNaamDocenten.Clear();
        list.Clear();
        opoNamen.Clear();
        String query = "select opo.code,opo.naam,opo.stp " +
            "from opo " +
            "inner join opo_has_docenten " +
            " on opo.idOPO = opo_has_docenten.OPO_idOPO " +
            "where opo_has_docenten.Docenten_Personeelslid_Persoon_idPersoon = @id";
        var param = new MySqlParameter
        {
            ParameterName = "@id",
            Value = _id
        };
        var cmd = new MySqlCommand(query, _connection);
        cmd.Parameters.Add(param);
        var dataReader = cmd.ExecuteReader();

        while (dataReader.Read())
        {
            _code = dataReader[0].ToString();
            _naamVaak = dataReader[1].ToString();
            _stp = dataReader[2].ToString();    
            _opo = _code + "-" + _naamVaak + "-" + _stp +  "-";
            vaakNaamDocenten.Add(_opo);
        }
        dataReader.Close();
        list.AddRange(vaakNaamDocenten);
        for (int i = 0; i < list.Count; i++)
        {
            String[] tokens = list[i].Split("-");           
            GetIdFromCode(tokens[0]);
            vaakNaamDocenten[i] = list[i] + String.Join(" ", vaakFaseenSemester);
            String[] token = vaakNaamDocenten[i].Split("-");
            _opoObject = new Opo(token[0], token[1], Int16.Parse(token[2]), Enum.Parse<Fase>(token[3]), Enum.Parse<Semester>(token[4]));
            opoNamen.Add(_opoObject);
        }
    }

    public void ReadVakkenStudenten()
    {
        vaakNaamStudenten.Clear();
        list.Clear();
        opoNamen.Clear();
        String query = "select opo.code,opo.naam,opo.stp " +
            " from opo " +
            "inner join student_has_opo  " +
            "on opo.idOPO = student_has_opo.OPO_idOPO " +
            " where student_has_opo.Student_Persoon_idPersoon = @id;";
        var param = new MySqlParameter
        {
            ParameterName = "@id",
            Value = _id
        };

        var cmd = new MySqlCommand(query, _connection);
        cmd.Parameters.Add(param);
        var dataReader = cmd.ExecuteReader();

        while (dataReader.Read())
        {
            _code = dataReader[0].ToString();
            _naamVaak = dataReader[1].ToString();
            _stp = dataReader[2].ToString();
            _opo = _code + "-" + _naamVaak + "-" + _stp + "-";
            vaakNaamStudenten.Add(_opo);
        }
        dataReader.Close();
        list.AddRange(vaakNaamStudenten);
        for (int i = 0; i < list.Count; i++)
        {
            String [] tokens = list[i].Split("-");
            GetIdFromCode(tokens[0]);
            vaakNaamStudenten[i] = list[i] + String.Join(" ", vaakFaseenSemester);
            String[] token = vaakNaamStudenten[i].Split("-");
            _opoObject = new Opo(token[0], token[1], Int16.Parse(token[2]), Enum.Parse<Fase>(token[3]), Enum.Parse<Semester>(token[4]));
            opoNamen.Add(_opoObject);
            
        }
    }

    public void ReadFaseenSemester(String  id)
    {
        vaakFaseenSemester.Clear();
        String query = "select semester.semester,fase.fase " +
            "from semester,fase " +
            "where semester.OPO_idOPO = @id and fase.OPO_idOPO = @id; ";

        var param = new MySqlParameter
        {
            ParameterName = "@id",
            Value = id
        };
        var cmd = new MySqlCommand(query, _connection);
        cmd.Parameters.Add(param);
        var dataReader = cmd.ExecuteReader();

        while (dataReader.Read())
        {
            Fase = Enum.Parse<Fase>(dataReader[1].ToString());
            Semester = Enum.Parse<Semester>(dataReader[0].ToString());
            _faseSemester = Fase + "-"+  Semester;
            vaakFaseenSemester.Add(_faseSemester);
        }
        dataReader.Close();
    }

    public void GetIdFromNaam(String n, String vm)
    {
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
    }

    public void GetIdFromCode(String code)
    {
        String query = " select opo.idOPO " +
            "from opo " +
            "where opo.code = @code; ";

        var param = new MySqlParameter
        {
            ParameterName = "@code",
            Value = code
        };
        var cmd = new MySqlCommand(query, _connection);
        cmd.Parameters.Add(param);
        var dataReader = cmd.ExecuteReader();

        while (dataReader.Read())
        {
            _id = dataReader[0].ToString();
        }
        dataReader.Close();
        ReadFaseenSemester(_id);
    }
}
