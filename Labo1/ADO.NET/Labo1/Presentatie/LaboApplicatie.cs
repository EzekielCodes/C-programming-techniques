using Labo1.Datalaag;
using System.Diagnostics;

namespace Labo1;

public partial class LaboApplicatie : Form
{
    private readonly Connection _connection =  new();
    public String Naam;
    public LaboApplicatie()
    {
        InitializeComponent();
        _connection.Initialize();
        FillComboboxDocenten();
        FillComboboxStudenten();
        

    }
    private void FillComboboxDocenten()
    {
        var docentenLijst = _connection.docentenNaam;
        for (int i = 0; i < docentenLijst.Count; i++)
            docentenComboBox.Items.Add(docentenLijst[i]);
    }

    private void FillComboboxStudenten()
    {
        var studentenLijst = _connection.studentenNaam;
        for (int i = 0; i < studentenLijst.Count; i++)
            studentenComboBox.Items.Add(studentenLijst[i]);
    }

    private void DocentenSelected(object sender, EventArgs e)
    {

        Naam = docentenComboBox.GetItemText(docentenComboBox.SelectedItem.ToString());
        string[] tokens = Naam.Split(' ');
        _connection.Naam = tokens[0];
        _connection.GetIdFromNaam(tokens[0]);
        _connection.ReadVakkenDocenten();
        docentenTextBox.Clear();
        docentenTextBox.Text = String.Join(Environment.NewLine, _connection.vaakNaamDocenten);
        //Debug.WriteLine(_connection.Naam);
    }

    private void StudentenSelected(object sender, EventArgs e)
    {
        Naam = studentenComboBox.GetItemText(studentenComboBox.SelectedItem.ToString());
        string[] tokens = Naam.Split(' ');
        _connection.Naam = tokens[0];
        _connection.GetIdFromNaam(tokens[0]);
        _connection.ReadVakkenStudenten();
        studentenTextBox.Clear();
        studentenTextBox.Text = String.Join(Environment.NewLine, _connection.vaakNaamStudenten);
        //Debug.WriteLine(_connection.Naam);
    }
}
