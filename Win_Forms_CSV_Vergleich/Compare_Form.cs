using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.IO;

namespace Win_Forms_CSV_Vergleich
{
    public partial class Compare_Form : Form
    {
        private string path1;
        private string path2;
        private List<Daten> CSV_Database = new List<Daten>();
        private List<Daten> CSV_Katalog = new List<Daten>();

        private List<Daten> CSV_Daten_New = new List<Daten>();
        private List<Daten> CSV_DatenChange = new List<Daten>();

        public Compare_Form(string Pfad1, string Pfad2)
        {
            InitializeComponent();
            path1 = Pfad1;
            path2 = Pfad2;
            datenLesen(path1, CSV_Database);
            datenLesen(path2, CSV_Katalog);
            datenProcess();
            showData(dataGridView_Neu, CSV_Daten_New);
            showData(dataGridView_Geandert, CSV_DatenChange);
        }

        // Displays the list of data in a DataGridView
        private void showData(DataGridView dgv, List<Daten> dl)
        {
            foreach (Daten d in dl)
            {
                dgv.Rows.Add(d.Id, d.Description); // Add each data item to the DataGridView
            }
        }

        // Compares new CSV data with old CSV data to detect changes or new entries
        private void datenProcess()
        {
            foreach (Daten da in CSV_Katalog) // For each item in the new CSV
            {
                bool found = false;
                foreach (Daten dn in CSV_Database) // Compare with each item in the old CSV
                {
                    if (da.Id == dn.Id) // Match by ID
                    {
                        if (da.Description != dn.Description) // Check if description has changed
                        {
                            CSV_DatenChange.Add(da); // Add to changed data list
                        }
                        found = true;
                        break; // Stop checking once matched
                    }
                }
                if (!found)
                {
                    CSV_Daten_New.Add(da); // Add to new data list if no match found
                }
            }
        }

        // Reads a CSV file and fills a list with parsed data
        private void datenLesen(string pfad, List<Daten> output)
        {
            try
            {
                using (StreamReader sr = new StreamReader(pfad))
                {
                    while (!sr.EndOfStream)
                    {
                        string s = sr.ReadLine(); // Read a line
                        string[] sa = s.Split(';'); // Split by semicolon
                        if (sa.Length >= 2)
                        {
                            if (int.TryParse(sa[0].Trim(), out int id)) // Parse ID
                            {
                                output.Add(new Daten(id, sa[1])); // Add new Daten object to the list
                            }
                        }
                    }
                    sr.Close(); // Close file
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message); // Show error message if file cannot be read
                this.Close(); // Close the form
            }
        }

        // Opens a save dialog and writes a list of data to a file
        private void saveDialog(string filename, List<Daten> daten)
        {
            saveFileDialog1.FileName = filename;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false))
                    {
                        foreach (Daten d in daten)
                        {
                            sw.WriteLine(d.ToString()); // Write each data item as a line
                        }
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message); // Show error message if writing fails
                }
            }
        }

        // Button click: Save new data to file
        private void button_Download_neu_Click(object sender, EventArgs e)
        {
            saveDialog("Neu", CSV_Daten_New);
        }

        // Button click: Save changed data to file
        private void button_Download_Geaendert_Click(object sender, EventArgs e)
        {
            saveDialog("Geaendert", CSV_DatenChange);
        }


    }
}
