namespace Labo3;

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
            this.listViewDocenten = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStudenten = new System.Windows.Forms.ComboBox();
            this.listViewStudenten = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Docent";
            // 
            // comboBoxDocenten
            // 
            this.comboBoxDocenten.FormattingEnabled = true;
            this.comboBoxDocenten.Location = new System.Drawing.Point(37, 53);
            this.comboBoxDocenten.Name = "comboBoxDocenten";
            this.comboBoxDocenten.Size = new System.Drawing.Size(730, 33);
            this.comboBoxDocenten.TabIndex = 1;
            this.comboBoxDocenten.SelectedIndexChanged += new System.EventHandler(this.SelectedDocenten);
            // 
            // listViewDocenten
            // 
            this.listViewDocenten.Location = new System.Drawing.Point(37, 141);
            this.listViewDocenten.Name = "listViewDocenten";
            this.listViewDocenten.Size = new System.Drawing.Size(730, 244);
            this.listViewDocenten.TabIndex = 2;
            this.listViewDocenten.UseCompatibleStateImageBehavior = false;
            this.listViewDocenten.SelectedIndexChanged += new System.EventHandler(this.listViewDocenten_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student";
            // 
            // comboBoxStudenten
            // 
            this.comboBoxStudenten.FormattingEnabled = true;
            this.comboBoxStudenten.Location = new System.Drawing.Point(37, 460);
            this.comboBoxStudenten.Name = "comboBoxStudenten";
            this.comboBoxStudenten.Size = new System.Drawing.Size(730, 33);
            this.comboBoxStudenten.TabIndex = 4;
            this.comboBoxStudenten.SelectedIndexChanged += new System.EventHandler(this.StudentSelected);
            // 
            // listViewStudenten
            // 
            this.listViewStudenten.Location = new System.Drawing.Point(37, 564);
            this.listViewStudenten.Name = "listViewStudenten";
            this.listViewStudenten.Size = new System.Drawing.Size(730, 270);
            this.listViewStudenten.TabIndex = 5;
            this.listViewStudenten.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Opo\'s gegeven door docent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 521);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Opo\'s gevolgd door student";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(845, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Toevoegen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(862, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Koppelen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(852, 591);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "LosKoppelen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(944, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Opo toevoegen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Opotoevoegen);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(944, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(283, 48);
            this.button2.TabIndex = 12;
            this.button2.Text = "Docent toevoegen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Docenttoevoegen);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(944, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(283, 34);
            this.button3.TabIndex = 13;
            this.button3.Text = "Student toevoegen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Studenttoevoegen);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(944, 411);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(283, 34);
            this.button4.TabIndex = 14;
            this.button4.Text = "Docent aan opo koppelen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.DocentKoppelen);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(944, 512);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(283, 34);
            this.button5.TabIndex = 15;
            this.button5.Text = "Student aan opo koppelen";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.StudentKoppelen);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(944, 657);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(283, 34);
            this.button6.TabIndex = 16;
            this.button6.Text = "Docent-opo loskoppelen";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.DocentLoskoppelen);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(944, 760);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(283, 34);
            this.button7.TabIndex = 17;
            this.button7.Text = "Student-opo loskoppelen";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.StudentLoskoppelen);
            // 
            // Overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 855);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewStudenten);
            this.Controls.Add(this.comboBoxStudenten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewDocenten);
            this.Controls.Add(this.comboBoxDocenten);
            this.Controls.Add(this.label1);
            this.Name = "Overzicht";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label1;
    private ComboBox comboBoxDocenten;
    private ListView listViewDocenten;
    private Label label2;
    private ComboBox comboBoxStudenten;
    private ListView listViewStudenten;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button7;
}
