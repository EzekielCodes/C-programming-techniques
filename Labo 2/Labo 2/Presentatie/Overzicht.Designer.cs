namespace Labo_2;

partial class Overzicht
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDocenten = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxStudenten = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DocentToevegen = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.KoppelDocenten = new System.Windows.Forms.Button();
            this.KoppelStudent = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DocentLoskoppelen = new System.Windows.Forms.Button();
            this.StudentLoskoppelen = new System.Windows.Forms.Button();
            this.listViewStudenten = new System.Windows.Forms.ListView();
            this.listViewDocenten = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Docent";
            // 
            // comboBoxDocenten
            // 
            this.comboBoxDocenten.FormattingEnabled = true;
            this.comboBoxDocenten.Location = new System.Drawing.Point(12, 37);
            this.comboBoxDocenten.Name = "comboBoxDocenten";
            this.comboBoxDocenten.Size = new System.Drawing.Size(522, 33);
            this.comboBoxDocenten.TabIndex = 1;
            this.comboBoxDocenten.SelectedIndexChanged += new System.EventHandler(this.DocentSelected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opo\'s gegeveens door docent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Studenten";
            // 
            // comboBoxStudenten
            // 
            this.comboBoxStudenten.FormattingEnabled = true;
            this.comboBoxStudenten.Location = new System.Drawing.Point(13, 366);
            this.comboBoxStudenten.Name = "comboBoxStudenten";
            this.comboBoxStudenten.Size = new System.Drawing.Size(521, 33);
            this.comboBoxStudenten.TabIndex = 5;
            this.comboBoxStudenten.SelectedIndexChanged += new System.EventHandler(this.StudentenSelected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Opo\'s gevolgd door student";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Opo toevoegen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.VoegOpo);
            // 
            // DocentToevegen
            // 
            this.DocentToevegen.Location = new System.Drawing.Point(646, 129);
            this.DocentToevegen.Name = "DocentToevegen";
            this.DocentToevegen.Size = new System.Drawing.Size(264, 34);
            this.DocentToevegen.TabIndex = 9;
            this.DocentToevegen.Text = "Docent toevoegen";
            this.DocentToevegen.UseVisualStyleBackColor = true;
            this.DocentToevegen.Click += new System.EventHandler(this.VoegDocent);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(646, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(264, 34);
            this.button3.TabIndex = 10;
            this.button3.Text = "Student toevoegen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.VoegStudent);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Toevoegen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Koppelen";
            // 
            // KoppelDocenten
            // 
            this.KoppelDocenten.Location = new System.Drawing.Point(646, 311);
            this.KoppelDocenten.Name = "KoppelDocenten";
            this.KoppelDocenten.Size = new System.Drawing.Size(264, 34);
            this.KoppelDocenten.TabIndex = 13;
            this.KoppelDocenten.Text = "Docent aan opo koppelen";
            this.KoppelDocenten.UseVisualStyleBackColor = true;
            this.KoppelDocenten.Click += new System.EventHandler(this.KoppelDocenten_Click);
            // 
            // KoppelStudent
            // 
            this.KoppelStudent.Location = new System.Drawing.Point(646, 387);
            this.KoppelStudent.Name = "KoppelStudent";
            this.KoppelStudent.Size = new System.Drawing.Size(264, 34);
            this.KoppelStudent.TabIndex = 14;
            this.KoppelStudent.Text = "Student aan opo koppelen";
            this.KoppelStudent.UseVisualStyleBackColor = true;
            this.KoppelStudent.Click += new System.EventHandler(this.KoppelStudent_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(573, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "LosKoppelen";
            // 
            // DocentLoskoppelen
            // 
            this.DocentLoskoppelen.Location = new System.Drawing.Point(646, 530);
            this.DocentLoskoppelen.Name = "DocentLoskoppelen";
            this.DocentLoskoppelen.Size = new System.Drawing.Size(264, 34);
            this.DocentLoskoppelen.TabIndex = 16;
            this.DocentLoskoppelen.Text = "Docent-opo loskoppelen";
            this.DocentLoskoppelen.UseVisualStyleBackColor = true;
            this.DocentLoskoppelen.Click += new System.EventHandler(this.DocentLoskoppelen_Click);
            // 
            // StudentLoskoppelen
            // 
            this.StudentLoskoppelen.Location = new System.Drawing.Point(646, 604);
            this.StudentLoskoppelen.Name = "StudentLoskoppelen";
            this.StudentLoskoppelen.Size = new System.Drawing.Size(264, 34);
            this.StudentLoskoppelen.TabIndex = 17;
            this.StudentLoskoppelen.Text = "Student-opo loskoppelen";
            this.StudentLoskoppelen.UseVisualStyleBackColor = true;
            this.StudentLoskoppelen.Click += new System.EventHandler(this.StudentLoskoppelen_Click);
            // 
            // listViewStudenten
            // 
            this.listViewStudenten.Location = new System.Drawing.Point(13, 465);
            this.listViewStudenten.Name = "listViewStudenten";
            this.listViewStudenten.Size = new System.Drawing.Size(521, 213);
            this.listViewStudenten.TabIndex = 18;
            this.listViewStudenten.UseCompatibleStateImageBehavior = false;
            // 
            // listViewDocenten
            // 
            this.listViewDocenten.Location = new System.Drawing.Point(13, 129);
            this.listViewDocenten.Name = "listViewDocenten";
            this.listViewDocenten.Size = new System.Drawing.Size(521, 186);
            this.listViewDocenten.TabIndex = 19;
            this.listViewDocenten.UseCompatibleStateImageBehavior = false;
            // 
            // Overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 690);
            this.Controls.Add(this.listViewDocenten);
            this.Controls.Add(this.listViewStudenten);
            this.Controls.Add(this.StudentLoskoppelen);
            this.Controls.Add(this.DocentLoskoppelen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.KoppelStudent);
            this.Controls.Add(this.KoppelDocenten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DocentToevegen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxStudenten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDocenten);
            this.Controls.Add(this.label1);
            this.Name = "Overzicht";
            this.Text = "Overzicht";
            this.Load += new System.EventHandler(this.Overzicht_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label1;
    private ComboBox comboBoxDocenten;
    private Label label2;
    private Label label3;
    private ComboBox comboBoxStudenten;
    private Label label4;
    private Button button1;
    private Button DocentToevegen;
    private Button button3;
    private Label label5;
    private Label label6;
    private Button KoppelDocenten;
    private Button KoppelStudent;
    private Label label7;
    private Button DocentLoskoppelen;
    private Button StudentLoskoppelen;
    private ListView listViewStudenten;
    private ListView listViewDocenten;
}
