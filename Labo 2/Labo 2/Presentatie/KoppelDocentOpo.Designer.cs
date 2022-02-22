namespace Labo_2;

partial class KoppelDocentOpo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxOpo = new System.Windows.Forms.ComboBox();
            this.KoppelDocenten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxDocenten
            // 
            this.comboBoxDocenten.FormattingEnabled = true;
            this.comboBoxDocenten.Location = new System.Drawing.Point(38, 92);
            this.comboBoxDocenten.Name = "comboBoxDocenten";
            this.comboBoxDocenten.Size = new System.Drawing.Size(343, 33);
            this.comboBoxDocenten.TabIndex = 0;
            this.comboBoxDocenten.SelectedIndexChanged += new System.EventHandler(this.FillDocentEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Docenten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opo\'s";
            // 
            // comboBoxOpo
            // 
            this.comboBoxOpo.FormattingEnabled = true;
            this.comboBoxOpo.Location = new System.Drawing.Point(507, 92);
            this.comboBoxOpo.Name = "comboBoxOpo";
            this.comboBoxOpo.Size = new System.Drawing.Size(478, 33);
            this.comboBoxOpo.TabIndex = 3;
            // 
            // KoppelDocenten
            // 
            this.KoppelDocenten.Location = new System.Drawing.Point(840, 231);
            this.KoppelDocenten.Name = "KoppelDocenten";
            this.KoppelDocenten.Size = new System.Drawing.Size(112, 34);
            this.KoppelDocenten.TabIndex = 4;
            this.KoppelDocenten.Text = "Koppel";
            this.KoppelDocenten.UseVisualStyleBackColor = true;
            this.KoppelDocenten.Click += new System.EventHandler(this.KoppelDocenten_Click);
            // 
            // KoppelDocentOpo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 355);
            this.Controls.Add(this.KoppelDocenten);
            this.Controls.Add(this.comboBoxOpo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDocenten);
            this.Name = "KoppelDocentOpo";
            this.Text = "KoppelDocentOpo";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private ComboBox comboBoxDocenten;
    private Label label1;
    private Label label2;
    private ComboBox comboBoxOpo;
    private Button KoppelDocenten;
}
