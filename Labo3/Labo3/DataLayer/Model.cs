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
        _connectionString = "mongodb://127.0.0.1:27017/Labo";

    }
}
