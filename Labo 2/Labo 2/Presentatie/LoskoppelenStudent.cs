using Labo_2.Logica;
using Labo_2.LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo_2;
public partial class LoskoppelenStudent : Form
{
    private readonly IStudentController _studentcontrol;
    private readonly IOpoController _opocontrol;
    /*protected OpoController opocontrol;
    protected StudentController studentcontrol;*/
    public LoskoppelenStudent(IStudentController x, IOpoController y)
    {
        _opocontrol = y;
        _studentcontrol = x;
        /*opocontrol = new();
        studentcontrol = new();*/
        InitializeComponent();
        FillStudenten();
        //FillOpo();
    }

    public void FillStudenten()
    {
     
        var lijst = _studentcontrol.GetStudents().OrderBy(o => o.Familienaam)
               .ThenBy(o => o.Voornaam)
               .ToList();
        for (int i = 0; i < lijst.Count; i++)
            comboBoxStudenten.Items.Add(lijst[i]);
    }

    public void FillOpo()
    {
        var lijst = _opocontrol.GetOpo().OrderBy(o => o.Code);
        foreach (var o in lijst)
        {
            comboBoxOpo.Items.Add(o);
        }
    }

    private void LoskoppelenStudent_Load(object sender, EventArgs e)
    {

    }

    private void LosKoppelen_Click(object sender, EventArgs e)
    {
        _studentcontrol.RemoveOpo((Logica.Student)comboBoxStudenten.SelectedItem, (Logica.Opo)comboBoxOpo.SelectedItem);
        MessageBox.Show("Student is Los gekoppeled aan Opo");
    }

    private void FillOpoStudenten(object sender, EventArgs e)
    {
        
        var student = (Student)comboBoxStudenten.SelectedItem;
        Debug.WriteLine(String.Join(" ", student.OpoList));
        var studentOpo = student.OpoList.OrderBy(o => o.Code).ToList();
        comboBoxOpo.DataSource = studentOpo;
    }
}
