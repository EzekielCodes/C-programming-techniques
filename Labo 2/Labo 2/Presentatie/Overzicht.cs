using Labo_2.DataLayer;
using Labo_2.Logica;
using Labo_2.LogicLayer;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Linq;

namespace Labo_2;

public partial class Overzicht : Form
{
    private readonly IStudentController studentControll;
    private readonly IOpoController _opocontroll;
    protected StudentController studentcontrol;
    protected DocentController docentcontrol;
    public Overzicht()
    {
        
        InitializeComponent();
        studentcontrol = new StudentController();
        docentcontrol = new DocentController();
        Listview();
        FillStudenten();
        FillDocenten();
    }

    public void FillStudenten()
    {
        comboBoxStudenten.Items.Clear();
        var lijst = studentcontrol.GetStudents().OrderBy(o => o.Familienaam)
                .ThenBy(o => o.Voornaam)
                .ToList();
        
        for(int i = 0; i < lijst.Count; i++)
            comboBoxStudenten.Items.Add(lijst[i]);

    }
    
    public void FillDocenten()
    {
        comboBoxDocenten.Items.Clear(); 
        var lijst = docentcontrol.GetDocent().OrderBy(o => o.Familienaam)
                .ThenBy(o => o.Voornaam)
                .ToList();
        for (int i = 0; i < lijst.Count; i++)
            comboBoxDocenten.Items.Add(lijst[i]);
    }

    private void Overzicht_Load(object sender, EventArgs e)
    {

    }

    private void StudentenSelected(object sender, EventArgs e)
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

    private void VoegStudent(object sender, EventArgs e)
    {
        VoegStudentToe vg = new();
        vg.ShowDialog();
        
    }

    private void VoegDocent(object sender, EventArgs e)
    {
        VoegDocentToe vg = new();
        vg.ShowDialog();

    }

    private void DocentSelected(object sender, EventArgs e)
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

    private void VoegOpo(object sender, EventArgs e)
    {
        VoegOpoToe vg = new();
        vg.ShowDialog();
        studentcontrol = new StudentController();
        docentcontrol = new DocentController();
        FillStudenten();
        FillDocenten();
    }

    private void KoppelStudent_Click(object sender, EventArgs e)
    {
        KoppelStudentOpo vg = new();
        vg.ShowDialog();
        studentcontrol = new StudentController();
        docentcontrol = new DocentController();
        FillStudenten();
        FillDocenten();
    }

    private void KoppelDocenten_Click(object sender, EventArgs e)
    {
        KoppelDocentOpo vg = new();
        vg.ShowDialog();
        studentcontrol = new StudentController();
        docentcontrol = new DocentController();
        FillStudenten();
        FillDocenten();
    }

    private void DocentLoskoppelen_Click(object sender, EventArgs e)
    {
        LosKoppelenDocent vg = new();
        vg.ShowDialog();
        studentcontrol = new StudentController();
        docentcontrol = new DocentController();
        FillStudenten();
        FillDocenten();
    }

    private void StudentLoskoppelen_Click(object sender, EventArgs e)
    {
        LoskoppelenStudent vg = new();
        vg.ShowDialog();
        studentcontrol = new StudentController();
        docentcontrol = new DocentController();
        FillStudenten();
        FillDocenten();

        //Application.Restart();
    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    public void Listview()
    {
        listViewStudenten.Items.Clear();
        listViewStudenten.View = View.Details;
        listViewStudenten.GridLines = true;
        listViewStudenten.FullRowSelect = true;
        listViewStudenten.Columns.Add("OPO-code", 100);
        listViewStudenten.Columns.Add("OPO-Naam", 300);
        listViewStudenten.Columns.Add("Stp", 100);

        listViewDocenten.Items.Clear();
        listViewDocenten.View = View.Details;
        listViewDocenten.GridLines = true;
        listViewDocenten.FullRowSelect = true;
        listViewDocenten.Columns.Add("OPO-code", 100);
        listViewDocenten.Columns.Add("OPO-Naam", 300);
        listViewDocenten.Columns.Add("Stp", 100);
    }
}
