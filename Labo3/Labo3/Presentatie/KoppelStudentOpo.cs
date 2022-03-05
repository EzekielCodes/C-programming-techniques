using Labo3.DataLayer;
using Labo3.Global;
using System.Diagnostics;

namespace Labo3.Presentatie;
public partial class KoppelStudentOpo : Form
{
    private readonly ILogic _logic;
    public KoppelStudentOpo(ILogic logic)
    {
        _logic = logic;
        InitializeComponent();
        FillStudenten();
        //FillOpo();
    }

    public void FillStudenten()
    {
        var student = _logic.GetStudents().OrderBy(o => o.Familienaam)
               .ThenBy(o => o.Voornaam)
               .ToList();
        for (int i = 0; i < student.Count; i++)
            comboBoxStudenten.Items.Add(student[i]);
    }

    public void FillOpo()
    {
        List<Opo> opos = _logic.GetOpo();
        var opo = _logic.GetOpo().OrderBy(o => o.Code);
        comboBoxOpo.DataSource = opos.Except(opo).ToList();
    }

    private void buttonKoppel_Click(object sender, EventArgs e)
    {
        _logic.Addopo((Global.Student)comboBoxStudenten.SelectedItem, (Global.Opo)comboBoxOpo.SelectedItem);
        MessageBox.Show("Student is gekoppeled aan Opo");

    }

    private void KoppelStudentOpo_Load(object sender, EventArgs e)
    {

    }

    private void FillOpoEvent(object sender, EventArgs e)
    {
        List<Opo> opos = _logic.GetOpo();
        var student = (Student)comboBoxStudenten.SelectedItem;
        Debug.WriteLine(String.Join(" ", student.OpoList));
        List<Opo> opoList = opos
            .Where(w => !student.OpoList.Contains(w))
            .OrderBy(o => o.Code)
            .ToList();

        comboBoxOpo.DataSource = opoList;
    }
}
