namespace MyFitnessPal
{
    partial class Kalkulator
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
            this.btn_izracunaj = new System.Windows.Forms.Button();
            this.txt_visina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tezina = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_starost = new System.Windows.Forms.ComboBox();
            this.txt_bmr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pol = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rad_1 = new System.Windows.Forms.RadioButton();
            this.rad_5 = new System.Windows.Forms.RadioButton();
            this.rad_4 = new System.Windows.Forms.RadioButton();
            this.rad_3 = new System.Windows.Forms.RadioButton();
            this.rad_2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tdee = new System.Windows.Forms.TextBox();
            this.btn_parametri = new System.Windows.Forms.Button();
            this.btn_osvezi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_izracunaj
            // 
            this.btn_izracunaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izracunaj.Location = new System.Drawing.Point(294, 262);
            this.btn_izracunaj.Name = "btn_izracunaj";
            this.btn_izracunaj.Size = new System.Drawing.Size(75, 23);
            this.btn_izracunaj.TabIndex = 0;
            this.btn_izracunaj.Text = "Izracunaj";
            this.btn_izracunaj.UseVisualStyleBackColor = true;
            this.btn_izracunaj.Click += new System.EventHandler(this.btn_izracunaj_Click);
            // 
            // txt_visina
            // 
            this.txt_visina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_visina.FormattingEnabled = true;
            this.txt_visina.Location = new System.Drawing.Point(110, 69);
            this.txt_visina.Name = "txt_visina";
            this.txt_visina.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_visina.Size = new System.Drawing.Size(90, 24);
            this.txt_visina.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Visina u cm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Težina u kg";
            // 
            // txt_tezina
            // 
            this.txt_tezina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tezina.FormattingEnabled = true;
            this.txt_tezina.Location = new System.Drawing.Point(110, 111);
            this.txt_tezina.Name = "txt_tezina";
            this.txt_tezina.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_tezina.Size = new System.Drawing.Size(90, 24);
            this.txt_tezina.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Starost u god.";
            // 
            // txt_starost
            // 
            this.txt_starost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_starost.FormattingEnabled = true;
            this.txt_starost.Location = new System.Drawing.Point(110, 156);
            this.txt_starost.Name = "txt_starost";
            this.txt_starost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_starost.Size = new System.Drawing.Size(90, 24);
            this.txt_starost.TabIndex = 7;
            // 
            // txt_bmr
            // 
            this.txt_bmr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bmr.Location = new System.Drawing.Point(110, 207);
            this.txt_bmr.Name = "txt_bmr";
            this.txt_bmr.ReadOnly = true;
            this.txt_bmr.Size = new System.Drawing.Size(90, 22);
            this.txt_bmr.TabIndex = 9;
            this.txt_bmr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "BMR";
            // 
            // txt_pol
            // 
            this.txt_pol.FormattingEnabled = true;
            this.txt_pol.Location = new System.Drawing.Point(110, 28);
            this.txt_pol.Name = "txt_pol";
            this.txt_pol.Size = new System.Drawing.Size(90, 21);
            this.txt_pol.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pol";
            // 
            // rad_1
            // 
            this.rad_1.AutoSize = true;
            this.rad_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_1.Location = new System.Drawing.Point(274, 50);
            this.rad_1.Name = "rad_1";
            this.rad_1.Size = new System.Drawing.Size(295, 20);
            this.rad_1.TabIndex = 13;
            this.rad_1.TabStop = true;
            this.rad_1.Text = "Sedeći (Malo ili bez aktivnosti, sedeći posao)";
            this.rad_1.UseVisualStyleBackColor = true;
            // 
            // rad_5
            // 
            this.rad_5.AutoSize = true;
            this.rad_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_5.Location = new System.Drawing.Point(274, 155);
            this.rad_5.Name = "rad_5";
            this.rad_5.Size = new System.Drawing.Size(412, 20);
            this.rad_5.TabIndex = 14;
            this.rad_5.TabStop = true;
            this.rad_5.Text = "Ekstreman (Teške dnevne vežbe/sport i fizički posao 2 x dnevno)";
            this.rad_5.UseVisualStyleBackColor = true;
            // 
            // rad_4
            // 
            this.rad_4.AutoSize = true;
            this.rad_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_4.Location = new System.Drawing.Point(274, 129);
            this.rad_4.Name = "rad_4";
            this.rad_4.Size = new System.Drawing.Size(315, 20);
            this.rad_4.TabIndex = 15;
            this.rad_4.TabStop = true;
            this.rad_4.Text = "Veoma Aktivan (Teže vežbe/sport 6-7 dana/ned)";
            this.rad_4.UseVisualStyleBackColor = true;
            // 
            // rad_3
            // 
            this.rad_3.AutoSize = true;
            this.rad_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_3.Location = new System.Drawing.Point(274, 102);
            this.rad_3.Name = "rad_3";
            this.rad_3.Size = new System.Drawing.Size(300, 20);
            this.rad_3.TabIndex = 16;
            this.rad_3.TabStop = true;
            this.rad_3.Text = "Umeren (Umerene vežbe/sport 3-5 dana/ned.)";
            this.rad_3.UseVisualStyleBackColor = true;
            // 
            // rad_2
            // 
            this.rad_2.AutoSize = true;
            this.rad_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_2.Location = new System.Drawing.Point(274, 76);
            this.rad_2.Name = "rad_2";
            this.rad_2.Size = new System.Drawing.Size(248, 20);
            this.rad_2.TabIndex = 17;
            this.rad_2.TabStop = true;
            this.rad_2.Text = "Lak (Lake vežbe/sport 1-3 dana/ned.)";
            this.rad_2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(271, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nivo aktivnosti:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(223, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "TDEE";
            // 
            // txt_tdee
            // 
            this.txt_tdee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tdee.Location = new System.Drawing.Point(274, 207);
            this.txt_tdee.Name = "txt_tdee";
            this.txt_tdee.ReadOnly = true;
            this.txt_tdee.Size = new System.Drawing.Size(100, 22);
            this.txt_tdee.TabIndex = 19;
            this.txt_tdee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_parametri
            // 
            this.btn_parametri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_parametri.Location = new System.Drawing.Point(611, 262);
            this.btn_parametri.Name = "btn_parametri";
            this.btn_parametri.Size = new System.Drawing.Size(75, 23);
            this.btn_parametri.TabIndex = 21;
            this.btn_parametri.Text = "Parametri";
            this.btn_parametri.UseVisualStyleBackColor = true;
            this.btn_parametri.Click += new System.EventHandler(this.btn_parametri_Click);
            // 
            // btn_osvezi
            // 
            this.btn_osvezi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_osvezi.Location = new System.Drawing.Point(12, 262);
            this.btn_osvezi.Name = "btn_osvezi";
            this.btn_osvezi.Size = new System.Drawing.Size(75, 23);
            this.btn_osvezi.TabIndex = 22;
            this.btn_osvezi.Text = "Osveži";
            this.btn_osvezi.UseVisualStyleBackColor = true;
            this.btn_osvezi.Click += new System.EventHandler(this.btn_osvezi_Click);
            // 
            // Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 297);
            this.Controls.Add(this.btn_osvezi);
            this.Controls.Add(this.btn_parametri);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_tdee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rad_2);
            this.Controls.Add(this.rad_3);
            this.Controls.Add(this.rad_4);
            this.Controls.Add(this.rad_5);
            this.Controls.Add(this.rad_1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_pol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_bmr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_starost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tezina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_visina);
            this.Controls.Add(this.btn_izracunaj);
            this.Name = "Kalkulator";
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Kalkulator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_izracunaj;
        private System.Windows.Forms.ComboBox txt_visina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txt_tezina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txt_starost;
        private System.Windows.Forms.TextBox txt_bmr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txt_pol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rad_1;
        private System.Windows.Forms.RadioButton rad_5;
        private System.Windows.Forms.RadioButton rad_4;
        private System.Windows.Forms.RadioButton rad_3;
        private System.Windows.Forms.RadioButton rad_2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tdee;
        private System.Windows.Forms.Button btn_parametri;
        private System.Windows.Forms.Button btn_osvezi;
    }
}