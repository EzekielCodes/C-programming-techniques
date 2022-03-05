namespace Labo3.Presentatie;

partial class LosKoppelenDocent
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.comboBoxDocenten = new System.Windows.Forms.ComboBox();
        this.comboBoxOpo = new System.Windows.Forms.ComboBox();
        this.LosKoppelen = new System.Windows.Forms.Button();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // comboBoxDocenten
        // 
        this.comboBoxDocenten.FormattingEnabled = true;
        this.comboBoxDocenten.Location = new System.Drawing.Point(26, 67);
        this.comboBoxDocenten.Name = "comboBoxDocenten";
        this.comboBoxDocenten.Size = new System.Drawing.Size(336, 33);
        this.comboBoxDocenten.TabIndex = 0;
        this.comboBoxDocenten.SelectedIndexChanged += new System.EventHandler(this.FillOpoDocenten);
        // 
        // comboBoxOpo
        // 
        this.comboBoxOpo.FormattingEnabled = true;
        this.comboBoxOpo.Location = new System.Drawing.Point(480, 67);
        this.comboBoxOpo.Name = "comboBoxOpo";
        this.comboBoxOpo.Size = new System.Drawing.Size(516, 33);
        this.comboBoxOpo.TabIndex = 1;
        // 
        // LosKoppelen
        // 
        this.LosKoppelen.Location = new System.Drawing.Point(856, 211);
        this.LosKoppelen.Name = "LosKoppelen";
        this.LosKoppelen.Size = new System.Drawing.Size(140, 34);
        this.LosKoppelen.TabIndex = 2;
        this.LosKoppelen.Text = "LosKoppelen";
        this.LosKoppelen.UseVisualStyleBackColor = true;
        this.LosKoppelen.Click += new System.EventHandler(this.LosKoppelen_Click);
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(26, 21);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(69, 25);
        this.label1.TabIndex = 3;
        this.label1.Text = "Docent";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(480, 21);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(48, 25);
        this.label2.TabIndex = 4;
        this.label2.Text = "Opo";
        // 
        // LosKoppelenDocent
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1100, 314);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.LosKoppelen);
        this.Controls.Add(this.comboBoxOpo);
        this.Controls.Add(this.comboBoxDocenten);
        this.Name = "LosKoppelenDocent";
        this.Text = "LosKoppelenDocent";
        this.Load += new System.EventHandler(this.LosKoppelenDocent_Load);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private ComboBox comboBoxDocenten;
    private ComboBox comboBoxOpo;
    private Button LosKoppelen;
    private Label label1;
    private Label label2;
}
