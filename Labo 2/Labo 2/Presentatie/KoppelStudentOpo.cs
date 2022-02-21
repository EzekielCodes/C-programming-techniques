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
    protected OpoController opocontrol;
    protected StudentController studentcontrol;
    public KoppelStudentOpo()
    {
        opocontrol = new();
        studentcontrol = new();
        InitializeComponent();
        FillStudenten();
        FillOpo();
    }

    public void FillStudenten()
    {
        var lijst = studentcontrol.GetStudents().OrderBy(o => o.Familienaam)
               .ThenBy(o => o.Voornaam)
               .ToList();
        for (int i = 0; i < lijst.Count; i++)
            comboBoxStudenten.Items.Add(lijst[i]);
    }

    public void FillOpo()
    {
        var lijst = opocontrol.GetOpo().OrderBy(o => o.Code);
        foreach(var o in lijst)
        {
            comboBoxOpo.Items.Add(o);
        }
    }

    private void buttonKoppel_Click(object sender, EventArgs e)
    {
        studentcontrol.Addopo((Logica.Student)comboBoxStudenten.SelectedItem, (Logica.Opo)comboBoxOpo.SelectedItem);
        MessageBox.Show("Student is gekoppeled aan Opo");

    }

    private void KoppelStudentOpo_Load(object sender, EventArgs e)
    {

    }
}
