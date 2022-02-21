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
public partial class VoegDocentToe : Form
{
    protected DocentController docentcontrol;
    public VoegDocentToe()
    {
        docentcontrol = new();
        InitializeComponent();
    }

    private void VoegDocentToe_Load(object sender, EventArgs e)
    {

    }

    private void buttonVoeg(object sender, EventArgs e)
    {
        String vnaam = textboxVnaam.Text;
        String fnaam = textBoxFnaam.Text;
        String Snr = textBoxSnummer.Text;

        if (String.IsNullOrEmpty(vnaam) || String.IsNullOrEmpty(fnaam))
        {
            MessageBox.Show("Geef een voornaam en familienaam in!!!");
        }
        else
        {
            docentcontrol.AddDocent(new Logica.Docent(vnaam, fnaam, Snr));
            MessageBox.Show("Docent toegevoegd in database");
            this.Close();
        }
    }
}
