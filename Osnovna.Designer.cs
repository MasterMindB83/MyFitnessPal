namespace MyFitnessPal
{
    partial class Osnovna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Osnovna));
            this.btn_tezina = new System.Windows.Forms.Button();
            this.btn_namirnice = new System.Windows.Forms.Button();
            this.btn_kalkulator_unetih_kalorija = new System.Windows.Forms.Button();
            this.btn_kalkulator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_tezina
            // 
            this.btn_tezina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tezina.Location = new System.Drawing.Point(12, 26);
            this.btn_tezina.Name = "btn_tezina";
            this.btn_tezina.Size = new System.Drawing.Size(135, 23);
            this.btn_tezina.TabIndex = 0;
            this.btn_tezina.Text = "Težina";
            this.btn_tezina.UseVisualStyleBackColor = true;
            this.btn_tezina.Click += new System.EventHandler(this.btn_tezina_Click);
            // 
            // btn_namirnice
            // 
            this.btn_namirnice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_namirnice.Location = new System.Drawing.Point(177, 26);
            this.btn_namirnice.Name = "btn_namirnice";
            this.btn_namirnice.Size = new System.Drawing.Size(135, 23);
            this.btn_namirnice.TabIndex = 1;
            this.btn_namirnice.Text = "Namirnice";
            this.btn_namirnice.UseVisualStyleBackColor = true;
            this.btn_namirnice.Click += new System.EventHandler(this.btn_namirnice_Click);
            // 
            // btn_kalkulator_unetih_kalorija
            // 
            this.btn_kalkulator_unetih_kalorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kalkulator_unetih_kalorija.Location = new System.Drawing.Point(12, 70);
            this.btn_kalkulator_unetih_kalorija.Name = "btn_kalkulator_unetih_kalorija";
            this.btn_kalkulator_unetih_kalorija.Size = new System.Drawing.Size(135, 23);
            this.btn_kalkulator_unetih_kalorija.TabIndex = 2;
            this.btn_kalkulator_unetih_kalorija.Text = "Unete kalorije";
            this.btn_kalkulator_unetih_kalorija.UseVisualStyleBackColor = true;
            this.btn_kalkulator_unetih_kalorija.Click += new System.EventHandler(this.btn_kalkulator_unetih_kalorija_Click);
            // 
            // btn_kalkulator
            // 
            this.btn_kalkulator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kalkulator.Location = new System.Drawing.Point(177, 70);
            this.btn_kalkulator.Name = "btn_kalkulator";
            this.btn_kalkulator.Size = new System.Drawing.Size(135, 23);
            this.btn_kalkulator.TabIndex = 3;
            this.btn_kalkulator.Text = "Kalkulator kalorija";
            this.btn_kalkulator.UseVisualStyleBackColor = true;
            this.btn_kalkulator.Click += new System.EventHandler(this.btn_kalkulator_Click);
            // 
            // Osnovna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 119);
            this.Controls.Add(this.btn_kalkulator);
            this.Controls.Add(this.btn_kalkulator_unetih_kalorija);
            this.Controls.Add(this.btn_namirnice);
            this.Controls.Add(this.btn_tezina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Osnovna";
            this.Text = "My Fitness Pal";
            this.Load += new System.EventHandler(this.Osnovna_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_tezina;
        private System.Windows.Forms.Button btn_namirnice;
        private System.Windows.Forms.Button btn_kalkulator_unetih_kalorija;
        private System.Windows.Forms.Button btn_kalkulator;
    }
}