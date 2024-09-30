namespace Rendeles_Forms_lymyr6
{
    partial class UgyfelForm
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
            components = new System.ComponentModel.Container();
            dataGridViewUgyfelek = new DataGridView();
            ugyfelIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonszamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lakcimIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ugyfelBindingSource = new BindingSource(components);
            btnHozzaadas = new Button();
            btnTorles = new Button();
            btnMentes = new Button();
            btnFrissites = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUgyfelek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUgyfelek
            // 
            dataGridViewUgyfelek.AutoGenerateColumns = false;
            dataGridViewUgyfelek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUgyfelek.Columns.AddRange(new DataGridViewColumn[] { ugyfelIdDataGridViewTextBoxColumn, nevDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, telefonszamDataGridViewTextBoxColumn, lakcimIdDataGridViewTextBoxColumn });
            dataGridViewUgyfelek.DataSource = ugyfelBindingSource;
            dataGridViewUgyfelek.Location = new Point(19, 23);
            dataGridViewUgyfelek.Name = "dataGridViewUgyfelek";
            dataGridViewUgyfelek.Size = new Size(757, 358);
            dataGridViewUgyfelek.TabIndex = 0;
            // 
            // ugyfelIdDataGridViewTextBoxColumn
            // 
            ugyfelIdDataGridViewTextBoxColumn.DataPropertyName = "UgyfelId";
            ugyfelIdDataGridViewTextBoxColumn.HeaderText = "UgyfelId";
            ugyfelIdDataGridViewTextBoxColumn.Name = "ugyfelIdDataGridViewTextBoxColumn";
            // 
            // nevDataGridViewTextBoxColumn
            // 
            nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefonszamDataGridViewTextBoxColumn
            // 
            telefonszamDataGridViewTextBoxColumn.DataPropertyName = "Telefonszam";
            telefonszamDataGridViewTextBoxColumn.HeaderText = "Telefonszam";
            telefonszamDataGridViewTextBoxColumn.Name = "telefonszamDataGridViewTextBoxColumn";
            // 
            // lakcimIdDataGridViewTextBoxColumn
            // 
            lakcimIdDataGridViewTextBoxColumn.DataPropertyName = "LakcimId";
            lakcimIdDataGridViewTextBoxColumn.HeaderText = "LakcimId";
            lakcimIdDataGridViewTextBoxColumn.Name = "lakcimIdDataGridViewTextBoxColumn";
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // btnHozzaadas
            // 
            btnHozzaadas.Location = new Point(65, 412);
            btnHozzaadas.Name = "btnHozzaadas";
            btnHozzaadas.Size = new Size(75, 23);
            btnHozzaadas.TabIndex = 1;
            btnHozzaadas.Text = "Új";
            btnHozzaadas.UseVisualStyleBackColor = true;
            btnHozzaadas.Click += btnHozzaadas_Click;
            // 
            // btnTorles
            // 
            btnTorles.Location = new Point(146, 412);
            btnTorles.Name = "btnTorles";
            btnTorles.Size = new Size(75, 23);
            btnTorles.TabIndex = 2;
            btnTorles.Text = "Törlés";
            btnTorles.UseVisualStyleBackColor = true;
            btnTorles.Click += btnTorles_Click;
            // 
            // btnMentes
            // 
            btnMentes.Location = new Point(227, 412);
            btnMentes.Name = "btnMentes";
            btnMentes.Size = new Size(75, 23);
            btnMentes.TabIndex = 3;
            btnMentes.Text = "Mentés";
            btnMentes.UseVisualStyleBackColor = true;
            btnMentes.Click += btnMentes_Click;
            // 
            // btnFrissites
            // 
            btnFrissites.Location = new Point(308, 412);
            btnFrissites.Name = "btnFrissites";
            btnFrissites.Size = new Size(75, 23);
            btnFrissites.TabIndex = 4;
            btnFrissites.Text = "Frissités";
            btnFrissites.UseVisualStyleBackColor = true;
            btnFrissites.Click += btnFrissites_Click;
            // 
            // UgyfelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFrissites);
            Controls.Add(btnMentes);
            Controls.Add(btnTorles);
            Controls.Add(btnHozzaadas);
            Controls.Add(dataGridViewUgyfelek);
            Name = "UgyfelForm";
            Text = "UgyfelForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUgyfelek).EndInit();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewUgyfelek;
        private Button btnHozzaadas;
        private Button btnTorles;
        private Button btnMentes;
        private Button btnFrissites;
        private DataGridViewTextBoxColumn ugyfelIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonszamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lakcimIdDataGridViewTextBoxColumn;
        private BindingSource ugyfelBindingSource;
    }
}