using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;
using Labo1.Logica;
namespace Labo1.Datalaag;

public class ConnectionDapper
{
    readonly String cs = "SERVER=laboapplicatie01.mysql.database.azure.com;DATABASE=laboapplicatie01;UID=Ezekiel@laboapplicatie01;PASSWORD=Azerty123";
    public List<Student> studentenNaam = new();
    public List<Docent> docentenNaam = new();
    public List<Opo> opoNaam = new();
    public MySqlConnection con;
    private String _id = "";
    public string Naam { get; set; }
 
    public void Initialize()
    {
        ReadStudenten();
        ReadDocenten();
    }
    public void OpenConnection()
    { 
        con = new MySqlConnection(cs);
        try
        {
            Debug.WriteLine("trying");
            con.Open();
            //MessageBox.Show("Connected");
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
        } 
    }

    private bool CloseConnection()
    {
        try
        {
            con.Close();
            return true;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
            return false;
        }
    }

    public void ReadStudenten()
    {
        OpenConnection();
        studentenNaam = con.Query<Student>("SELECT persoon.naam,persoon.voornaam " +
           "FROM laboapplicatie01.persoon, student " +
           "Where student.Persoon_idPersoon = persoon.idPersoon ; ").ToList();
        Debug.WriteLine(String.Join(" ", studentenNaam));
        CloseConnection();
    }

    public void ReadDocenten()
    {
        OpenConnection();
        docentenNaam = con.Query<Docent>("SELECT persoon.naam,persoon.voornaam " +
          "FROM laboapplicatie01.persoon, docenten " +
          "Where docenten.Personeelslid_Persoon_idPersoon = persoon.idPersoon ; ").ToList();

        Debug.WriteLine(String.Join(" ", docentenNaam));

        CloseConnection();
    }

    public void ReadVakkenStudenten()
    {
        OpenConnection();
    
        Debug.WriteLine(_id + "readvaak");
        opoNaam = con.Query<Opo>("select opo.code,opo.naam,opo.stp,opo.fase,opo.Semester " +
            "from opo " +
            "inner join student_has_opo " +
            "on opo.idOPO = student_has_opo.OPO_idOPO" +
            " where student_has_opo.Student_Persoon_idPersoon = @id;", new {id = _id}).ToList();
        CloseConnection();
    }
    public void ReadVakkenDocenten()
    {
        OpenConnection();
        opoNaam = con.Query<Opo>("select opo.code,opo.naam,opo.stp,opo.fase,opo.Semester " +
            "from opo " +
            "inner join opo_has_docenten   " +
            "on opo.idOPO = opo_has_docenten.OPO_idOPO" +
            " where opo_has_docenten.Docenten_Personeelslid_Persoon_idPersoon  = @id;", new { id = _id }).ToList();
        CloseConnection();
    }
    public void GetIdFromNaam(String n, String vm)
    {
        OpenConnection();
        String query = " select persoon.idPersoon " +
            "from persoon" +
            " where persoon.naam like @naam and persoon.voornaam like @vnaam; ";

        _id = con.QueryFirstOrDefault<String>(query, new {naam = n, vnaam = vm });
        CloseConnection();
    }
}
