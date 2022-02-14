using Labo1.Datalaag;
using System.Diagnostics;
using System.Linq;

namespace Labo1;

public partial class LaboApplicatie : Form
{
    private readonly ConnectionAdo _connectionAdo =  new();
    //private readonly ConnectionDapper _connectionAdo = new();
    public String Naam;
    public LaboApplicatie()
    {
        InitializeComponent();
        //_connectionDapper.Initialize();
       
        _connectionAdo.Initialize();
        FillComboboxDocenten();
        FillComboboxStudenten();
    }
    private void FillComboboxDocenten()
    {
        var docentenLijst = _connectionAdo.docentenNaam.OrderBy(o => o.Naam)
            .ThenBy(o => o.Voornaam)
            .ToList();
        for (int i = 0; i < docentenLijst.Count; i++)
            docentenComboBox.Items.Add(docentenLijst[i]);
    }

    private void FillComboboxStudenten()
    {
        var studentenLijst = _connectionAdo.studentenNaam.OrderBy(o => o.Naam)
            .ThenBy(o => o.Voornaam)
            .ToList();
        for (int i = 0; i < studentenLijst.Count; i++)
            studentenComboBox.Items.Add(studentenLijst[i]);
    }

    private void DocentenSelected(object sender, EventArgs e)
    {
        Naam = docentenComboBox.GetItemText(docentenComboBox.SelectedItem.ToString());
        string[] tokens = Naam.Split(' ');
        _connectionAdo.Naam = tokens[0];
        _connectionAdo.GetIdFromNaam(tokens[0], tokens[1]);
        _connectionAdo.ReadVakkenDocenten();
        docentenTextBox.Clear();
        var opoNamen = _connectionAdo.opoNaam.OrderBy(o => o.Code).ToList();
        docentenTextBox.Text = String.Join(Environment.NewLine, opoNamen);
        
    }

    private void StudentenSelected(object sender, EventArgs e)
    {
        Naam = studentenComboBox.GetItemText(studentenComboBox.SelectedItem.ToString());
        string[] tokens = Naam.Split(' ');
        _connectionAdo.Naam = tokens[0];
        _connectionAdo.GetIdFromNaam(tokens[0], tokens[1]);
        _connectionAdo.ReadVakkenStudenten();
        studentenTextBox.Clear();
        var opoNamen = _connectionAdo.opoNaam.OrderBy(o => o.Code).ToList();
        studentenTextBox.Text = String.Join(Environment.NewLine, opoNamen);
       
    }

    private void LaboApplicatie_Load(object sender, EventArgs e)
    {

    }
}
