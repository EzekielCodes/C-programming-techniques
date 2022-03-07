using DocumentFormat.OpenXml.Spreadsheet;
using Labo3.Global;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3.DataLayer;

public class Model : IModel
{
    private string _connectionString;
    public string ConnectionString { get { return _connectionString; } }

    public Model()
    {
        _connectionString = "mongodb+srv://Akindele:Azerty123@cluster0.lp0bf.mongodb.net/Labo?retryWrites=true&w=majority";

    }
}
