namespace Labo3.Presentatie;

partial class KoppelStudentOpo
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
        this.label2 = new System.Windows.Forms.Label();
        this.comboBoxStudenten = new System.Windows.Forms.ComboBox();
        this.comboBoxOpo = new System.Windows.Forms.ComboBox();
        this.buttonKoppel = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(50, 52);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(92, 25);
        this.label1.TabIndex = 0;
        this.label1.Text = "Studenten";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(516, 52);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(60, 25);
        this.label2.TabIndex = 1;
        this.label2.Text = "Opo\'s";
        // 
        // comboBoxStudenten
        // 
        this.comboBoxStudenten.FormattingEnabled = true;
        this.comboBoxStudenten.Location = new System.Drawing.Point(50, 107);
        this.comboBoxStudenten.Name = "comboBoxStudenten";
        this.comboBoxStudenten.Size = new System.Drawing.Size(297, 33);
        this.comboBoxStudenten.TabIndex = 2;
        this.comboBoxStudenten.SelectedIndexChanged += new System.EventHandler(this.FillOpoEvent);
        // 
        // comboBoxOpo
        // 
        this.comboBoxOpo.FormattingEnabled = true;
        this.comboBoxOpo.Location = new System.Drawing.Point(449, 107);
        this.comboBoxOpo.Name = "comboBoxOpo";
        this.comboBoxOpo.Size = new System.Drawing.Size(442, 33);
        this.comboBoxOpo.TabIndex = 3;
        // 
        // buttonKoppel
        // 
        this.buttonKoppel.Location = new System.Drawing.Point(779, 261);
        this.buttonKoppel.Name = "buttonKoppel";
        this.buttonKoppel.Size = new System.Drawing.Size(112, 34);
        this.buttonKoppel.TabIndex = 4;
        this.buttonKoppel.Text = "Koppel";
        this.buttonKoppel.UseVisualStyleBackColor = true;
        this.buttonKoppel.Click += new System.EventHandler(this.buttonKoppel_Click);
        // 
        // KoppelStudentOpo
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(948, 381);
        this.Controls.Add(this.buttonKoppel);
        this.Controls.Add(this.comboBoxOpo);
        this.Controls.Add(this.comboBoxStudenten);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Name = "KoppelStudentOpo";
        this.Text = "KoppelStudentOpo";
        this.Load += new System.EventHandler(this.KoppelStudentOpo_Load);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private Label label1;
    private Label label2;
    private ComboBox comboBoxStudenten;
    private ComboBox comboBoxOpo;
    private Button buttonKoppel;
}
