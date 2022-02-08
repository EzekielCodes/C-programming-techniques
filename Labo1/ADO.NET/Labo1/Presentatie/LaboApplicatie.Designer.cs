namespace Labo1;

partial class LaboApplicatie
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
            this.label2 = new System.Windows.Forms.Label();
            this.docentenComboBox = new System.Windows.Forms.ComboBox();
            this.studentenComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.docentenTextBox = new System.Windows.Forms.TextBox();
            this.studentenTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Docenten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(907, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Studenten";
            // 
            // docentenComboBox
            // 
            this.docentenComboBox.FormattingEnabled = true;
            this.docentenComboBox.Location = new System.Drawing.Point(45, 51);
            this.docentenComboBox.Name = "docentenComboBox";
            this.docentenComboBox.Size = new System.Drawing.Size(419, 33);
            this.docentenComboBox.TabIndex = 2;
            this.docentenComboBox.SelectedIndexChanged += new System.EventHandler(this.DocentenSelected);
            // 
            // studentenComboBox
            // 
            this.studentenComboBox.FormattingEnabled = true;
            this.studentenComboBox.Location = new System.Drawing.Point(759, 51);
            this.studentenComboBox.Name = "studentenComboBox";
            this.studentenComboBox.Size = new System.Drawing.Size(424, 33);
            this.studentenComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vakken";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(713, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vakken";
            // 
            // docentenTextBox
            // 
            this.docentenTextBox.Location = new System.Drawing.Point(45, 162);
            this.docentenTextBox.Multiline = true;
            this.docentenTextBox.Name = "docentenTextBox";
            this.docentenTextBox.Size = new System.Drawing.Size(562, 224);
            this.docentenTextBox.TabIndex = 6;
            // 
            // studentenTextBox
            // 
            this.studentenTextBox.Location = new System.Drawing.Point(713, 162);
            this.studentenTextBox.Multiline = true;
            this.studentenTextBox.Name = "studentenTextBox";
            this.studentenTextBox.Size = new System.Drawing.Size(568, 224);
            this.studentenTextBox.TabIndex = 7;
            // 
            // LaboApplicatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 498);
            this.Controls.Add(this.studentenTextBox);
            this.Controls.Add(this.docentenTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studentenComboBox);
            this.Controls.Add(this.docentenComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LaboApplicatie";
            this.Text = "LaboApplicatie";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label1;
    private Label label2;
    private ComboBox docentenComboBox;
    private ComboBox studentenComboBox;
    private Label label3;
    private Label label4;
    private TextBox docentenTextBox;
    private TextBox studentenTextBox;
}
