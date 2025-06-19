namespace Win_Forms_CSV_Vergleich
{
    partial class Form1
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
            textBox_CSV1 = new TextBox();
            label_CSV1 = new Label();
            button_CSV1_Browse = new Button();
            button_CSV2_Browse = new Button();
            label_CSV2 = new Label();
            textBox_CSV2 = new TextBox();
            button_Vergleich = new Button();
            openFileDialogFile = new OpenFileDialog();
            SuspendLayout();
            // 
            // textBox_CSV1
            // 
            textBox_CSV1.Location = new Point(93, 27);
            textBox_CSV1.Name = "textBox_CSV1";
            textBox_CSV1.Size = new Size(186, 23);
            textBox_CSV1.TabIndex = 0;
            // 
            // label_CSV1
            // 
            label_CSV1.AutoSize = true;
            label_CSV1.Location = new Point(12, 9);
            label_CSV1.Name = "label_CSV1";
            label_CSV1.Size = new Size(91, 15);
            label_CSV1.TabIndex = 1;
            label_CSV1.Text = "Datenbank CSV:";
            // 
            // button_CSV1_Browse
            // 
            button_CSV1_Browse.Location = new Point(12, 27);
            button_CSV1_Browse.Name = "button_CSV1_Browse";
            button_CSV1_Browse.Size = new Size(75, 23);
            button_CSV1_Browse.TabIndex = 2;
            button_CSV1_Browse.Text = "Browse";
            button_CSV1_Browse.UseVisualStyleBackColor = true;
            button_CSV1_Browse.Click += button_CSV1_Browse_Click;
            // 
            // button_CSV2_Browse
            // 
            button_CSV2_Browse.Location = new Point(12, 92);
            button_CSV2_Browse.Name = "button_CSV2_Browse";
            button_CSV2_Browse.Size = new Size(75, 23);
            button_CSV2_Browse.TabIndex = 5;
            button_CSV2_Browse.Text = "Browse";
            button_CSV2_Browse.UseVisualStyleBackColor = true;
            button_CSV2_Browse.Click += button_CSV2_Browse_Click;
            // 
            // label_CSV2
            // 
            label_CSV2.AutoSize = true;
            label_CSV2.Location = new Point(12, 74);
            label_CSV2.Name = "label_CSV2";
            label_CSV2.Size = new Size(74, 15);
            label_CSV2.TabIndex = 4;
            label_CSV2.Text = "Katalog CSV:";
            // 
            // textBox_CSV2
            // 
            textBox_CSV2.Location = new Point(93, 92);
            textBox_CSV2.Name = "textBox_CSV2";
            textBox_CSV2.Size = new Size(186, 23);
            textBox_CSV2.TabIndex = 3;
            // 
            // button_Vergleich
            // 
            button_Vergleich.Location = new Point(14, 132);
            button_Vergleich.Name = "button_Vergleich";
            button_Vergleich.Size = new Size(265, 23);
            button_Vergleich.TabIndex = 6;
            button_Vergleich.Text = "Vergleichen";
            button_Vergleich.UseVisualStyleBackColor = true;
            button_Vergleich.Click += button_Compare_Click;
            // 
            // openFileDialogFile
            // 
            openFileDialogFile.FileName = "openFileDialog";
            openFileDialogFile.Filter = "CSV files (*.csv)|*.csv";
            openFileDialogFile.Title = "Select a CSV file";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 170);
            Controls.Add(button_Vergleich);
            Controls.Add(button_CSV2_Browse);
            Controls.Add(label_CSV2);
            Controls.Add(textBox_CSV2);
            Controls.Add(button_CSV1_Browse);
            Controls.Add(label_CSV1);
            Controls.Add(textBox_CSV1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_CSV1;
        private Label label_CSV1;
        private Button button_CSV1_Browse;
        private Button button_CSV2_Browse;
        private Label label_CSV2;
        private TextBox textBox_CSV2;
        private Button button_Vergleich;
        private OpenFileDialog openFileDialogFile;
    }
}