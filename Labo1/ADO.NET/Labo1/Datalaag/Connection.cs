using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
    private String _naam;
    public string Naam
    {
        get { return _naam; }
        set { _naam = value; }
    }
    private string _voornaam;
    private string _code;
    private string _naamVaak;
    private string _stp;
    private string _opo;
    private String _id;

   public List<String> studentenNaam = new();

   public List<String> vaakNaam = new();

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

       MySqlCommand cmd = new MySqlCommand(query,_connection);
       MySqlDataReader dataReader = cmd.ExecuteReader();

       while (dataReader.Read())
       {
           _naam = dataReader[0].ToString();
           _voornaam = dataReader[1].ToString();
           _fullnaam = _naam + " " + _voornaam;

           docentenNaam.Add(_fullnaam);
       }

       dataReader.Close();
   }

   public void Readstudenten()
   {
       String query = " SELECT persoon.naam,persoon.voornaam " +
           "FROM laboapplicatie1.persoon, student " +
           "Where student.Persoon_idPersoon = persoon.idPersoon ; ";

       MySqlCommand cmd = new MySqlCommand(query, _connection);
       MySqlDataReader dataReader = cmd.ExecuteReader();

       while (dataReader.Read())
       {
           _naam = dataReader[0].ToString();
           _voornaam = dataReader[1].ToString();
           _fullnaam = _naam + " " + _voornaam;

           studentenNaam.Add(_fullnaam);
       }
       dataReader.Close ();
   }

   public void ReadVakkenDocenten()
   {

     
        String query = "select opo.code,opo.naam,opo.stp " +
            "from opo " +
            "inner join opo_has_docenten " +
            " on opo.idOPO = opo_has_docenten.OPO_idOPO " +
            "where opo_has_docenten.Docenten_Personeelslid_Persoon_idPersoon = '" + _id +"'; ";

        MySqlCommand cmd = new MySqlCommand(query, _connection);
        MySqlDataReader dataReader = cmd.ExecuteReader();

        while (dataReader.Read())
        {
            _code = dataReader[0].ToString();
            _naamVaak = dataReader[1].ToString();
            _stp = dataReader[2].ToString();
            _fullnaam = _naam + " " + _voornaam;

            _opo = _code + ": " + _naamVaak + " (" + _stp + " stp)";

            vaakNaam.Add(_opo);
        }
        dataReader.Close();
    }

    public void GetIdFromNaam(String n)
    {
        String query = " select persoon.idPersoon " +
            "from persoon" +
            " where persoon.naam like '"+ n + "'; ";

        MySqlCommand cmd = new MySqlCommand(query, _connection);
        MySqlDataReader dataReader = cmd.ExecuteReader();

        while (dataReader.Read())
        {
            _id = dataReader[0].ToString();
        }

        Debug.WriteLine(_id);
        dataReader.Close();
    }

}


