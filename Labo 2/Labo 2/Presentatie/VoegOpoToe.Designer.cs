namespace Labo_2;

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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.Voegtoe = new System.Windows.Forms.Button();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxNaam = new System.Windows.Forms.TextBox();
            this.textBoxStp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opo code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aantal studiepunten";
            // 
            // comboBoxfase
            // 
            this.comboBoxfase.FormattingEnabled = true;
            this.comboBoxfase.Location = new System.Drawing.Point(357, 270);
            this.comboBoxfase.Name = "comboBoxfase";
            this.comboBoxfase.Size = new System.Drawing.Size(273, 33);
            this.comboBoxfase.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fase";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Semester";
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Location = new System.Drawing.Point(357, 348);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(273, 33);
            this.comboBoxSemester.TabIndex = 6;
            // 
            // Voegtoe
            // 
            this.Voegtoe.Location = new System.Drawing.Point(643, 404);
            this.Voegtoe.Name = "Voegtoe";
            this.Voegtoe.Size = new System.Drawing.Size(145, 34);
            this.Voegtoe.TabIndex = 7;
            this.Voegtoe.Text = "Voeg opo toe";
            this.Voegtoe.UseVisualStyleBackColor = true;
            this.Voegtoe.Click += new System.EventHandler(this.Voegtoe_Click);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(357, 38);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(273, 31);
            this.textBoxCode.TabIndex = 8;
            // 
            // textBoxNaam
            // 
            this.textBoxNaam.Location = new System.Drawing.Point(357, 113);
            this.textBoxNaam.Name = "textBoxNaam";
            this.textBoxNaam.Size = new System.Drawing.Size(273, 31);
            this.textBoxNaam.TabIndex = 9;
            // 
            // textBoxStp
            // 
            this.textBoxStp.Location = new System.Drawing.Point(357, 187);
            this.textBoxStp.Name = "textBoxStp";
            this.textBoxStp.Size = new System.Drawing.Size(273, 31);
            this.textBoxStp.TabIndex = 10;
            // 
            // VoegOpoToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxStp);
            this.Controls.Add(this.textBoxNaam);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.Voegtoe);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxfase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VoegOpoToe";
            this.Text = "VoegOpoToe";
            this.Load += new System.EventHandler(this.VoegOpoToe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private ComboBox comboBoxfase;
    private Label label4;
    private Label label5;
    private ComboBox comboBoxSemester;
    private Button Voegtoe;
    private TextBox textBoxCode;
    private TextBox textBoxNaam;
    private TextBox textBoxStp;
}
