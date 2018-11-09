namespace MyFitnessPal
{
    partial class Namirnice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Namirnice));
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_namirnica = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.btn_import = new System.Windows.Forms.Button();
            this.txt_kategorija = new System.Windows.Forms.ComboBox();
            this.btn_empty = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_kolicina = new System.Windows.Forms.TextBox();
            this.txt_datum = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(481, 58);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_namirnica
            // 
            this.txt_namirnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_namirnica.Location = new System.Drawing.Point(12, 59);
            this.txt_namirnica.Name = "txt_namirnica";
            this.txt_namirnica.Size = new System.Drawing.Size(336, 22);
            this.txt_namirnica.TabIndex = 1;
            this.txt_namirnica.TextChanged += new System.EventHandler(this.txt_namirnica_TextChanged);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 102);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(964, 360);
            this.grid.TabIndex = 2;
            // 
            // btn_import
            // 
            this.btn_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_import.Location = new System.Drawing.Point(12, 12);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(75, 23);
            this.btn_import.TabIndex = 3;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // txt_kategorija
            // 
            this.txt_kategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kategorija.FormattingEnabled = true;
            this.txt_kategorija.Location = new System.Drawing.Point(354, 57);
            this.txt_kategorija.Name = "txt_kategorija";
            this.txt_kategorija.Size = new System.Drawing.Size(121, 24);
            this.txt_kategorija.TabIndex = 4;
            this.txt_kategorija.TextChanged += new System.EventHandler(this.txt_namirnica_TextChanged);
            // 
            // btn_empty
            // 
            this.btn_empty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empty.Location = new System.Drawing.Point(129, 12);
            this.btn_empty.Name = "btn_empty";
            this.btn_empty.Size = new System.Drawing.Size(75, 23);
            this.btn_empty.TabIndex = 5;
            this.btn_empty.Text = "Empty";
            this.btn_empty.UseVisualStyleBackColor = true;
            this.btn_empty.Click += new System.EventHandler(this.btn_empty_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(901, 46);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_kolicina
            // 
            this.txt_kolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kolicina.Location = new System.Drawing.Point(814, 60);
            this.txt_kolicina.Name = "txt_kolicina";
            this.txt_kolicina.Size = new System.Drawing.Size(81, 22);
            this.txt_kolicina.TabIndex = 7;
            this.txt_kolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_datum
            // 
            this.txt_datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_datum.Location = new System.Drawing.Point(814, 34);
            this.txt_datum.Mask = "00/00/0000";
            this.txt_datum.Name = "txt_datum";
            this.txt_datum.Size = new System.Drawing.Size(81, 22);
            this.txt_datum.TabIndex = 8;
            this.txt_datum.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(756, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(748, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Količina:";
            // 
            // Kalorije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 474);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_datum);
            this.Controls.Add(this.txt_kolicina);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_empty);
            this.Controls.Add(this.txt_kategorija);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.txt_namirnica);
            this.Controls.Add(this.btn_search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kalorije";
            this.Text = "Kalorije";
            this.Load += new System.EventHandler(this.Kalorije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_namirnica;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.ComboBox txt_kategorija;
        private System.Windows.Forms.Button btn_empty;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_kolicina;
        private System.Windows.Forms.MaskedTextBox txt_datum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}