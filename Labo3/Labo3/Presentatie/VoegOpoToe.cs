using Labo3.DataLayer;
using Labo3.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo3.Presentatie;
public partial class VoegOpoToe : Form
{
    private readonly ILogic _logic;
    public VoegOpoToe(ILogic logic)
    {
        _logic = logic;
        InitializeComponent();
        foreach (var fase in Enum.GetValues(typeof(Fase)))
        {
            comboBoxfase.Items.Add(fase);
        }

        foreach (var semester in Enum.GetValues(typeof(Semester)))
        {
            comboBoxSemester.Items.Add(semester);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        String code = textBoxCode.Text;
        String naam = textBoxNaam.Text;
        String stp = textBoxStp.Text;
        String fase = comboBoxfase.GetItemText(comboBoxfase.SelectedItem);
        String semester = comboBoxSemester.GetItemText(comboBoxSemester.SelectedItem);

        Debug.WriteLine(code + naam + stp + fase + semester);
        if (String.IsNullOrEmpty(code) || String.IsNullOrEmpty(naam) || String.IsNullOrEmpty(stp) || String.IsNullOrEmpty(fase) || String.IsNullOrEmpty(semester))
        {
            MessageBox.Show("Geef een voornaam en familienaam in!!!");
        }
        else
        {
            _logic.AddOpo(new Global.Opo(code, naam, Int32.Parse(stp), Enum.Parse<Fase>(fase), Enum.Parse<Semester>(semester)));
            MessageBox.Show("Opo toegevoegd in database");
            this.Close();
        }

    }
}
