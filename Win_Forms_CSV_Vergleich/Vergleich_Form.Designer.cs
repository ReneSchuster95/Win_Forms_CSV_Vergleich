namespace Win_Forms_CSV_Vergleich
{
    partial class Vergleich_Form
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
            dataGridView_Neu = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Bezeichnung = new DataGridViewTextBoxColumn();
            dataGridView_Geandert = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridView_Geloescht = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            label_Neu = new Label();
            label_aenderung = new Label();
            label1 = new Label();
            button_Download_neu = new Button();
            button_Download_Geaendert = new Button();
            button_Download_Geloescht = new Button();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Neu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Geandert).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Geloescht).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Neu
            // 
            dataGridView_Neu.AllowUserToAddRows = false;
            dataGridView_Neu.AllowUserToDeleteRows = false;
            dataGridView_Neu.AllowUserToResizeRows = false;
            dataGridView_Neu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Neu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Neu.Columns.AddRange(new DataGridViewColumn[] { ID, Bezeichnung });
            dataGridView_Neu.Location = new Point(12, 40);
            dataGridView_Neu.Name = "dataGridView_Neu";
            dataGridView_Neu.RowTemplate.Height = 25;
            dataGridView_Neu.Size = new Size(776, 150);
            dataGridView_Neu.TabIndex = 0;
            // 
            // ID
            // 
            ID.FillWeight = 10F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Resizable = DataGridViewTriState.False;
            ID.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Bezeichnung
            // 
            Bezeichnung.HeaderText = "Bezeichnung";
            Bezeichnung.Name = "Bezeichnung";
            Bezeichnung.ReadOnly = true;
            Bezeichnung.Resizable = DataGridViewTriState.False;
            Bezeichnung.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridView_Geandert
            // 
            dataGridView_Geandert.AllowUserToAddRows = false;
            dataGridView_Geandert.AllowUserToDeleteRows = false;
            dataGridView_Geandert.AllowUserToResizeRows = false;
            dataGridView_Geandert.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Geandert.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Geandert.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridView_Geandert.Location = new Point(12, 224);
            dataGridView_Geandert.Name = "dataGridView_Geandert";
            dataGridView_Geandert.RowTemplate.Height = 25;
            dataGridView_Geandert.Size = new Size(776, 150);
            dataGridView_Geandert.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 10F;
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Bezeichnung";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridView_Geloescht
            // 
            dataGridView_Geloescht.AllowUserToAddRows = false;
            dataGridView_Geloescht.AllowUserToDeleteRows = false;
            dataGridView_Geloescht.AllowUserToResizeRows = false;
            dataGridView_Geloescht.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Geloescht.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Geloescht.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView_Geloescht.Location = new Point(12, 408);
            dataGridView_Geloescht.Name = "dataGridView_Geloescht";
            dataGridView_Geloescht.RowTemplate.Height = 25;
            dataGridView_Geloescht.Size = new Size(776, 150);
            dataGridView_Geloescht.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.FillWeight = 10F;
            dataGridViewTextBoxColumn3.HeaderText = "ID";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Bezeichnung";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn4.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // label_Neu
            // 
            label_Neu.AutoSize = true;
            label_Neu.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label_Neu.Location = new Point(12, 9);
            label_Neu.Name = "label_Neu";
            label_Neu.Size = new Size(147, 28);
            label_Neu.TabIndex = 3;
            label_Neu.Text = "Neue Einträge";
            // 
            // label_aenderung
            // 
            label_aenderung.AutoSize = true;
            label_aenderung.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label_aenderung.Location = new Point(12, 193);
            label_aenderung.Name = "label_aenderung";
            label_aenderung.Size = new Size(128, 28);
            label_aenderung.TabIndex = 4;
            label_aenderung.Text = "Änderungen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 377);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 5;
            label1.Text = "Glöschte Einträge";
            // 
            // button_Download_neu
            // 
            button_Download_neu.Location = new Point(794, 40);
            button_Download_neu.Name = "button_Download_neu";
            button_Download_neu.Size = new Size(75, 150);
            button_Download_neu.TabIndex = 6;
            button_Download_neu.Text = "Speichern";
            button_Download_neu.UseVisualStyleBackColor = true;
            button_Download_neu.Click += button_Download_neu_Click;
            // 
            // button_Download_Geaendert
            // 
            button_Download_Geaendert.Location = new Point(794, 224);
            button_Download_Geaendert.Name = "button_Download_Geaendert";
            button_Download_Geaendert.Size = new Size(75, 150);
            button_Download_Geaendert.TabIndex = 7;
            button_Download_Geaendert.Text = "Speichern";
            button_Download_Geaendert.UseVisualStyleBackColor = true;
            button_Download_Geaendert.Click += button_Download_Geaendert_Click;
            // 
            // button_Download_Geloescht
            // 
            button_Download_Geloescht.Location = new Point(794, 408);
            button_Download_Geloescht.Name = "button_Download_Geloescht";
            button_Download_Geloescht.Size = new Size(75, 150);
            button_Download_Geloescht.TabIndex = 8;
            button_Download_Geloescht.Text = "Speichern";
            button_Download_Geloescht.UseVisualStyleBackColor = true;
            button_Download_Geloescht.Click += button_Download_Geloescht_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "CSV files (*.csv)|*.csv";
            // 
            // Vergleich_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 565);
            Controls.Add(button_Download_Geloescht);
            Controls.Add(button_Download_Geaendert);
            Controls.Add(button_Download_neu);
            Controls.Add(label1);
            Controls.Add(label_aenderung);
            Controls.Add(label_Neu);
            Controls.Add(dataGridView_Geloescht);
            Controls.Add(dataGridView_Geandert);
            Controls.Add(dataGridView_Neu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Vergleich_Form";
            Text = "Vergleich_Form";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Neu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Geandert).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Geloescht).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_Neu;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Bezeichnung;
        private DataGridView dataGridView_Geandert;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridView dataGridView_Geloescht;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Label label_Neu;
        private Label label_aenderung;
        private Label label1;
        private Button button_Download_neu;
        private Button button_Download_Geaendert;
        private Button button_Download_Geloescht;
        private SaveFileDialog saveFileDialog1;
    }
}