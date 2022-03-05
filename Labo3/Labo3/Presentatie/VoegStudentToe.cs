using Labo3.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo3.Presentatie;
public partial class VoegStudentToe : Form
{
    private readonly ILogic _logic;
    public VoegStudentToe(ILogic logic)
    {
        _logic = logic;
        InitializeComponent();
    }

    private void Voegtoe(object sender, EventArgs e)
    {
        String vnaam = textBoxVnaam.Text;
        String fnaam = textBoxFnaam.Text;
        String Snr = textBoxSnr.Text;

        if (String.IsNullOrEmpty(vnaam) || String.IsNullOrEmpty(fnaam))
        {
            MessageBox.Show("Geef een voornaam en familienaam in!!!");
        }
        else
        {
            _logic.AddStudent(new Global.Student(vnaam, fnaam, Snr));
            MessageBox.Show("Student toegevoegd in database");
            this.Close();
        }
    }
}
