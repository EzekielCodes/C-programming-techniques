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
public partial class KoppelStudentOpo : Form
{
   
    private readonly IOpoController _opocontrol;
    private readonly IStudentController _studentcontrol;
    public KoppelStudentOpo(IStudentController x, IOpoController y)
    {
        _opocontrol = y;
        _studentcontrol = x;
        InitializeComponent();
        FillStudenten();
        //FillOpo();
    }

    public void FillStudenten()
    {
        var student = _studentcontrol.GetStudents().OrderBy(o => o.Familienaam)
               .ThenBy(o => o.Voornaam)
               .ToList();
        for (int i = 0; i < student.Count; i++)
            comboBoxStudenten.Items.Add(student[i]);
    }

    public void FillOpo()
    {
        List<Opo> opos = _opocontrol.GetOpo();
        var opo = _opocontrol.GetOpo().OrderBy(o => o.Code);
        comboBoxOpo.DataSource = opos.Except(opo).ToList();
    }

    private void buttonKoppel_Click(object sender, EventArgs e)
    {
        _studentcontrol.Addopo((Logica.Student)comboBoxStudenten.SelectedItem, (Logica.Opo)comboBoxOpo.SelectedItem);
        MessageBox.Show("Student is gekoppeled aan Opo");

    }

    private void KoppelStudentOpo_Load(object sender, EventArgs e)
    {

    }

    private void FillOpoEvent(object sender, EventArgs e)
    {
        List<Opo> opos = _opocontrol.GetOpo();
        var student = (Student)comboBoxStudenten.SelectedItem;
        Debug.WriteLine(String.Join(" ", student.OpoList));
        List<Opo> opoList = opos
            .Where(w => !student.OpoList.Contains(w))
            .ToList();

        comboBoxOpo.DataSource = opoList;
    }
}
