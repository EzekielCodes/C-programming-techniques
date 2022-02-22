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
    private readonly IOpoController _opocontrol;
    private readonly IDocentController _docentcontrol;
   /* protected OpoController opocontrol;
    protected DocentController docentcontrol;*/
    public KoppelDocentOpo(IDocentController x, IOpoController y)
    {
        _opocontrol = y;
        _docentcontrol = x;
        /*docentcontrol = new();
        opocontrol = new();*/
        InitializeComponent();
        FillDocenten();
        FillOpo();
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

    private void KoppelDocenten_Click(object sender, EventArgs e)
    {
        _docentcontrol.Addopo((Logica.Docent)comboBoxDocenten.SelectedItem, (Logica.Opo)comboBoxOpo.SelectedItem);
        MessageBox.Show("Docent is gekoppeled aan Opo");

    }
}
