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
    public List<String> docentenNaam = new();
    private String _fullnaam;

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
    public List<String> studentenNaam = new();

    public List<String> vaakNaamDocenten = new();
    public List<String> vaakNaamStudenten= new();
    public List<String> vaakFaseenSemester = new();
    public List<String> list = new();
    public void Initialize()
   {
       _server = "localhost";
       _database = "laboapplicatie1";
       _uid = "Akindele";
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
           _fullnaam = Naam + " " + _voornaam;

           docentenNaam.Add(_fullnaam);
       }

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
           _fullnaam = Naam + " " + _voornaam;

           studentenNaam.Add(_fullnaam);
       }
       dataReader.Close ();
   }

   public void ReadVakkenDocenten()
   {

        vaakNaamDocenten.Clear();
        list.Clear();
        String query = "select opo.code,opo.naam,opo.stp " +
            "from opo " +
            "inner join opo_has_docenten " +
            " on opo.idOPO = opo_has_docenten.OPO_idOPO " +
            "where opo_has_docenten.Docenten_Personeelslid_Persoon_idPersoon = '" + _id +"'; ";
        var cmd = new MySqlCommand(query, _connection);
        var dataReader = cmd.ExecuteReader();

        while (dataReader.Read())
        {
            _code = dataReader[0].ToString();
            _naamVaak = dataReader[1].ToString();
            _stp = dataReader[2].ToString();
      
            _opo = _code + ": " + _naamVaak + " (" + _stp + " stp)";
            vaakNaamDocenten.Add(_opo);
        }
        dataReader.Close();
        list.AddRange(vaakNaamDocenten);
        for (int i = 0; i < list.Count; i++)
        {
            String[] tokens = list[i].Split(": ");
            GetIdFromCode(tokens[0]);
            vaakNaamDocenten[i] = list[i] + String.Join(" ", vaakFaseenSemester);
        }
    }

    public void ReadVakkenStudenten()
    {
        vaakNaamStudenten.Clear();
        list.Clear();
        String query = "select opo.code,opo.naam,opo.stp " +
            " from opo " +
            "inner join student_has_opo  " +
            "on opo.idOPO = student_has_opo.OPO_idOPO " +
            " where student_has_opo.Student_Persoon_idPersoon = '" + _id +"';";

        var cmd = new MySqlCommand(query, _connection);
        var dataReader = cmd.ExecuteReader();

        while (dataReader.Read())
        {
            _code = dataReader[0].ToString();
            _naamVaak = dataReader[1].ToString();
            _stp = dataReader[2].ToString();

            _opo = _code + ": " + _naamVaak + " (" + _stp + " stp)";
            vaakNaamStudenten.Add(_opo);
        }
        dataReader.Close();
        list.AddRange(vaakNaamStudenten);
        for (int i = 0; i < list.Count; i++)
        {
            String [] tokens = list[i].Split(": ");
            GetIdFromCode(tokens[0]);
            vaakNaamStudenten[i] = list[i] + String.Join(" ", vaakFaseenSemester);
        }   
    }

    public void ReadFaseenSemester(String  id)
    {
        vaakFaseenSemester.Clear();
        String query = "select semester.semester,fase.fase " +
            "from semester,fase " +
            "where semester.OPO_idOPO = '" + id +"' and fase.OPO_idOPO = '" + id + "'; ";

        var cmd = new MySqlCommand(query, _connection);
        var dataReader = cmd.ExecuteReader();

        while (dataReader.Read())
        {
            
            Fase = Enum.Parse<Fase>(dataReader[1].ToString());
            Semester = Enum.Parse<Semester>(dataReader[0].ToString());
            _faseSemester = " "+ Fase + "  "+  Semester;
            vaakFaseenSemester.Add(_faseSemester);
        }
        dataReader.Close();
    }

    public void GetIdFromNaam(String n)
    {
        String query = " select persoon.idPersoon " +
            "from persoon" +
            " where persoon.naam like '"+ n + "'; ";

        var cmd = new MySqlCommand(query, _connection);
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
            "where opo.code = '" + code + "'; ";

        var cmd = new MySqlCommand(query, _connection);
        var dataReader = cmd.ExecuteReader();

        while (dataReader.Read())
        {
            _id = dataReader[0].ToString();
        }
        dataReader.Close();
        ReadFaseenSemester(_id);
    }
}
