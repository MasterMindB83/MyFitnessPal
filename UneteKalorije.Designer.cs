namespace MyFitnessPal
{
    partial class UneteKalorije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UneteKalorije));
            this.grid = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_uh = new System.Windows.Forms.TextBox();
            this.txt_proteini = new System.Windows.Forms.TextBox();
            this.txt_masti = new System.Windows.Forms.TextBox();
            this.txt_kalorije_ukupno = new System.Windows.Forms.TextBox();
            this.txt_datum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kolicina = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 52);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(965, 274);
            this.grid.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(12, 374);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(902, 374);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_uh
            // 
            this.txt_uh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uh.Location = new System.Drawing.Point(354, 332);
            this.txt_uh.Name = "txt_uh";
            this.txt_uh.Size = new System.Drawing.Size(100, 22);
            this.txt_uh.TabIndex = 3;
            this.txt_uh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_proteini
            // 
            this.txt_proteini.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_proteini.Location = new System.Drawing.Point(460, 332);
            this.txt_proteini.Name = "txt_proteini";
            this.txt_proteini.Size = new System.Drawing.Size(100, 22);
            this.txt_proteini.TabIndex = 4;
            this.txt_proteini.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_masti
            // 
            this.txt_masti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_masti.Location = new System.Drawing.Point(566, 332);
            this.txt_masti.Name = "txt_masti";
            this.txt_masti.Size = new System.Drawing.Size(100, 22);
            this.txt_masti.TabIndex = 5;
            this.txt_masti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_kalorije_ukupno
            // 
            this.txt_kalorije_ukupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kalorije_ukupno.Location = new System.Drawing.Point(877, 332);
            this.txt_kalorije_ukupno.Name = "txt_kalorije_ukupno";
            this.txt_kalorije_ukupno.Size = new System.Drawing.Size(100, 22);
            this.txt_kalorije_ukupno.TabIndex = 6;
            this.txt_kalorije_ukupno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_datum
            // 
            this.txt_datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_datum.FormattingEnabled = true;
            this.txt_datum.Location = new System.Drawing.Point(432, 12);
            this.txt_datum.Name = "txt_datum";
            this.txt_datum.Size = new System.Drawing.Size(121, 24);
            this.txt_datum.TabIndex = 7;
            this.txt_datum.TextChanged += new System.EventHandler(this.txt_datum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Na dan:";
            // 
            // txt_kolicina
            // 
            this.txt_kolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kolicina.Location = new System.Drawing.Point(773, 332);
            this.txt_kolicina.Name = "txt_kolicina";
            this.txt_kolicina.Size = new System.Drawing.Size(100, 22);
            this.txt_kolicina.TabIndex = 9;
            this.txt_kolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(773, 374);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(379, 374);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 11;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // UneteKalorije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 409);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_kolicina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_datum);
            this.Controls.Add(this.txt_kalorije_ukupno);
            this.Controls.Add(this.txt_masti);
            this.Controls.Add(this.txt_proteini);
            this.Controls.Add(this.txt_uh);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UneteKalorije";
            this.Text = "Unete kalorije";
            this.Load += new System.EventHandler(this.Calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_uh;
        private System.Windows.Forms.TextBox txt_proteini;
        private System.Windows.Forms.TextBox txt_masti;
        private System.Windows.Forms.TextBox txt_kalorije_ukupno;
        private System.Windows.Forms.ComboBox txt_datum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kolicina;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_refresh;
    }
}