using Labo1.Datalaag;
using System.Diagnostics;

namespace Labo1;

public partial class LaboApplicatie : Form
{
    private Connection _connection =  new Connection();
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
        docentenTextBox.Clear();
        docentenTextBox.Text = " ";
        Naam = this.docentenComboBox.GetItemText(this.docentenComboBox.SelectedItem.ToString());
        string[] tokens = Naam.Split(' ');
        _connection.Naam = tokens[0];
        _connection.GetIdFromNaam(tokens[0]);
        _connection.ReadVakkenDocenten();
        //docentenTextBox.Clear();
        docentenTextBox.Text = String.Join(Environment.NewLine, _connection.vaakNaam);
        Debug.WriteLine(_connection.Naam);
    }
}
