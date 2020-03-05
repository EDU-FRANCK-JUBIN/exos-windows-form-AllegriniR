using System.Drawing;
using System.Windows.Forms;

namespace Calculatrice
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Resultat = new System.Windows.Forms.TextBox();
            this.Calcul = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Resultat
            // 
            this.Resultat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Resultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultat.Location = new System.Drawing.Point(18, 51);
            this.Resultat.Name = "Resultat";
            this.Resultat.Size = new System.Drawing.Size(373, 38);
            this.Resultat.TabIndex = 0;
            this.Resultat.Text = "0";
            this.Resultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Resultat.TextChanged += new System.EventHandler(this.Resultat_TextChanged);
            // 
            // Calcul
            // 
            this.Calcul.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Calcul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcul.ForeColor = System.Drawing.Color.DarkGray;
            this.Calcul.Location = new System.Drawing.Point(18, 24);
            this.Calcul.Name = "Calcul";
            this.Calcul.Size = new System.Drawing.Size(373, 27);
            this.Calcul.TabIndex = 1;
            this.Calcul.Text = "0";
            this.Calcul.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Calcul.TextChanged += new System.EventHandler(this.Calcul_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button20);
            this.groupBox1.Controls.Add(this.button19);
            this.groupBox1.Controls.Add(this.button18);
            this.groupBox1.Controls.Add(this.button17);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(18, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 373);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(280, 297);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(84, 63);
            this.button20.TabIndex = 19;
            this.button20.Text = "=";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(190, 297);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(84, 63);
            this.button19.TabIndex = 18;
            this.button19.Text = ",";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(100, 297);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(84, 63);
            this.button18.TabIndex = 17;
            this.button18.Text = "0";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(10, 297);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(84, 63);
            this.button17.TabIndex = 16;
            this.button17.Text = "+-";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(280, 228);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(84, 63);
            this.button16.TabIndex = 15;
            this.button16.Text = "+";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(190, 228);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(84, 63);
            this.button15.TabIndex = 14;
            this.button15.Text = "3";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(100, 228);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(84, 63);
            this.button14.TabIndex = 13;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(10, 228);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(84, 63);
            this.button13.TabIndex = 12;
            this.button13.Text = "1";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(280, 159);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(84, 63);
            this.button12.TabIndex = 11;
            this.button12.Text = "-";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(188, 159);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(86, 63);
            this.button11.TabIndex = 10;
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(100, 159);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(84, 63);
            this.button10.TabIndex = 9;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(10, 159);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 63);
            this.button9.TabIndex = 8;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(280, 90);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 63);
            this.button8.TabIndex = 7;
            this.button8.Text = "*";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(190, 90);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 63);
            this.button7.TabIndex = 6;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(100, 90);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 63);
            this.button6.TabIndex = 5;
            this.button6.Text = "8";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(10, 90);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 63);
            this.button5.TabIndex = 4;
            this.button5.Text = "7";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(280, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 63);
            this.button4.TabIndex = 3;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(188, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 63);
            this.button3.TabIndex = 2;
            this.button3.Text = "<--";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "C";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "CE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 480);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Calcul);
            this.Controls.Add(this.Resultat);
            this.Name = "Form1";
            this.Text = "Calculatrive";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Resultat;
        private TextBox Calcul;
        private GroupBox groupBox1;
        private Button button20;
        private Button button19;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

