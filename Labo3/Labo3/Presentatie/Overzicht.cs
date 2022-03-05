using Labo3.DataLayer;
using Labo3.Global;
using Labo3.Presentatie;
using System.Diagnostics;

namespace Labo3;

public partial class Overzicht : Form
{
    private readonly ILogic _logic;
    public Overzicht(ILogic logic)
    {
        _logic = logic;
        InitializeComponent();
        Listview();
        FillStudenten();
        FillDocenten();
    }

    public void FillStudenten()
    {
        
        comboBoxStudenten.Items.Clear();
        var lijst = _logic.GetStudents().OrderBy(o => o.Familienaam)
                .ThenBy(o => o.Voornaam)
                .ToList();

        for (int i = 0; i < lijst.Count; i++)
            comboBoxStudenten.Items.Add(lijst[i]);

    }

    public void FillDocenten()
    {
        comboBoxDocenten.Items.Clear();
        var lijst = _logic.GetDocent().OrderBy(o => o.Familienaam)
                .ThenBy(o => o.Voornaam)
                .ToList();
        for (int i = 0; i < lijst.Count; i++)
            comboBoxDocenten.Items.Add(lijst[i]);
    }

    private void Docenttoevoegen(object sender, EventArgs e)
    {
        VoegDocentToe vg = new(_logic);
        vg.ShowDialog();
    }

    private void Opotoevoegen(object sender, EventArgs e)
    {
        VoegOpoToe vg = new(_logic);
        vg.ShowDialog();
    }

    private void Studenttoevoegen(object sender, EventArgs e)
    {
        VoegStudentToe vg = new(_logic);
        vg.ShowDialog();
    }

    private void DocentKoppelen(object sender, EventArgs e)
    {
        KoppelDocentOpo vg = new(_logic);
        vg.ShowDialog();
    }

    private void StudentKoppelen(object sender, EventArgs e)
    {
        KoppelStudentOpo vg = new(_logic);
        vg.ShowDialog();
    }

    private void StudentLoskoppelen(object sender, EventArgs e)
    {

    }

    private void DocentLoskoppelen(object sender, EventArgs e)
    {

    }

    private void StudentSelected(object sender, EventArgs e)
    {
        listViewStudenten.Items.Clear();
        var student = (Student)comboBoxStudenten.SelectedItem;
        Debug.WriteLine(String.Join(" ", student.OpoList));
        foreach (var (s, item) in from s in student.OpoList.OrderBy(o => o.Code)
                                  let item = new ListViewItem()
                                  select (s, item))
        {
            item.Text = s.Code;
            item.SubItems.Add(s.Naam);
            item.SubItems.Add(s.Stp.ToString());
            listViewStudenten.Items.Add(item);
        }
    }

    private void SelectedDocenten(object sender, EventArgs e)
    {
        listViewDocenten.Items.Clear();
        var docent = (Docent)comboBoxDocenten.SelectedItem;
        Debug.WriteLine(String.Join(" ", docent.OpoList));
        foreach (var (s, item) in from s in docent.OpoList.OrderBy(o => o.Code)
                                  let item = new ListViewItem()
                                  select (s, item))
        {
            item.Text = s.Code;
            item.SubItems.Add(s.Naam);
            item.SubItems.Add(s.Stp.ToString());
            listViewDocenten.Items.Add(item);
        }
    }
    public void Listview()
    {
        listViewStudenten.Items.Clear();
        listViewStudenten.View = View.Details;
        listViewStudenten.GridLines = true;
        listViewStudenten.FullRowSelect = true;
        listViewStudenten.Columns.Add("OPO-code", 150);
        listViewStudenten.Columns.Add("OPO-Naam", 500);
        listViewStudenten.Columns.Add("Stp", 200);

        listViewDocenten.Items.Clear();
        listViewDocenten.View = View.Details;
        listViewDocenten.GridLines = true;
        listViewDocenten.FullRowSelect = true;
        listViewDocenten.Columns.Add("OPO-code", 150);
        listViewDocenten.Columns.Add("OPO-Naam", 500);
        listViewDocenten.Columns.Add("Stp", 200);
    }

    private void listViewDocenten_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
