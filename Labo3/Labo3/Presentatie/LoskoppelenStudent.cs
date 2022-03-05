using Labo3.DataLayer;
using Labo3.Global;
using System.Diagnostics;

namespace Labo3.Presentatie;
public partial class LoskoppelenStudent : Form
{
    private readonly ILogic _logic;
    public LoskoppelenStudent(ILogic logic)
    {
        _logic = logic;
        InitializeComponent();
        FillStudenten();
        //FillOpo();
    }

    public void FillStudenten()
    {
     
        var lijst = _logic.GetStudents().OrderBy(o => o.Familienaam)
               .ThenBy(o => o.Voornaam)
               .ToList();
        for (int i = 0; i < lijst.Count; i++)
            comboBoxStudenten.Items.Add(lijst[i]);
    }

    public void FillOpo()
    {
        var lijst = _logic.GetOpo().OrderBy(o => o.Code);
        foreach (var o in lijst)
        {
            comboBoxOpo.Items.Add(o);
        }
    }

    private void LoskoppelenStudent_Load(object sender, EventArgs e)
    {

    }

    private void LosKoppelen_Click(object sender, EventArgs e)
    {
        _logic.RemoveOpo((Global.Student)comboBoxStudenten.SelectedItem, (Global.Opo)comboBoxOpo.SelectedItem);
        MessageBox.Show("Student is Los gekoppeled aan Opo");
    }

    private void FillOpoStudenten(object sender, EventArgs e)
    {
        
        var student = (Student)comboBoxStudenten.SelectedItem;
        Debug.WriteLine(String.Join(" ", student.OpoList));
        var studentOpo = student.OpoList.OrderBy(o => o.Code).ToList();
        comboBoxOpo.DataSource = studentOpo;
    }
}
