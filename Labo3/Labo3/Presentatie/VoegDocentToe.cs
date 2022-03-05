using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Labo3.DataLayer;

namespace Labo3.Presentatie;
public partial class VoegDocentToe : Form
{
    private readonly ILogic _logic;
    public VoegDocentToe(ILogic logic)
    {
        _logic = logic;
        InitializeComponent();
    }

    private void Voegtoe(object sender, EventArgs e)
    {
        String vnaam = textBoxVnaam.Text;
        String fnaam = textBoxFnaam.Text;
        String Snr = textBoxSnummer.Text;

        if (String.IsNullOrEmpty(vnaam) || String.IsNullOrEmpty(fnaam))
        {
            MessageBox.Show("Geef een voornaam en familienaam in!!!");
        }
        else
        {
            _logic.AddDocent(new Global.Docent(vnaam, fnaam, Snr));
            MessageBox.Show("Docent toegevoegd in database");
            this.Close();
        }
    }
}
