namespace Win_Forms_CSV_Vergleich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Called when the Compare button is clicked
        private void button_Compare_Click(object sender, EventArgs e)
        {
            // Check if the first CSV file exists
            if (!File.Exists(textBox_CSV1.Text))
            {
                MessageBox.Show("Bitte CSV auswählen.\nDatei nicht gefunden.\n" + textBox_CSV1.Text);
                return;
            }

            // Check if the second CSV file exists
            if (!File.Exists(textBox_CSV2.Text))
            {
                MessageBox.Show("Bitte CSV auswählen.\nDatei nicht gefunden.\n" + textBox_CSV2.Text);
                return;
            }

            // Open the Compare_Form to compare the two CSV files
            Compare_Form compare_Form = new Compare_Form(textBox_CSV1.Text, textBox_CSV2.Text);
            compare_Form.Show();
        }

        // Called when the "Browse" button for the first CSV file is clicked
        private void button_CSV1_Browse_Click(object sender, EventArgs e)
        {
            // Open file dialog and set the selected file path to the first text box
            if (openFileDialogFile.ShowDialog() == DialogResult.OK)
            {
                textBox_CSV1.Text = openFileDialogFile.FileName;
            }
        }

        // Called when the "Browse" button for the second CSV file is clicked
        private void button_CSV2_Browse_Click(object sender, EventArgs e)
        {
            // Open file dialog and set the selected file path to the second text box
            if (openFileDialogFile.ShowDialog(this) == DialogResult.OK)
            {
                textBox_CSV2.Text = openFileDialogFile.FileName;
            }
        }

    }
}