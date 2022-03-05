namespace Labo3.Presentatie;

partial class LoskoppelenStudent
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
        this.label1 = new System.Windows.Forms.Label();
        this.comboBoxStudenten = new System.Windows.Forms.ComboBox();
        this.label2 = new System.Windows.Forms.Label();
        this.comboBoxOpo = new System.Windows.Forms.ComboBox();
        this.LosKoppelen = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(24, 27);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(73, 25);
        this.label1.TabIndex = 0;
        this.label1.Text = "Student";
        // 
        // comboBoxStudenten
        // 
        this.comboBoxStudenten.FormattingEnabled = true;
        this.comboBoxStudenten.Location = new System.Drawing.Point(24, 77);
        this.comboBoxStudenten.Name = "comboBoxStudenten";
        this.comboBoxStudenten.Size = new System.Drawing.Size(349, 33);
        this.comboBoxStudenten.TabIndex = 1;
        this.comboBoxStudenten.SelectedIndexChanged += new System.EventHandler(this.FillOpoStudenten);
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(442, 27);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(60, 25);
        this.label2.TabIndex = 2;
        this.label2.Text = "Opo\'s";
        // 
        // comboBoxOpo
        // 
        this.comboBoxOpo.FormattingEnabled = true;
        this.comboBoxOpo.Location = new System.Drawing.Point(442, 77);
        this.comboBoxOpo.Name = "comboBoxOpo";
        this.comboBoxOpo.Size = new System.Drawing.Size(570, 33);
        this.comboBoxOpo.TabIndex = 3;
        // 
        // LosKoppelen
        // 
        this.LosKoppelen.Location = new System.Drawing.Point(786, 247);
        this.LosKoppelen.Name = "LosKoppelen";
        this.LosKoppelen.Size = new System.Drawing.Size(148, 34);
        this.LosKoppelen.TabIndex = 4;
        this.LosKoppelen.Text = "LosKoppellen";
        this.LosKoppelen.UseVisualStyleBackColor = true;
        this.LosKoppelen.Click += new System.EventHandler(this.LosKoppelen_Click);
        // 
        // LoskoppelenStudent
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1024, 314);
        this.Controls.Add(this.LosKoppelen);
        this.Controls.Add(this.comboBoxOpo);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.comboBoxStudenten);
        this.Controls.Add(this.label1);
        this.Name = "LoskoppelenStudent";
        this.Text = "LoskoppelenStudent";
        this.Load += new System.EventHandler(this.LoskoppelenStudent_Load);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private Label label1;
    private ComboBox comboBoxStudenten;
    private Label label2;
    private ComboBox comboBoxOpo;
    private Button LosKoppelen;
}
