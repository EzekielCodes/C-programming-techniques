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
           "FROM laboapplicatie1.persoon, student " +
           "Where student.Persoon_idPersoon = persoon.idPersoon ; ").ToList();
        Debug.WriteLine(String.Join(" ", studentenNaam));

        foreach (var Student in studentenNaam)
        {
            Debug.WriteLine(Student.ToString());
        }
        CloseConnection();
    }

    public void ReadDocenten()
    {
        OpenConnection();
        docentenNaam = con.Query<Docent>("SELECT persoon.naam,persoon.voornaam " +
          "FROM laboapplicatie1.persoon, docenten " +
          "Where docenten.Personeelslid_Persoon_idPersoon = persoon.idPersoon ; ").ToList();
        Debug.WriteLine(String.Join(" ", docentenNaam));

        
        CloseConnection();
    }

    public void ReadVakkenStudenten()
    {
        OpenConnection();
       opoNaam = con.Query<Opo>("select opo.code,opo.naam,opo.stp,opo.fase,opo.Semester " +
            "from opo " +
            "inner join student_has_opo " +
            "on opo.idOPO = student_has_opo.OPO_idOPO" +
            " where student_has_opo.Student_Persoon_idPersoon = @id;").ToList();
        var param = new MySqlParameter
        {
            ParameterName = "@id",
            Value = _id
        };
        CloseConnection();
    }
}
