using Labo_2.LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo_2;
public partial class VoegStudentToe : Form
{
    protected StudentController studentcontrol;
    public VoegStudentToe()
    {
        studentcontrol = new();
        InitializeComponent();

    }

    private void VoegStudentToe_Load(object sender, EventArgs e)
    {

    }

    private void buttonVoeg(object sender, EventArgs e)
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
            studentcontrol.AddStudent(new Logica.Student(vnaam, fnaam, Snr));
            MessageBox.Show("Student toegevoegd in database");
            this.Close();
        }
     
        
    }
}
