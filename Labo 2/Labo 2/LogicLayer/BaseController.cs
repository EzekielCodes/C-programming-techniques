using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labo_2.DataLayer;


namespace Labo_2.LogicLayer;

public class BaseController
{
    protected IModel m;
   
    public BaseController()
    {
        m = new Model(); 
    }
}
