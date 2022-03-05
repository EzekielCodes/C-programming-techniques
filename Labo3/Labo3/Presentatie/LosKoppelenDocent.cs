using Labo3.DataLayer;
using Labo3.Global;
using System.Diagnostics;

namespace Labo3.Presentatie;
public partial class LosKoppelenDocent : Form
{
    private readonly ILogic _logic;
    public LosKoppelenDocent(ILogic logic)
    {
        _logic = logic;
        InitializeComponent();
        FillDocenten();
        //FillOpo();
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

    private void LosKoppelenDocent_Load(object sender, EventArgs e)
    {

    }

    private void LosKoppelen_Click(object sender, EventArgs e)
    {
        _logic.RemoveOpo((Global.Docent)comboBoxDocenten.SelectedItem, (Global.Opo)comboBoxOpo.SelectedItem);
        MessageBox.Show("Docent is Los gekoppeled aan Opo");
    }

    private void FillOpoDocenten(object sender, EventArgs e)
    {
        
        var docent = (Docent)comboBoxDocenten.SelectedItem;
        Debug.WriteLine(String.Join(" ", docent.OpoList));
        var docentOpo = docent.OpoList.OrderBy(o => o.Code).ToList();
        comboBoxOpo.DataSource = docentOpo;
    }
}
