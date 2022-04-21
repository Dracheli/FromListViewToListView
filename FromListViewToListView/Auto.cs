using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromListViewToListView
{
    public class Auto
    {
        // Objektvariablen
        private string kennzeichen;
        private string marke;
        private string type;
        private string farbe;
        private int ps;

        // Konstruktoren
        public Auto() { }

        public Auto(string kennzeichen, string marke, string type, string farbe, int ps)
        {
            this.kennzeichen = kennzeichen;
            this.marke = marke;
            this.type = type;
            this.farbe = farbe;
            this.ps = ps;
        }

        // Zugriffsmethode (Properties)
        public String Kennzeichen
        {
            get { return kennzeichen; }
            set { kennzeichen = value; }
        }

        public String Marke
        {
            get { return marke; }
            set { marke = value; }
        }

        public String Type
        {
            get { return type; }
            set { type = value; }
        }

        public String Farbe
        {
            get { return farbe; }
            set { farbe = value; }
        }
        public int PS
        {
            get { return ps; }
            set { ps = value; }
        }
    }
}
