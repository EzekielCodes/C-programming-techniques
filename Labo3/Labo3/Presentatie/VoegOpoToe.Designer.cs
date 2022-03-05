namespace Labo3.Presentatie;

partial class VoegOpoToe
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxfase = new System.Windows.Forms.ComboBox();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxNaam = new System.Windows.Forms.TextBox();
            this.textBoxStp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opo-Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opo-naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Studiepunten";
            // 
            // comboBoxfase
            // 
            this.comboBoxfase.FormattingEnabled = true;
            this.comboBoxfase.Location = new System.Drawing.Point(239, 291);
            this.comboBoxfase.Name = "comboBoxfase";
            this.comboBoxfase.Size = new System.Drawing.Size(332, 33);
            this.comboBoxfase.TabIndex = 3;
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Location = new System.Drawing.Point(239, 413);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(332, 33);
            this.comboBoxSemester.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fase";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Semester";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Voeg toe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(239, 23);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(443, 31);
            this.textBoxCode.TabIndex = 8;
            // 
            // textBoxNaam
            // 
            this.textBoxNaam.Location = new System.Drawing.Point(239, 103);
            this.textBoxNaam.Name = "textBoxNaam";
            this.textBoxNaam.Size = new System.Drawing.Size(443, 31);
            this.textBoxNaam.TabIndex = 9;
            // 
            // textBoxStp
            // 
            this.textBoxStp.Location = new System.Drawing.Point(239, 196);
            this.textBoxStp.Name = "textBoxStp";
            this.textBoxStp.Size = new System.Drawing.Size(443, 31);
            this.textBoxStp.TabIndex = 10;
            // 
            // VoegOpoToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 533);
            this.Controls.Add(this.textBoxStp);
            this.Controls.Add(this.textBoxNaam);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.comboBoxfase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VoegOpoToe";
            this.Text = "VoegOpoToe";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private ComboBox comboBoxfase;
    private ComboBox comboBoxSemester;
    private Label label4;
    private Label label5;
    private Button button1;
    private TextBox textBoxCode;
    private TextBox textBoxNaam;
    private TextBox textBoxStp;
}
