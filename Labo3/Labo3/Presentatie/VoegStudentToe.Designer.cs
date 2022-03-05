namespace Labo3.Presentatie;

partial class VoegStudentToe
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
            this.textBoxVnaam = new System.Windows.Forms.TextBox();
            this.textBoxFnaam = new System.Windows.Forms.TextBox();
            this.textBoxSnr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voornaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Familienaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Studentennummer";
            // 
            // textBoxVnaam
            // 
            this.textBoxVnaam.Location = new System.Drawing.Point(214, 50);
            this.textBoxVnaam.Name = "textBoxVnaam";
            this.textBoxVnaam.Size = new System.Drawing.Size(483, 31);
            this.textBoxVnaam.TabIndex = 3;
            // 
            // textBoxFnaam
            // 
            this.textBoxFnaam.Location = new System.Drawing.Point(214, 155);
            this.textBoxFnaam.Name = "textBoxFnaam";
            this.textBoxFnaam.Size = new System.Drawing.Size(488, 31);
            this.textBoxFnaam.TabIndex = 4;
            // 
            // textBoxSnr
            // 
            this.textBoxSnr.Location = new System.Drawing.Point(214, 267);
            this.textBoxSnr.Name = "textBoxSnr";
            this.textBoxSnr.Size = new System.Drawing.Size(488, 31);
            this.textBoxSnr.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Voeg toe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Voegtoe);
            // 
            // VoegStudentToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSnr);
            this.Controls.Add(this.textBoxFnaam);
            this.Controls.Add(this.textBoxVnaam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VoegStudentToe";
            this.Text = "VoegStudentToe";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox textBoxVnaam;
    private TextBox textBoxFnaam;
    private TextBox textBoxSnr;
    private Button button1;
}
