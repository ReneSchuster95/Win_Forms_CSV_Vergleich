namespace Win_Forms_CSV_Vergleich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Vergleich_Click(object sender, EventArgs e)
        {
            if (!File.Exists(textBox_CSV1.Text))
            {
                MessageBox.Show("Bitte CSV auswählen.\nDatei nicht gefunden.\n"+textBox_CSV1.Text);
                return;
            }
            if (!File.Exists(textBox_CSV2.Text))
            {
                MessageBox.Show("Bitte CSV auswählen.\nDatei nicht gefunden.\n"+textBox_CSV2.Text);
                return;
            }
            Vergleich_Form vergleich_Form = new Vergleich_Form(textBox_CSV1.Text,textBox_CSV2.Text);
            vergleich_Form.Show();
        }

        private void button_CSV1_Browse_Click(object sender, EventArgs e)
        {
            if (openFileDialogFile.ShowDialog() == DialogResult.OK)
            {
                textBox_CSV1.Text = openFileDialogFile.FileName;
            }
        }

        private void button_CSV2_Browse_Click(object sender, EventArgs e)
        {
            if (openFileDialogFile.ShowDialog(this) == DialogResult.OK)
            {
                textBox_CSV2.Text = openFileDialogFile.FileName;
            }
        }
    }
}