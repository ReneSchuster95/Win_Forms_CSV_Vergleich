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
    public partial class Vergleich_Form : Form
    {
        private string pfad1;
        private string pfad2;
        private List<Daten> CSV_Alt = new List<Daten>();
        private List<Daten> CSV_Neu = new List<Daten>();

        private List<Daten> CSV_Daten_Neu = new List<Daten>();
        private List<Daten> CSV_Daten_Geaendert = new List<Daten>();
        private List<Daten> CSV_Daten_Geloescht = new List<Daten>();

        public Vergleich_Form(string Pfad1, string Pfad2)
        {
            InitializeComponent();
            pfad1 = Pfad1;
            pfad2 = Pfad2;
            datenLesen(pfad1, CSV_Alt);
            datenLesen(pfad2, CSV_Neu);
            datenVerarbeiten();
            datenAnzeigen(dataGridView_Neu, CSV_Daten_Neu);
            datenAnzeigen(dataGridView_Geandert, CSV_Daten_Geaendert);
            datenAnzeigen(dataGridView_Geloescht, CSV_Daten_Geloescht);

        }

        private void datenAnzeigen(DataGridView dgv, List<Daten> dl)
        {
            foreach (Daten d in dl)
            {
                dgv.Rows.Add(d.Id, d.Bezeichnung);
            }
        }
        private void datenVerarbeiten()
        {
            foreach (Daten da in CSV_Alt)
            {
                bool found = false;
                foreach (Daten dn in CSV_Neu)
                {
                    if (da.Id == dn.Id)
                    {
                        if (da.Bezeichnung != dn.Bezeichnung)
                        {
                            CSV_Daten_Geaendert.Add(dn);
                        }
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    CSV_Daten_Geloescht.Add(da);
                }
            }

            foreach (Daten dn in CSV_Neu)
            {
                bool found = false;
                foreach (Daten da in CSV_Alt)
                {
                    if (dn.Id == da.Id)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    CSV_Daten_Neu.Add(dn);
                }
            }
        }
        private void datenLesen(string pfad, List<Daten> output)
        {
            try
            {
                using (StreamReader sr = new StreamReader(pfad))
                {
                    while (!sr.EndOfStream)
                    {
                        string s = sr.ReadLine();
                        string[] sa = s.Split(';');
                        if (sa.Length >= 2)
                        {
                            if (int.TryParse(sa[0].Trim(), out int id))
                            {
                                output.Add(new Daten(id, sa[1]));
                            }
                        }
                    }
                    sr.Close();
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void saveDialog(string filename,List<Daten> daten) 
        {
            saveFileDialog1.FileName = filename;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName,false)) 
                    {
                        foreach(Daten d in daten)
                        {
                            sw.WriteLine(d.ToString());
                        }
                    }
                }
                catch(IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button_Download_neu_Click(object sender, EventArgs e)
        {
            saveDialog("Neu", CSV_Daten_Neu);
        }

        private void button_Download_Geaendert_Click(object sender, EventArgs e)
        {
            saveDialog("Geaendert", CSV_Daten_Geaendert);
        }

        private void button_Download_Geloescht_Click(object sender, EventArgs e)
        {
            saveDialog("Geloescht", CSV_Daten_Geloescht);
        }
    }
}
