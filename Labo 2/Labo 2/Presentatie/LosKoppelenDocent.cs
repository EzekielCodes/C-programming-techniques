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
public partial class LosKoppelenDocent : Form
{
    private readonly IOpoController _opocontrol;
    private readonly IDocentController _docentcontrol;
    /*protected OpoController opocontrol;
    protected DocentController docentcontrol;*/
    public LosKoppelenDocent(IDocentController x,IOpoController y)
    {
        _opocontrol = y;
        _docentcontrol = x;
        /*opocontrol = new();
        docentcontrol = new();*/
        InitializeComponent();
        FillDocenten();
        //FillOpo();
    }

    public void FillDocenten()
    {
        var lijst = _docentcontrol.GetDocent().OrderBy(o => o.Familienaam)
               .ThenBy(o => o.Voornaam)
               .ToList();
        for (int i = 0; i < lijst.Count; i++)
            comboBoxDocenten.Items.Add(lijst[i]);
    }

    public void FillOpo()
    {
        var lijst = _opocontrol.GetOpo().OrderBy(o => o.Code);
        foreach (var o in lijst)
        {
            comboBoxOpo.Items.Add(o);
        }
    }

    private void LosKoppelenDocent_Load(object sender, EventArgs e)
    {

    }

    private void LosKoppelen_Click(object sender, EventArgs e)
    {
        _docentcontrol.RemoveOpo((Logica.Docent)comboBoxDocenten.SelectedItem, (Logica.Opo)comboBoxOpo.SelectedItem);
        MessageBox.Show("Docent is Los gekoppeled aan Opo");
    }

    private void FillOpoDocenten(object sender, EventArgs e)
    {
        comboBoxOpo.Items.Clear();
        var docent = (Docent)comboBoxDocenten.SelectedItem;
        Debug.WriteLine(String.Join(" ", docent.OpoList));
        comboBoxOpo.DataSource = docent.OpoList;
    }
}
