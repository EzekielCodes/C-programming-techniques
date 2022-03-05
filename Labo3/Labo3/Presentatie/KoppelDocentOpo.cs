using Labo3.DataLayer;
using Labo3.Global;
using System.Diagnostics;

namespace Labo3.Presentatie;
public partial class KoppelDocentOpo : Form
{
    private readonly ILogic _logic;
    public KoppelDocentOpo(ILogic logic)
    {
        _logic = logic;
        InitializeComponent();
        FillDocenten();
    }

    public void FillDocenten()
    {
        var lijst = _logic.GetDocent().OrderBy(o => o.Familienaam)
               .ThenBy(o => o.Voornaam)
               .ToList();
        for (int i = 0; i < lijst.Count; i++)
            comboBoxDocenten.Items.Add(lijst[i]);
    }

    public void FillOpo()
    {
        var lijst = _logic.GetOpo().OrderBy(o => o.Code);
        foreach (var o in lijst)
        {
            comboBoxOpo.Items.Add(o);
        }
    }

    private void KoppelDocenten_Click(object sender, EventArgs e)
    {
        _logic.Addopo((Global.Docent)comboBoxDocenten.SelectedItem, (Global.Opo)comboBoxOpo.SelectedItem);
        MessageBox.Show("Docent is gekoppeled aan Opo");

    }

    private void FillDocentEvent(object sender, EventArgs e)
    {
 
        List<Opo> opos = _logic.GetOpo();
        var docent = (Docent)comboBoxDocenten.SelectedItem;
        Debug.WriteLine(String.Join(" ", docent.OpoList));
        List<Opo> opoList = opos
            .Where(w => !docent.OpoList.Contains(w))
            .OrderBy(o => o.Code)
            .ToList();

        comboBoxOpo.DataSource = opoList;
    }
}
