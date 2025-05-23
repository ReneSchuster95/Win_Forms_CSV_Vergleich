using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Forms_CSV_Vergleich
{
    internal class Daten
    {
        private int id;
        private string bezeichnung;

        public Daten(int id, string bezeichnung)
        {
            this.id = id;
            this.bezeichnung = bezeichnung;
        }

        public int Id { get => id;}
        public string Bezeichnung { get => bezeichnung;}

        public override string ToString()
        {
            return id + ";" + bezeichnung;
        }
    }
}
