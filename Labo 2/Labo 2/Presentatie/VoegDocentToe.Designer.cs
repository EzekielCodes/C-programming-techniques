namespace Labo_2;

partial class VoegDocentToe
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
            this.textboxVnaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFnaam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSnummer = new System.Windows.Forms.TextBox();
            this.buttonVoegtoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voornaam";
            // 
            // textboxVnaam
            // 
            this.textboxVnaam.Location = new System.Drawing.Point(300, 34);
            this.textboxVnaam.Name = "textboxVnaam";
            this.textboxVnaam.Size = new System.Drawing.Size(343, 31);
            this.textboxVnaam.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Familienaam";
            // 
            // textBoxFnaam
            // 
            this.textBoxFnaam.Location = new System.Drawing.Point(300, 137);
            this.textBoxFnaam.Name = "textBoxFnaam";
            this.textBoxFnaam.Size = new System.Drawing.Size(343, 31);
            this.textBoxFnaam.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personeelsnummer";
            // 
            // textBoxSnummer
            // 
            this.textBoxSnummer.Location = new System.Drawing.Point(300, 235);
            this.textBoxSnummer.Name = "textBoxSnummer";
            this.textBoxSnummer.Size = new System.Drawing.Size(343, 31);
            this.textBoxSnummer.TabIndex = 5;
            // 
            // buttonVoegtoe
            // 
            this.buttonVoegtoe.Location = new System.Drawing.Point(526, 338);
            this.buttonVoegtoe.Name = "buttonVoegtoe";
            this.buttonVoegtoe.Size = new System.Drawing.Size(112, 34);
            this.buttonVoegtoe.TabIndex = 6;
            this.buttonVoegtoe.Text = "Voeg toe";
            this.buttonVoegtoe.UseVisualStyleBackColor = true;
            this.buttonVoegtoe.Click += new System.EventHandler(this.buttonVoeg);
            // 
            // VoegDocentToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVoegtoe);
            this.Controls.Add(this.textBoxSnummer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFnaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxVnaam);
            this.Controls.Add(this.label1);
            this.Name = "VoegDocentToe";
            this.Text = "VoegDocentToe";
            this.Load += new System.EventHandler(this.VoegDocentToe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label1;
    private TextBox textboxVnaam;
    private Label label2;
    private TextBox textBoxFnaam;
    private Label label3;
    private TextBox textBoxSnummer;
    private Button buttonVoegtoe;
}
