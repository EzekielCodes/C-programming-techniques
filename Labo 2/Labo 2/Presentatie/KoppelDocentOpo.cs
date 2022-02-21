using Labo_2.LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo_2;
public partial class KoppelDocentOpo : Form
{
    protected OpoController opocontrol;
    protected DocentController docentcontrol;
    public KoppelDocentOpo()
    {
        docentcontrol = new();
        opocontrol = new();
        InitializeComponent();
        FillDocenten();
        FillOpo();
    }

    public void FillDocenten()
    {
        var lijst = docentcontrol.GetDocent().OrderBy(o => o.Familienaam)
               .ThenBy(o => o.Voornaam)
               .ToList();
        for (int i = 0; i < lijst.Count; i++)
            comboBoxDocenten.Items.Add(lijst[i]);
    }

    public void FillOpo()
    {
        var lijst = opocontrol.GetOpo().OrderBy(o => o.Code);
        foreach (var o in lijst)
        {
            comboBoxOpo.Items.Add(o);
        }
    }

    private void KoppelDocenten_Click(object sender, EventArgs e)
    {
        docentcontrol.Addopo((Logica.Docent)comboBoxDocenten.SelectedItem, (Logica.Opo)comboBoxOpo.SelectedItem);
        MessageBox.Show("Docent is gekoppeled aan Opo");

    }
}
